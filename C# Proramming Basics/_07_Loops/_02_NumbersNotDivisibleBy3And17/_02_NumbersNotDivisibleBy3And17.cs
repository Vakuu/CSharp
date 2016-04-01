using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_NumbersNotDivisibleBy3And17
{
    class _02_NumbersNotDivisibleBy3And17
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
                Console.WriteLine("{0} is outside the range of an integer.", first_String);
                first_real = getIntNumber("Enter the number again: ");
            }
            return first_real;
        }
        static void Main(string[] args)
        {
            int nth = getIntNumber("Enter integer number so the proram can display from 1 to that number skipping the divisibale to 3 and 7 on the same line seprated by space even if the number is negative ;) : ");
            int i = 1;
            string result = "";
            for (; ; )
            {
                if ((i % 3 != 0) && (i % 7 != 0))
                {
                    if (i == 1)
                        result += i;
                    else
                        result += " "+i;
                }
                if (nth < 1)
                {
                    i--;
                    if (i < nth)
                    {
                        Console.WriteLine(result);
                        break;
                    }
                }
                else
                {
                    i++;
                    if (i > nth)
                    {
                        Console.WriteLine(result);
                        break;
                    }
                }
            }
        }
    }
}
