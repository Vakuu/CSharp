using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_RemoveNames
{
    class _06_RemoveNames
    {
        static void Main(string[] args)
        {
            string[] names1 = Console.ReadLine().Split(' ');
            string[] names2 = Console.ReadLine().Split(' ');
            foreach (var name in names2)
            {
                names1 = names1.Except(new string[] {name}).ToArray();
            }
            foreach (var name in names1)
            {
                if (name == names1[0])
                {
                    Console.Write(name);
                }
                else
                {
                    Console.Write(" " + name);
                }
            }
            Console.WriteLine("");
        }
    }
}
