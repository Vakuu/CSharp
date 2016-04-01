using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Strings_and_Objects
{
    class Strings_and_Objects
    {
        static void Main(string[] args)
        {
            string var1 = "Hello";
            string var2 = "World";
            object obj3= var1+" "+var2;
            string var3 = obj3.ToString();
            Console.WriteLine(var3);
        }
    }
}
