using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat c1 = new Cat("c1",1,"male");
            Console.WriteLine(c1.ProduceSound());
            Dog d2 = new Dog("d2", 2, "male");
            Console.WriteLine(d2.ProduceSound());
            Frog f3 = new Frog("f3", 3, "female");
            Console.WriteLine(f3.ProduceSound());
            Kitten k4 = new Kitten("k4", 4);
            Console.WriteLine(k4.ProduceSound());
            Tomcat t5 = new Tomcat("t5", 5);
            Console.WriteLine(t5.ProduceSound());

            List<Animal> animals = new List<Animal>();
            animals.Add(c1);
            animals.Add(d2);
            animals.Add(f3);
            animals.Add(k4);
            animals.Add(t5);

            var dogsAge =
                from animal in animals
                where animal is Dog
                select animal.Age;

            int dogsAverage = dogsAge.Sum() / dogsAge.Count();
            Console.WriteLine(dogsAverage);
        }
    }
}
