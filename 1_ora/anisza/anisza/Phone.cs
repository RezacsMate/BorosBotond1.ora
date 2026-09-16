using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anisza
{
    public class Phone
    {
        public string brand { get; set; }
        public string type { get; set; }
        public int price { get; set; }
        public Phone(string brand, string type)
        {
            this.brand = brand;
            this.type = type;
            price = 100000;

        }
        public Phone(string brand, string type, int price)
        {
            this.brand = brand;
            this.type = type;
            this.price = price;
        }
        public override string ToString()
        {
            return $"{brand}--{type}--{price}";
        }
    }
}
