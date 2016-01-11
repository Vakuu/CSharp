using System;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = 2*n;
            int n1 = n, n2 = n;

            for (int i = 1; i < n; i++)
            {
                for (int j = 1; j < width; j++)
                {
                    if ((j<n1)||(j>n2))
                    {
                        Console.Write(".");
                    }
                    if ((j == n1) || (j == n2))
                    {
                        Console.Write("*");
                    }
                    if ((j > n1) && (j < n2))
                    {
                        Console.Write(" ");
                    }
                }
                n1--;
                n2++;
                Console.WriteLine();
            }

            for (int i = 0; i < n; i++)
            {
                if (i==n)
                {
                    Console.WriteLine("*");
                }
                else
                {
                    Console.Write("* ");
                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(" ");
            }
            Console.WriteLine();
            Console.Write("+");
            for (int i = 0; i < 2*n-3; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine("+");
            for (int i = 0; i < n-2; i++)
            {
                for (int j = 1; j < width; j++)
                {
                    if ((j==1)||(j==width-1))
                    {
                        Console.Write("|");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.Write("+");
            for (int i = 0; i < 2 * n - 3; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine("+");
        }
    }
}
