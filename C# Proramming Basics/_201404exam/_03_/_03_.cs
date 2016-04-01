using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_
{
    class _03_
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = n * 2;
            int aside = (width - n) / 2;
            for (int i = 1; i < 2*n; i++)
            {
                if (i < n)
                {
                    if (i == 1)
                    {
                        for (int j = 0; j < (n-1)/2; j++)
                        {
                            Console.Write('.');
                        }
                        for (int j = 0; j < n; j++)
                        {
                            Console.Write("#");
                        }
                        for (int j = 0; j < (n - 1) / 2; j++)
                        {
                            Console.Write('.');
                        }
                        Console.WriteLine("");
                    }
                    else
                    {
                        for (int j = 0; j < (n - 1) / 2; j++)
                        {
                            Console.Write('.');
                        }
                        Console.Write("#");
                        for (int j = 0; j < n - 2; j++)
                        {
                            Console.Write(".");
                        }
                        Console.Write("#");
                        for (int j = 0; j < (n - 1) / 2; j++)
                        {
                            Console.Write('.');
                        }
                        Console.WriteLine("");
                    }

                }
                else
                {
                    if (i == n)
                    {
                        for (int j = 0; j < (n - 1) / 2+1; j++)
                        {
                            Console.Write('#');
                        }
                        for (int j = 0; j < n - 2; j++)
                        {
                            Console.Write(".");
                        }
                        for (int j = 0; j < (n - 1) / 2 + 1; j++)
                        {
                            Console.Write('#');
                        }
                        Console.WriteLine("");
                    }
                    else
                    {
                        for (int j = 0; j < i-n; j++)
                        {
                            Console.Write('.');
                        }
                        Console.Write("#");
                        for (int j = 0; j < 2*n-1-2-2*(i-n); j++)
                        {
                            Console.Write(".");
                        }
                        if (i == 2 * n - 1)
                        { }
                        else
                        {
                            Console.Write("#");
                        }
                        for (int j = 0; j < i-n; j++)
                        {
                            Console.Write('.');
                        }
                        Console.WriteLine("");
                    }
                }
            }
        }
    }
}
