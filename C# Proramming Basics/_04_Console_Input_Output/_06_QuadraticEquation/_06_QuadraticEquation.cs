using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_QuadraticEquation
{
    class _06_QuadraticEquation
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
            double a = getDoubleNumber("Enter \"a\" - the first queficient of quadratic equation(ax2+bx+c=0): ");
            double b = getDoubleNumber("Enter \"b\" - the second queficient: ");
            double c = getDoubleNumber("Enter \"c\" - the second queficient: ");
            double sqrtpart = b * b - 4 * a * c;
            double x, x1, x2, img;
            if (sqrtpart > 0)
            {
                x1 = (-b + Math.Sqrt(sqrtpart)) / (2 * a);
                x2 = (-b - Math.Sqrt(sqrtpart)) / (2 * a);
                Console.WriteLine("x1={0}; x2={1}", x1, x2);
            }
            else if (sqrtpart < 0)
            {
                sqrtpart = -sqrtpart;
                x = -b / (2 * a);
                img = Math.Sqrt(sqrtpart) / (2 * a);
                Console.WriteLine("x1={0}+{1}i; x2={2}+{3}i", x, img, x, img);
            }
            else
            {
                x = (-b + Math.Sqrt(sqrtpart)) / (2 * a);
                Console.WriteLine("x1=x2={0}", x);
            }
        }
    }
}
