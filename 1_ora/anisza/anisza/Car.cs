using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anisza
{
    public class Car
    {
        public string brand { get; set; }
        public string type { get; set; }
        public int make{ get; set; }
        public int age{ get; set; }

       
        public Car(string brand, string type, int make)
        {
            this.brand = brand;
            this.type = type;
            this.make = make;
            age = 2026 - make;
        }
        public override string ToString()
        {
            return $"{brand}--{type}--{make}--{age}";
        }
    }
}
