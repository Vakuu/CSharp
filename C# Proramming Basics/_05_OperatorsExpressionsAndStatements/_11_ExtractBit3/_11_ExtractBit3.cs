using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_ExtractBit3
{
    class _11_ExtractBit3
    {
        public static uint getUIntNumber(string msg)
        {
            Console.Write(msg);
            string first_String = Console.ReadLine();
            uint first_real = 0;
            try
            {
                first_real = uint.Parse(first_String);
            }
            catch (FormatException)
            {
                Console.WriteLine("'{0}' is not in a valid format.", first_String);
                first_real = getUIntNumber("Enter the number again: ");
            }
            catch (OverflowException)
            {
                Console.WriteLine("{0} is outside the range of a float.", first_String);
                first_real = getUIntNumber("Enter the number again: ");
            }
            return first_real;
        }
        static void Main(string[] args)
        {
            uint n = getUIntNumber("Enter unsigned integer: ");
            uint mask = 8;
            Console.WriteLine((n&mask)>>3);
        }
    }
}
