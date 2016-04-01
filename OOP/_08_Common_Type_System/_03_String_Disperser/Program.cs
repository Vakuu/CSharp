using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_String_Disperser
{
    class Program
    {
        static void Main(string[] args)
        {
            StringDisperser disprerser = new StringDisperser(new string[] { "gosho", "pesho", "tanio" });
            foreach (var character in disprerser)
            {
                Console.Write(character + " ");
            }
            Console.WriteLine();
        }
    }
}
