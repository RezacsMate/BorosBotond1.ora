using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fajlbeolvasas
{
    public class Car
    {
        public string brand { get; set; }
        public string type { get; set; }
        public int bouldYear { get; set; }
        public int HP { get; set; }
        public int price{ get; set; }


        public Car(string line) 
        {
            string[] temp = line.Split(';');
            brand = temp[0];
            type = temp[1];
            bouldYear = int.Parse(temp[2]);
            HP = int.Parse(temp[3]);
            price = int.Parse(temp[4]);
        }
    }
}
