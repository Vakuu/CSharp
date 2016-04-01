using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Animals
{
    public class Tomcat : Cat
    {
        public Tomcat(string name, double age)
            : base(name, age, Gender.Male) { }
    }
}
