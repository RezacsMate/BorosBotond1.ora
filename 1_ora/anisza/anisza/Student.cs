using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anisza
{
    public class Student
    {
        public string name { get; set; }
        public string grade { get; set; }
        public int points { get; set; }
        

        public Student(string str)
        {
            name = str.Split(';')[0];
            grade = str.Split(";")[1];
            points = int.Parse(str.Split(";")[2]);
        }

        
        public override string ToString()
        {
            return $"{name}--{grade}--{points}";
        }
    }
}
