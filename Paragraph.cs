using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormConjurerLib
{
    public class Paragraph : Input
    {

        public Paragraph(string Content)
        {
            this.Content = Content;
            this.Id = string.Empty;
            this.Name = string.Empty;
            this.Class = string.Empty;
        }

        public override string Output(string input)
        {
            string OpenTag = "<p id=\"" + this.Id + "\" name=\"" + this.Name + "\" class=\"" + this.Class + "\">";
            string CloseTag = "</p>";
            return OpenTag + input + CloseTag;
        }

        public void AddToContent(string input)
        {
            this.Content += input;
        }


    }
}
