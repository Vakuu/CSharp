using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_PointInsideACircleAndOutsideOfARectangle
{
    class _10_PointInsideACircleAndOutsideOfARectangle
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
            double x = getDoubleNumber("Enter x of the point coords:");
            double y = getDoubleNumber("Enter y of the point coords:");
            bool incirc = false;
            if (Math.Sqrt((x-1d) * (x-1d) + (y-1d) * (y-1d)) <= 1.5d)
            {
                incirc = true;
            }
            else
                incirc = false;
            if (incirc)
            {
                if (((x>=-1)||(x<=6))&&((y>=-1)||(y<=1)))
                {
                    Console.WriteLine("yes");
                }else
                    Console.WriteLine("no");
            }
            else
            Console.WriteLine("no");
        }
    }
}
