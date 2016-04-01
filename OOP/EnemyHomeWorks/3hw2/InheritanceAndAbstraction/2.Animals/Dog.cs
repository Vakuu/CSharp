using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Animals
{
    public class Dog : Animal
    {
        public Dog(string name, double age, Gender gender)
            : base(name, age, gender)
        { }

        public override string ProduceSound()
        {
            return string.Format("Baw");
        }

    }
}
