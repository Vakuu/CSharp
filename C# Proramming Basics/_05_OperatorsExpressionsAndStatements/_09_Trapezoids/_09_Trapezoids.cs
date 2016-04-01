using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Trapezoids
{
    class _09_Trapezoids
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
            double a = getDoubleNumber("Enter a of Trapezoid: ");
            double b = getDoubleNumber("Enter b of Trapezoid: ");
            double h = getDoubleNumber("Enter h of Trapezoid: ");
            Console.WriteLine((a+b)*h/2d);
        }
    }
}
