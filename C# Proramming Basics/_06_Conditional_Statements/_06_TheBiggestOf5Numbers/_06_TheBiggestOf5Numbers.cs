using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_TheBiggestOf5Numbers
{
    class _06_TheBiggestOf5Numbers
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
            double a = getDoubleNumber("Enter 1 of 5 real numbers a: ");
            double b = getDoubleNumber("Enter 2 of 5 real numbers b: ");
            double c = getDoubleNumber("Enter 3 of 5 real numbers c: ");
            double d = getDoubleNumber("Enter 4 of 5 real numbers c: ");
            double e = getDoubleNumber("Enter 5 of 5 real numbers c: ");
            double biggest;
            if ((a > b) && (a > c) && (a > d) && (a > e))
                biggest = a;
            else
                if ((b > c) && (b > d) && (b > e))
                    biggest = b;
                else
                    if ((c > d) && (c > e))
                        biggest = c;
                    else
                        if ((d > e))
                            biggest = d;
                        else
                            biggest = e;
            Console.WriteLine(biggest);
        }
    }
}
