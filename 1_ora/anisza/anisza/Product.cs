using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anisza
{
    public class Product
    {
        public string name { get; set; }
        public int ogPrice{ get; set; }
        public int discountPrice{ get; set; }


        public Product(string name, int ogPrice, int percent)
        {
            this.name = name;
            this.ogPrice = ogPrice;
            discountPrice *= 1- (percent/100); 
        }
        public override string ToString()
        {
            return $"{name}--{ogPrice}--{discountPrice}";
        }
    }
}
