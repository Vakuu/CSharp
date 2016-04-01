using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterNumbers
{
    class EnterNumbers
    {
        static void Main(string[] args)
        {
            int start = 1;
            int end = 100;
            int counter = 0;

            Console.WriteLine("Enter 10 numbers between 1 and 100 in the following range:");
            Console.WriteLine("n1 < n2 < n3 < n4 < n5 < n6 < n7 < n8 < n9 < n10");
            

            while (counter < 10)
            {
                try
                {
                    int currentNum = ReadNumbers(start, end);

                    start = currentNum;
                    counter++;
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Number is out of range. Repeat input: {0}.");
                }
                catch (FormatException )
                {
                    Console.WriteLine("Number is not in the right format. Repeat input: {0}");
                }
                
            }
        }

        public static int ReadNumbers (int start, int end)
        {
            int num = int.Parse(Console.ReadLine());

            if (num < start || num > end)
            {
                throw new ArgumentOutOfRangeException();
            }
            return num;
        }
    }
}
