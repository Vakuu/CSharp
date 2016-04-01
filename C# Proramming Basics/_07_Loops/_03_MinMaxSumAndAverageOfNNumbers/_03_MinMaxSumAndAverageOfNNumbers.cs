using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MinMaxSumAndAverageOfNNumbers
{
    class _03_MinMaxSumAndAverageOfNNumbers
    {
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
                Console.WriteLine("{0} is outside the range of an integer.", first_String);
                first_real = getIntNumber("Enter the number again: ");
            }
            return first_real;
        }
        static void Main(string[] args)
        {
            int nth = getIntNumber("");
            int[] numbers;
            numbers = new int[nth];
            for (int i = 0; i < nth; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("min = {0}",numbers.Min());
            Console.WriteLine("max = {0}", numbers.Max());
            Console.WriteLine("sum = {0}", numbers.Sum());
            Console.WriteLine("avg = {0:F2}", numbers.Average());
        }
    }
}
