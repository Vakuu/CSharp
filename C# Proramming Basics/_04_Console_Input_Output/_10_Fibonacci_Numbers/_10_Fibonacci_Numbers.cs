using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Fibonacci_Numbers
{
    class _10_Fibonacci_Numbers
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
            if (first_real < 1)
            {
                Console.WriteLine("The number can't be lesser than 1! :-p", first_String);
                first_real = getIntNumber("Enter the number again: ");
            }
            return first_real;
        }
        public static string getFirstNFiNumbers(int numb)
        {
            string result = "0";
            int fibonacci_prev = 0;
            int fibonacci_next = 1;
            if (numb == 2)
            {
                result += ", " + fibonacci_next;
            }
            else
            {
                result += ", " + fibonacci_next;
                int fibonacci_current;
                for (int i = 3; i < (numb + 1); i++)
                {
                    fibonacci_current = fibonacci_next;
                    fibonacci_next = fibonacci_prev + fibonacci_next;
                    fibonacci_prev = fibonacci_current;
                    result += ", " + fibonacci_next;
                }
            }
            return result;
        }
        static void Main()
        {
            int n = getIntNumber("Enter how many numbers from Fibonacci sequence to be shown you cannot enter lesser than 1 ;) :");
            string fiNumbers = getFirstNFiNumbers(n);
            Console.WriteLine("{0}", fiNumbers);
        }
    }
}