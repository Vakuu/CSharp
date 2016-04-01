using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_SumОf5Numbers
{
    class _07_SumОf5Numbers
    {
        public static double getNDoubleNumbers(int howManyNumbers,string msg)
        {
            Console.Write(msg);
            string first_String = Console.ReadLine();
            double sum=0;
            double sun = 0;
            List<string> numbers = first_String.Split(' ').ToList();
            if (numbers.Count != howManyNumbers)
            {
                Console.WriteLine("The entered numbers are not {0}", howManyNumbers);
                sum = getNDoubleNumbers(howManyNumbers, "Enter the numbers again: ");
            }
            else
            {
                numbers.ForEach(delegate(String number)
                {
                    double first_real = 0;
                    try
                    {
                        first_real = double.Parse(number);
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("'{0}' is not in a valid format.", number);
                        sun = getNDoubleNumbers(howManyNumbers, "Enter the numbers again: ");
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine("{0} is outside the range of a float.", number);
                        sun = getNDoubleNumbers(howManyNumbers, "Enter the numbers again: ");
                    }
                    if (sun != 0)
                    {
                        sum = sun;
                    }
                    else
                    {
                        sum = sum + first_real;
                    }
                });
            }
            return sum;
        }
        public static int getIntNumber(string msg)
        {
            Console.Write(msg);
            string first_String = Console.ReadLine();
            int first_real = 0;
            try
            {
                first_real = int.Parse(first_String);
            }
            catch (FormatException)
            {
                Console.WriteLine("'{0}' is not in a valid format.", first_String);
                first_real = getIntNumber("Enter the number again: ");
            }
            catch (OverflowException)
            {
                Console.WriteLine("{0} is outside the range of a float.", first_String);
                first_real = getIntNumber("Enter the number again: ");
            }
            return first_real;
        }
        static void Main(string[] args)
        {

            //int n = getIntNumber("Enter how many numbers you would like to enter to be summed:");
            int n = 5;
            double sum = getNDoubleNumbers(n,"Enter "+n+" numbers separated with space (\" \"): ");
            Console.WriteLine("The sum of all numbers is: {0}", sum);
        }
    }
}
