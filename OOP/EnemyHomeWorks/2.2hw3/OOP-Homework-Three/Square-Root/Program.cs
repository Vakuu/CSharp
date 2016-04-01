using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_Root
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number n:");

            try
            {
                int n = int.Parse(Console.ReadLine());
                if (n < 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid number.");
                }

                double sqrt = Math.Sqrt(n);
                Console.WriteLine(sqrt);

            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number.");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Invalid number.");
            }
            finally
            {
                Console.WriteLine("Good bye.");
            }
        }
    }
}
