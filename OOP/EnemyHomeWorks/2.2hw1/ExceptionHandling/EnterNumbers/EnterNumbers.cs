using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterNumbers
{
    class EnterNumbers
    {
        static double ReadNumber(int start, int end)
        {
            Console.WriteLine("Enter a number: ");
            double num = double.Parse(Console.ReadLine());

            if(num < start || num > end)
            {
                throw new ArgumentOutOfRangeException();
            }
            else if(double.IsNaN(num))
            {
                throw new FormatException();
            }
            return num;
        }
        static void Main()
        {
            int start = 1;
            int end = 100;
            int n = 10;
            double[] numbers = new double[n];

            int i = 0;
            int j = 1;
            do
            {
                try
                {
                    numbers[i] = ReadNumber(start, end);
                    numbers[i + 1] = ReadNumber(start, end);

                    if (numbers[i] > numbers[j])
                    {
                        throw new NotSupportedException();
                    }
                    i++;
                    j++;
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Numbers should be in range[1:10].\n");
                }
                catch(NotSupportedException)
                {
                    Console.WriteLine("Next number should be greater than the previous one.\n");
                }
                catch(FormatException)
                {
                    Console.WriteLine("Please, enter a number!\n");
                }

            } while (i < n/2);
        }
    }
}
