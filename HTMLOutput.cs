using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace FormConjurerLib
{
    public class HTMLOutput
    {   
        private string HTML { get; set; }
        private string DocHeader { get; set; }
        private string HTMLOpenTag { get; set; }
        private string HeadOpenTag { get; set; }
        private string HeadContents { get; set; }
        private string HeadCloseTage { get; set; }
        private string BodyOpenTag { get; set; }
        private Stack<string> BodyContents { get; set; }
        private string BodyCloseTag { get; set; }
        private string HTMLCloseTag { get; set; }

        public HTMLOutput()
        {
            this.DocHeader = "<!DOCTYPE html>";
            this.HTMLOpenTag = "<html>";
            this.HeadOpenTag = "<head>";
            this.HeadCloseTage = "</head>";
            this.BodyOpenTag = "<body>";
            this.BodyContents = new Stack<string>();
            this.BodyCloseTag = "</body>";
            this.HTMLCloseTag = "</html>";
            
        }
        public void AddTagToBody(Input input){

            this.BodyContents.Push(input.Output(input.Content));
        }

        public void RemoveTagFromBody()
        {
            if (this.BodyContents.Count > 0)
            this.BodyContents.Pop();
            
        }
        
        
        public void AddStyleSheet(StyleSheet css)
        {
            this.HeadContents = "<link href=\"" + css.path + "\" rel =\"stylesheet\" type=\"text/css\"";
        }
        
        public string OutPutHTML()
        {
            HTML = DocHeader + HTMLOpenTag + HeadOpenTag + HeadContents + HeadCloseTage + BodyOpenTag;
            foreach (string tag in BodyContents)
            {
                HTML += tag;

            } 
            HTML += BodyCloseTag + HTMLCloseTag;

            return HTML;
        }

        public void OutputFile(string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.Create))
            {
                using (StreamWriter sw = new StreamWriter(fs, Encoding.UTF8))
                {
                    sw.Write(OutPutHTML());
                }
            } 

        }

    }
}
