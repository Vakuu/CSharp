using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_EnterNumbers
{
    class Program
    {
        public static int getIntNumber(string msg, int start, int end)
        {
            Console.Write(msg+"in the range [{0}..{1}]: ",start,end);
            string first_String = Console.ReadLine();
            int first_int = 0;
            try
            {
                first_int = int.Parse(first_String);
                if ((first_int<start)||(first_int>end))
                {
                    throw new OverflowException();
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("{0} is non-number.", first_String);
                first_int = getIntNumber("Enter the number again ", start, end);
            }
            catch (OverflowException)
            {
                Console.WriteLine("{0} is outside the range.", first_String);
                first_int = getIntNumber("Enter the number again ", start, end);
            }
            return first_int;
        }
        static void Main(string[] args)
        {
            int start = 1;
            int end = 100;
            int howMany = 10;
            for (int i = 0; i < howMany; i++)
            {
                start=getIntNumber("Enter a number ", start, end)+1;
            }
        }
    }
}
