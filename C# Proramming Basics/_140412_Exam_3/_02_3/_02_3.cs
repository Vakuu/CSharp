using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.IO;

namespace _02_3
{
    class _02_3
    {
        static void Main(string[] args)
        {
            int newsum;
            int oldsum = 0;
            int diff = 0;
            int maxdiff = 0;

            //Console.SetIn(new StreamReader(Console.OpenStandardInput(8192)));

            string[] numbers = Console.ReadLine().Split(' ');
            for (int i = 0; i < numbers.Length - 1; i += 2)
            {
                if (i == 0)
                {
                    oldsum = int.Parse(numbers[i]) + int.Parse(numbers[i + 1]);
                }
                else
                {
                    newsum = int.Parse(numbers[i]) + int.Parse(numbers[i + 1]);
                    diff = Math.Abs(newsum - oldsum);
                    if (diff>maxdiff)
                    {
                        maxdiff = diff;
                    }
                    oldsum = newsum;
                }
            }
            if (maxdiff != 0)
            {
                Console.WriteLine("No, maxdiff=" + (maxdiff));
            }
            else
            {
                Console.WriteLine("Yes, value=" + oldsum);
            }
        }
    }
}
