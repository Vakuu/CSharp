using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_SquareRoot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a positive integer number: ");
            string first_String = Console.ReadLine();
            uint first_int = 0;
            try
            {
                first_int = uint.Parse(first_String);
                Console.WriteLine(Math.Sqrt(first_int));
            }
            catch (FormatException)
            {
                Console.WriteLine("{0} is invalid number ", first_String);
            }
            catch (OverflowException)
            {
                Console.WriteLine("{0} is nvalid number ", first_String);
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }
    }
}
