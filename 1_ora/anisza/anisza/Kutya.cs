using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anisza
{
    public class Kutya
    {
        public string name { get; set; }
        public string type { get; set; }
        public int age { get; set; }
        public Kutya(string name, string type, int age) 
        {
            this.name = name;
            this.type = type;
            this.age = age;
        }
        public override string ToString()
        {
            return $"{name}--{type}--{age}";
        }
    }
}
