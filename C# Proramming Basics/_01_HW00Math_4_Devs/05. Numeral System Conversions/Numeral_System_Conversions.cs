using System;

namespace Numeral_System_Conversions
{
    class Numeral_System_Conversions
    {
        static void Main()
        {
            string bin1234 = Convert.ToString(1234, 2);
            string hex1234 = 1234.ToString("X");
            int dec1100101 = Convert.ToInt32("1100101", 2);
            string hex1100101 = Convert.ToInt32("1100101", 2).ToString("X");
            int decABC = Convert.ToInt32("ABC", 16);
            string binABC = Convert.ToString(decABC, 2);
            Console.WriteLine("{0}{1} = {2}{3}","1234", "d", bin1234, "b");
            Console.WriteLine("{0}{1} = {2}{3}", "1234", "d", hex1234, "hex");
            Console.WriteLine("{0}{1} = {2}{3}", "1100101", "b", dec1100101, "d");
            Console.WriteLine("{0}{1} = {2}{3}", "1100101", "b", hex1100101, "hex");
            Console.WriteLine("{0}{1} = {2}{3}", "ABC", "hex", decABC, "d");
            Console.WriteLine("{0}{1} = {2}{3}", "ABC", "hex", binABC, "b");
        }
    }
}
