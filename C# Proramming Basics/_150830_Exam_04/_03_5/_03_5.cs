using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_5
{
    class _03_5
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int earcount = n;
            for (int i = n; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(".");
                }
                for (int j = 0; j < 3*n+2-2*i; j++)
                {
                    if ((j < ((3 * n + 2 - 2 * i) - (earcount)) / 2)||(j >= (((3 * n + 2 - 2 * i) - (earcount)) / 2) + earcount))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
                for (int j = 0; j < i; j++)
                {
                    Console.Write(".");
                }
                earcount -= 2;
                Console.WriteLine();
            }
            for (int i = 0; i < 3*n+2; i++)
            {
                if (i == (3 * n + 1) / 2)
                {
                    Console.Write("O");
                }
                else
                {
                    Console.Write("*");
                }
            }
            Console.WriteLine();
            Console.Write(".");
            for (int i = 0; i < 3 * n; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine(".");
            int neck=3*n;
            while (neck>n+2)
            {
                neck -= 4;
                for (int i = 0; i < ((3*n+2)-neck)/2; i++)
                {
                    Console.Write(".");
                }
                for (int i = 0; i < neck; i++)
                {
                    Console.Write("*");
                }
                for (int i = 0; i < ((3 * n + 2) - neck) / 2; i++)
                {
                    Console.Write(".");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < (3*n+2-n)/2; j++)
                {
                    Console.Write(".");
                }
                for (int j = 0; j < n; j++)
                {
                    Console.Write("*");
                }
                for (int j = 0; j < (3 * n + 2 - n) / 2; j++)
                {
                    Console.Write(".");
                }
                Console.WriteLine();
            }
        }
    }
}
