using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Persons
{
    class PersonMain
    {
        static void Main(string[] args)
        {
            Person a = new Person("Boiko Borisov", 25);
            Person b = new Person("Boris Boikov", 34, "B.Boikov@abv.bg");

            Console.WriteLine(a);
            Console.WriteLine(b);

         
        }
    }
}