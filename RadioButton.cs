using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FormConjurerLib
{
    public class RadioButton : Input
    {
         public RadioButton(string Name)
        {
            this.Id = string.Empty;
            this.Name = Name;
            this.Class = string.Empty;
        }
        public RadioButton(string Name, string Id)
        {
            this.Id = Id;
            this.Class = string.Empty;
            this.Name = Name;
        }
        public RadioButton(string Name, string Id, string Class)
        {
            this.Class = Class;
            this.Id = Id;
            this.Name = Name;
        }

        public override string Output(string Input)
        {
            string output = string.Empty;
            string[] temp = Input.Split('\n');
            foreach (string s in temp) {
                if (s != String.Empty)
                {   
                    output = output + "<input type=\"Radio\" name=\"" + this.Name + "\" value=\"" + s + "\">" + s + "<br>\n";
                }
            }
            return "<Form>\n" + output + "</Form>";
        }
    }
}
