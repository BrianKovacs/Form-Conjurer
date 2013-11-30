using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FormConjurerLib
{
    public class InputText : Input
    {
        public InputText(string Id)
        {
            this.Id = Id;
            this.Name = string.Empty;
            this.Class = string.Empty;
        }
        public override string Output(string input)
        {
            return input + " <input type=\"text\" id= \"" + this.Id + "\" name=\"" + this.Name + "\" class=\"" + this.Class + "\">";
        }  
    }
}
