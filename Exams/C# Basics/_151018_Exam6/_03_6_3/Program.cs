using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_6_3
{

    class Program
    {
        static void swap(int a, int b)
        {
            a = a ^ b;
            b = a ^ b;
            a = a ^ b;
            //int temp = a;
            //a = b;
            //b = temp;
            Console.WriteLine("{0} {1}", a, b);
        }
        static void Main(string[] args)
        {
            for (int i = 0; i < 30; i++)
            {
                Console.Write(new string('$', i));
                Console.WriteLine();
            }
            int a = 5;
            int b = 3;
            swap(a, b);
            Console.WriteLine("{0} {1}",a, b);
        }
    }
}
