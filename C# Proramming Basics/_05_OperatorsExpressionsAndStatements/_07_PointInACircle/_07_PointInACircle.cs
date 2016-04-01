using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_PointInACircle
{
    class _07_PointInACircle
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
            double x=getDoubleNumber("Enter x of the point coords:");
            double y = getDoubleNumber("Enter y of the point coords:");
            if(Math.Sqrt(x*x+y*y)<=2d)
            {
                Console.WriteLine("inside: true");
            }else
                Console.WriteLine("inside: false");
        }
    }
}
