using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.Square_Root
{
    class SquareRoot
    {
        
            static void Main(string[] args)
        {
            try
            {
                double input =double.Parse(Console.ReadLine());
                if (input < 0)
                {
                    throw new ArgumentException("Input has to be a positive number");   //throw an argument exception and catch it later
                }

                Console.WriteLine(Math.Sqrt(input));
            }
            catch (FormatException)//this catches the cases where the input contains non-digits
            {
                Console.WriteLine("Couldnt parse");
            }
            catch (ArgumentException)//this catches the negative input exception from earlyer
            {
                Console.WriteLine("Couldnt parse");
            }
            finally//execute this part in the end
            {
                Console.WriteLine("Good bye");
            }
        }
    }
}
