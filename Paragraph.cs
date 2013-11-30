using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormConjurerLib
{
    public class Paragraph : Input
    {
        public override string Output(string input)
        {
            string OpenTag = "<p id=\"" + this.Id + "\" name=\"" + this.Name + "\" class=\"" + this.Class + "\">";
            string CloseTag = "</p>";

            return OpenTag + input + CloseTag;
        }

        public Paragraph(string Id)
        {
            this.Id = Id;
            this.Name = string.Empty;
            this.Class = string.Empty;
        }
        public Paragraph(string Id, string Class)
        {
            this.Id = Id;
            this.Class = Class;
            this.Name = string.Empty;
        }
        public Paragraph(string Id, string Class, string Name)
        {
            this.Class = Class;
            this.Id = Id;
            this.Name = Name;
        }
    }
}
