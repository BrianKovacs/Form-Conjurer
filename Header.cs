using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FormConjurerLib
{
    public class Header : Input
    {

        public Header(string Content)
        {
            this.Content = Content;
            this.Id = string.Empty;
            this.Name = string.Empty;
            this.Class = string.Empty;
        }

        public Header(string Content, string Id)
        {
            this.Content = Content;
            this.Id = Id;
            this.Name = string.Empty;
            this.Class = string.Empty;
        }

        public Header(string Content, string Id, string Class)
        {
            this.Content = Content;
            this.Id = Id;
            this.Class = Class;
            this.Name = string.Empty;
        }

        public Header(string Content, string Id, string Class, string Name)
        {
            this.Content = Content;
            this.Class = Class;
            this.Id = Id;
            this.Name = Name;
        }

        public void AddToContent(string input)
        {
            this.Content += input;
        }

        public override string Output(string input)
        {
            string OpenTag = "<h1 id=\"" + this.Id + "\" name=\"" + this.Name + "\" class=\"" + this.Class + "\">";
            string CloseTag = "</h1>";

            return OpenTag + input + CloseTag;
        }

    }
}
