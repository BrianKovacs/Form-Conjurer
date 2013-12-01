using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormConjurerLib
{
    public abstract class Input
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Class { get; set; }
        public string Content { get; set; }

        abstract public string Output(string input);
    }
}
