using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_OddAndEvenProduct
{
    class _10_OddAndEvenProduct
    {

        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split(' ');
            BigInteger prod1=1;
            BigInteger prod2=1;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i%2==0)
                {
                    prod2 = prod2 * int.Parse(numbers[i]);
                }
                else
                {
                    prod1 = prod1 * int.Parse(numbers[i]);
                }
            }
            if (prod1 == prod2)
            {
                Console.WriteLine("yes");
                Console.WriteLine("product = " + prod1);
            }
            else
            {
                Console.WriteLine("no");
                Console.WriteLine("product_odd = " + prod1);
                Console.WriteLine("product_even = " + prod2);
            }
        }
    }
}
