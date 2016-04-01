using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_RandomNumbersInGivenRange
{
    class _11_RandomNumbersInGivenRange
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
            int n=getIntNumber("Enter n: ");
            int min = getIntNumber("Enter min: ");
            int max = getIntNumber("Enter max: ");
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                int number = rnd.Next(min, max+1);
                if (i==0)
                {
                    Console.Write(number);
                }
                else
                {
                    Console.Write(" "+number);
                }
            }
            Console.WriteLine();
        }
    }
}
