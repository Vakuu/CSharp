using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_NumbersFrom1ToN
{
    class _08_NumbersFrom1ToN
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
            int nth = getIntNumber("Enter integer number so the proram can display from 1 to that number each on separate line even if the number is negative ;) : ");
            int i = 1;
            for (;;)
            {
                Console.WriteLine(i);
                if (nth<1)
                {
                    i--;
                    if (i < nth)
                    {
                        break;
                    }
                }
                else
                {
                    i++;
                    if (i > nth)
                    {
                        break;
                    }
                }
            }
        }
    }
}
