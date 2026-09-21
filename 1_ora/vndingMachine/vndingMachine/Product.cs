using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vndingMachine
{
    public class Product
    {
        string _code;
        string _name;
        int _price;
        int _stock;
        ProductCatagory _catagory;
        public string code { get; }
        public string name { get; }
        public int price { get; }
        public int stock { get; }
        public ProductCatagory category { get; }

        public Product(string _code, string _name, int _price, int
            _stock, ProductCatagory _catagory)
        {
            _code = code;
            _name = name;
            _price = price;
            _stock = stock;
            _catagory = category;


        }
        public void sell() 
        {
            _stock--;
        }
        public bool IsAvilable { get;  }

        
    }
}
