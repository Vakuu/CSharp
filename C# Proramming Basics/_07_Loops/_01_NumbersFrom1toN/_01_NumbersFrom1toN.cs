using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_NumbersFrom1toN
{
    class _01_NumbersFrom1toN
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
            int nth = getIntNumber("Enter integer number so the proram can display from 1 to that number on the same line seprated by space even if the number is negative ;) : ");
            int i = 1;
            for (; ; )
            {
                if (i == nth)
                {
                    Console.Write(i);
                }
                else
                {
                    Console.Write(i + " ");
                }
                if (nth < 1)
                {
                    i--;
                    if (i < nth)
                    {
                        Console.WriteLine();
                        break;
                    }
                }
                else
                {
                    i++;
                    if (i > nth)
                    {
                        Console.WriteLine();
                        break;
                    }
                }
            }
        }
    }
}
