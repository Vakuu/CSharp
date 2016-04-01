using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Animals
{
    class AddAnimals
    {
        static void Main()
        {
            var animals = new Animal[]
        {
            new Dog("Spot", 2, Gender.Male), 
            new Dog("Tara", 5, Gender.Female), 
            new Frog("Jabcho", 1, Gender.Male), 
            new Kitten("Kity", 2.5), 
            new Tomcat("Tom", 4.6)
        };
            animals.ToList().ForEach(Console.WriteLine);

            Console.WriteLine();

            var animalsBygroups = animals.GroupBy(GetAnimalKind,
                (g, a) => new { kind = g, averagAge = a.Average(animal => animal.Age) });

            foreach (var animalGroup in animalsBygroups)
            {
                Console.WriteLine("The average age of {0}s is {1:f2}.", animalGroup.kind, animalGroup.averagAge);
            }
        }

        public static string GetAnimalKind(Animal animal)
        {
            string kind = "";
            if (animal.GetType().BaseType.Name == "Animal")
            {
                kind = animal.GetType().Name;
            }
            else
            {
                kind = animal.GetType().BaseType.Name;
            }

            return kind;
        }
    }
}
