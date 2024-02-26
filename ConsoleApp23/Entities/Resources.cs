using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23.Entities
{
    internal class Resources
    {
        public string Name { get; set; }
        public double Value { get; set; }

        public Resources() { }

        public Resources(string name, double value)
        {
            Name = name;
            Value = value;
        }
    }
}
