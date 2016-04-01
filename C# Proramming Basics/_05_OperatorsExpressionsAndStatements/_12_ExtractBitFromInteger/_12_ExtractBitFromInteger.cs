using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_ExtractBitFromInteger
{
    class _12_ExtractBitFromInteger
    {
        public static int getIntNumber(string msg)
        {
            Console.Write(msg);
            string first_String = Console.ReadLine();
            int first_real = 0;
            try
            {
                first_real = int.Parse(first_String);
            }
            catch (FormatException)
            {
                Console.WriteLine("'{0}' is not in a valid format.", first_String);
                first_real = getIntNumber("Enter the number again: ");
            }
            catch (OverflowException)
            {
                Console.WriteLine("{0} is outside the range of a float.", first_String);
                first_real = getIntNumber("Enter the number again: ");
            }
            return first_real;
        }
        static void Main(string[] args)
        {
            int n = getIntNumber("Enter integer n: ");
            int p = getIntNumber("Enter index p: ");
            int mask = 2;
            for (int i = 1; i < p; i++)
			{
                mask=mask*2;
			}
            //Console.WriteLine(mask);
            Console.WriteLine((n & mask) >> p);
        }
    }
}
