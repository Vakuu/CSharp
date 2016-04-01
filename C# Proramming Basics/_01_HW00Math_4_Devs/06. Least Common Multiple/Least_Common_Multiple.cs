using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Least_Common_Multiple
{
    class Least_Common_Multiple
    {
        public static int determineLCM(int a, int b)
        {
            int num1, num2;
            if (a > b)
            {
                num1 = a; num2 = b;
            }
            else
            {
                num1 = b; num2 = a;
            }
            for (int i = 1; i <= num2; i++)
            {
                if ((num1 * i) % num2 == 0)
                {
                    return i * num1;
                }
            }
            return num2;
        }
        static void Main()
        {
            int n1, n2;
            //Console.WriteLine("Enter 2 numbers to find LCM");
            //n1 = int.Parse(Console.ReadLine());
            //n2 = int.Parse(Console.ReadLine());
            n1 = 1234;
            n2 = 3456;
            int result = determineLCM(n1, n2);
            Console.WriteLine("LCM of {0} and {1} is {2}", n1, n2, result);
        }

    }
}
