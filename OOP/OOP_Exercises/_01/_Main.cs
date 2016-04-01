using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Defining_Classes
{
    class _Main
    {
        static void Main(string[] args)
        {
            Dog unnamed = new Dog();
            Dog sharo = new Dog("Sharo", "Melez");

            unnamed.Breed="German Shephard";

            unnamed.Bark();
            sharo.Bark();
        }
    }
}
