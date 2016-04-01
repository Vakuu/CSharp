using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_CirclePerimeterAndArea
{
    class _03_CirclePerimeterAndArea
    {
        public static double getNumber(string msg)
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
                first_real = getNumber("Enter the number again: ");
            }
            catch (OverflowException)
            {
                Console.WriteLine("{0} is outside the range of a float.", first_String);
                first_real = getNumber("Enter the number again: ");
            }
            return first_real;
        }
        static void Main(string[] args)
        {
            double Pi = Math.PI;
            double radius = getNumber("Enter radius of a circle: ");
            Console.WriteLine("it's perimeter is: {0:F2}", 2*Pi*radius);
            Console.WriteLine("it's area is: {0:F2}", Pi * radius * radius);
        }
    }
}
