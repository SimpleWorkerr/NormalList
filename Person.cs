using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormalList
{
    class Person
    {
        public int Age { get; set; }
        public string? Name { get; set; }
        public string? Sername { get; set; }

        public override string ToString()
        {
            return $"Age: {this.Age,-4}{this.Name,-10}{this.Sername,-10}";
        }
    }
}
