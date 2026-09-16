using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anisza
{
    public class Movie
    {
        public string Title { get; set; }
        public double rating { get; set; }
        public bool racomanded { get; set; }
        


        public Movie(string Title, double rating)
        {
            this.Title = Title;
            this.rating = rating;
            if (rating > 7.0)
            {
                racomanded = true;
            }
            else 
            {
                racomanded = false;
            }
        }
        public override string ToString()
        {
            return $"{Title}--{rating}--{racomanded}";
        }
    }
}
