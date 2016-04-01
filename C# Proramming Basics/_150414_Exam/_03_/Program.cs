using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string begin = Console.ReadLine();
            int d = 0;
            string sequence = "ABCDEFG";
            d = sequence.IndexOf(begin);
            int next = 1;
            bool up = true;
            for (int i = 0; i < n; i++)
            {
                if (up)
                {
                    if (next==1)
                    {
                        Console.Write("...");
                        for (int k = 1; k < next+1; k++)
                        {
                            if (d==7)
                            { d = 0; }
                            Console.Write(sequence.Substring(d, 1));
                            d++;
                        }
                        Console.WriteLine("...");
                        next = 3;
                    }
                    else
                    {
                        if (next == 3)
                        {
                            Console.Write("..");
                            for (int k = 1; k < next + 1; k++)
                            {
                                if (d == 7)
                                { d = 0; }
                                Console.Write(sequence.Substring(d, 1));
                                d++;
                            }
                            Console.WriteLine("..");
                            next = 5;
                        }
                        else
                        {
                            if (next == 5)
                            {
                                Console.Write(".");
                                for (int k = 1; k < next + 1; k++)
                                {
                                    if (d == 7)
                                    { d = 0; }
                                    Console.Write(sequence.Substring(d, 1));
                                    d++;
                                }
                                Console.WriteLine(".");
                                next = 7;
                            }
                            else
                            {
                                if (next == 7)
                                {
                                    //Console.Write("...");
                                    for (int k = 1; k < next + 1; k++)
                                    {
                                        if (d == 7)
                                        { d = 0; }
                                        Console.Write(sequence.Substring(d, 1));
                                        d++;
                                    }
                                    Console.WriteLine("");
                                    next = 5;
                                    up = false;
                                }
                            }
                        }
                    }
                }
                else
                {
                    if (next == 5)
                    {
                        Console.Write(".");
                        for (int k = 1; k < next + 1; k++)
                        {
                            if (d == 7)
                            { d = 0; }
                            Console.Write(sequence.Substring(d, 1));
                            d++;
                        }
                        Console.WriteLine(".");
                        next = 3;
                    }
                    else
                    {
                        if (next == 3)
                        {
                            Console.Write("..");
                            for (int k = 1; k < next + 1; k++)
                            {
                                if (d == 7)
                                { d = 0; }
                                Console.Write(sequence.Substring(d, 1));
                                d++;
                            }
                            Console.WriteLine("..");
                            next = 1;
                        }
                        else
                        {
                            Console.Write("...");
                            for (int k = 1; k < next + 1; k++)
                            {
                                if (d == 7)
                                { d = 0; }
                                Console.Write(sequence.Substring(d, 1));
                                d++;
                            }
                            Console.WriteLine("...");
                            if (next == 1)
                            {
                                next = 1;
                                up = true;
                            }
                        }
                    }
                }
            }
        }
    }
}
