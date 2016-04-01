using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Sort3NumbersWithNestedIfs
{
    class _07_Sort3NumbersWithNestedIfs
    {
        public static double getDoubleNumber(string msg)
        {
            Console.Write(msg);
            string first_String = Console.ReadLine();
            double first_real = 0;
            try
            {
                first_real = double.Parse(first_String);
            }
            catch (FormatException)
            {
                Console.WriteLine("'{0}' is not in a valid format.", first_String);
                first_real = getDoubleNumber("Enter the number again: ");
            }
            catch (OverflowException)
            {
                Console.WriteLine("{0} is outside the range of a float.", first_String);
                first_real = getDoubleNumber("Enter the number again: ");
            }
            return first_real;
        }
        static void Main(string[] args)
        {
            double a = getDoubleNumber("Enter 1 of 3 real numbers a: ");
            double b = getDoubleNumber("Enter 2 of 3 real numbers b: ");
            double c = getDoubleNumber("Enter 3 of 3 real numbers c: ");
            string sorted="";
            if (a > b)
                if (a < c)
                    sorted = "" + c + " " + a + " " + b;
                else
                    if (b < c)
                        sorted = "" + a + " " + c + " " + b;
                    else
                        sorted = "" + a + " " + b + " " + c;
            else
                if (a > c)
                    sorted = "" + b + " " + a + " " + c;
                else
                    if (b > c)
                        sorted = "" + b + " " + c + " " + a;
                    else
                        sorted = "" + c + " " + b + " " + a;
            Console.WriteLine(sorted);
        }
    }
}
