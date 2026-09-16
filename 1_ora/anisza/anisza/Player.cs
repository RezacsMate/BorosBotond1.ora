using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anisza
{
    public class Player
    {
        public string name { get; set; }
        public int lvl { get; set; }
        public int point { get; set; }

        public Player(string name) 
        {
            this.name = name;
            lvl = 1;
            point = 0;
        }
       
        public Player(string name, int lvl, int point)
        {
            this.name = name;
            this.lvl = lvl;
            this.point = point;
        }
        public override string ToString()
        {
            return $"{name}--{lvl}--{point}";
        }
    }
}
