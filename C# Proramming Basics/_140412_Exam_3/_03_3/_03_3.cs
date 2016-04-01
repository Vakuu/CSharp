using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_3
{
    class _03_3
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //first line
            for (int j = 0; j < (n - 1) / 2; j++)
            {
                Console.Write(".");
            }
            Console.Write("*");
            for (int j = 0; j < (n - 1) / 2; j++)
            {
                Console.Write(".");
            }
            Console.WriteLine("");
            //roof lines
            for (int i = 0; i < (n-3)/2; i++)
            {
                for (int j = 0; j < (n-3)/2-i; j++)
                {
                    Console.Write(".");
                }
                Console.Write("*");
                for (int j = 0; j < (1+2*i); j++)
                {
                    Console.Write(".");
                }
                Console.Write("*");
                for (int j = 0; j < (n - 3) / 2 - i; j++)
                {
                    Console.Write(".");
                }
                Console.WriteLine("");
            }
            //bottom roof line
            for (int i = 0; i < n; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine("");
            //house lines
            for (int j = 0; j < (n - 3) / 2; j++)
            {
                for (int i = 0; i < n / 4; i++)
                {
                    Console.Write(".");
                }
                Console.Write("*");
                for (int i = 0; i < n - n / 4 - n / 4 - 2; i++)
                {
                    Console.Write(".");
                }
                Console.Write("*");
                for (int i = 0; i < n / 4; i++)
                {
                    Console.Write(".");
                }
                Console.WriteLine("");
            }
            //bottom line
            for (int i = 0; i < n / 4; i++)
            {
                Console.Write(".");
            }
            for (int i = 0; i < n - n / 4 - n / 4; i++)
            {
                Console.Write("*");
            }
            for (int i = 0; i < n / 4; i++)
            {
                Console.Write(".");
            }
            Console.WriteLine("");
        }
    }
}
