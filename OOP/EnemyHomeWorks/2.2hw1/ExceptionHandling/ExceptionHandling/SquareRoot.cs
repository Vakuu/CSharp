using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class SquareRoot
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Enter a number: ");
                double num = double.Parse(Console.ReadLine());
                if(double.IsNaN(num))
                {
                    throw new FormatException();
                }
                else if(num < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                double sqrt = Math.Sqrt(num);
                Console.WriteLine("Square root: {0}",sqrt);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number!");
            }
            catch(ArgumentOutOfRangeException)
            {
                Console.WriteLine("Invalid number! Number should be positive!");
            }
            finally
            {
                Console.WriteLine("Good bye!");
            }
        }
    }
}
