using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_SortingNumbers
{
    class _02_SortingNumbers
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
                Console.WriteLine("{0} is outside the range of a float.", first_String);
                first_real = getIntNumber("Enter the number again: ");
            }
            return first_real;
        }
        static void Main(string[] args)
        {
            int n = getIntNumber("Enter n: ");
            int[] numbers;
            numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                numbers[i] = getIntNumber("");
            }
            Array.Sort(numbers);
            foreach (int i in numbers) Console.WriteLine(i);
        }
    }
}
