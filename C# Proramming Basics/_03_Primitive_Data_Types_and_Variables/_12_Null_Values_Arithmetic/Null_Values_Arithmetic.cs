using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Null_Values_Arithmetic
{
    class Null_Values_Arithmetic
    {
        static void Main()
        {
            int? valuei = 0;
            if (valuei == 0)
            {
                valuei = null;
            }
            double? valued = 0;
            if (valued == 0)
            {
                valued = null;
            }
            Console.WriteLine(valuei);
            Console.WriteLine(valued);
            valuei = valuei + null;
            valued = valued + 5;
            Console.WriteLine(valuei);
            Console.WriteLine(valued);
        }
    }
}
