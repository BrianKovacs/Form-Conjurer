using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FormConjurerLib
{
    public class InputText : Input
    {

        public InputText(string Content)
        {
            this.Content = Content;
            this.Id = string.Empty;
            this.Name = string.Empty;
            this.Class = string.Empty;
        }

        public InputText(string Content, string Id)
        {
            this.Content = Content;
            this.Id = Id;
            this.Name = string.Empty;
            this.Class = string.Empty;
        }

        public InputText(string Content, string Id, string Name)
        {
            this.Content = Content;
            this.Id = Id;
            this.Name = Name;
            this.Class = string.Empty;
        }

        public InputText(string Content, string Id, string Name, string Class)
        {
            this.Content = Content;
            this.Id = Id;
            this.Name = Name;
            this.Class = Class;
        }

        public void AddToContent(string input)
        {
            this.Content += input;
        }

        public override string Output(string input)
        {
            return input + " <input type=\"text\" id= \"" + this.Id + "\" name=\"" + this.Name + "\" class=\"" + this.Class + "\">";
        }

    }
}
