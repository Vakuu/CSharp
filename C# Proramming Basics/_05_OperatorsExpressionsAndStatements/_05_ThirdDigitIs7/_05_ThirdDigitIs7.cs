using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ThirdDigitIs7
{
    class _05_ThirdDigitIs7
    {
        static void Main()
        {
            string num1str = Console.ReadLine();

            if (num1str.IndexOf("7") == num1str.Length - 3)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
