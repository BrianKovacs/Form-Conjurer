using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FormConjurerLib
{
    public class Header : Input
    {
        public override string Output(string input)
        {
            string OpenTag = "<h1 id=\"" + this.Id + "\" name=\"" + this.Name + "\" class=\"" + this.Class + "\">";
            string CloseTag = "</h1>";

            return OpenTag + input + CloseTag;
        }

        public Header(string Id)
        {
            this.Id = Id;
            this.Name = string.Empty;
            this.Class = string.Empty;
        }
        public Header(string Id, string Class)
        {
            this.Id = Id;
            this.Class = Class;
            this.Name = string.Empty;
        }
        public Header(string Id, string Class, string Name)
        {
            this.Class = Class;
            this.Id = Id;
            this.Name = Name;
        }
    }
}
