using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Animals
{
    public class Cat : Animal
    {
        protected Cat(string name, double age, Gender gender)
            : base(name, age, gender)
        {
        }

        public override string ProduceSound()
        {
            return string.Format("Miau");
        }
    }
}
