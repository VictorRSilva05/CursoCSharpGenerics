using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23.Entities
{
    internal class Resources : IComparable
    {
        public string Name { get; set; }
        public double Value { get; set; }

        public Resources() { }

        public Resources(string name, double value)
        {
            Name = name;
            Value = value;
        }

        public override string ToString()
        {
            return Name + ", " + Value;
        }

        public int CompareTo(object? obj)
        {
            if(!(obj is Resources))
            {
                throw new ArgumentException("Comparing error: argument is not a project");
            }
            Resources other = obj as Resources;
            return Value.CompareTo(other.Value);
        }
    }
}
