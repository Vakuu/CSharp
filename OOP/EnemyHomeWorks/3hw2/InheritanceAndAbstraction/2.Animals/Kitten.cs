using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Animals
{
    public class Kitten : Cat
    {
        public Kitten(string name, double age)
            : base(name, age, Gender.Female) { }
    }
}
