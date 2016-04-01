using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_6
{
    class _03_6
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string Back = Console.ReadLine();
            string front = Console.ReadLine();
            string topline = "";
            for (int j = 0; j < N; j++)
            {
                topline += Back;
            }
            topline += front;
            for (int i = 0; i < 2*N-1; i++)
            {
                topline += Back;
            }
            topline += front;
            for (int j = 0; j < N; j++)
            {
                topline += Back;
            }
            Console.WriteLine(topline);
            //second lines
            int bet = 1;
            int net = 1;
            for (int i = 1; i < N-1; i++)
            {
                net += 2;
            }
            string middleline = "";
            middleline += front;
            for (int i = 0; i < net+2; i++)
            {
                middleline += Back;
            }
            middleline += front;
            for (int i = 0; i < net + 2; i++)
            {
                middleline += Back;
            }
            middleline += front;
            for (int i = 0; i < N-1; i++)
            {
                for (int j = i; j < N-1; j++)
                {
                    Console.Write(Back);
                }
                Console.Write(front);
                for (int j = 0; j < bet; j++)
                {
                    Console.Write(Back);
                }
                Console.Write(front);
                for (int j = 0; j < net; j++)
                {
                    Console.Write(Back);
                }
                Console.Write(front);
                for (int j = 0; j < bet; j++)
                {
                    Console.Write(Back);
                }
                Console.Write(front);
                for (int j = i; j < N - 1; j++)
                {
                    Console.Write(Back);
                }
                Console.WriteLine();
                bet += 2;
                net -= 2;
            }
            Console.WriteLine(middleline);
            bet = 1;
            net = 1;
            for (int i = 1; i < N - 1; i++)
            {
                net += 2;
            }
            for (int i = N-1; i > 0 ; i--)
            {
                for (int j = i; j < N; j++)
                {
                    Console.Write(Back);
                }
                Console.Write(front);
                for (int j = 0; j < net; j++)
                {
                    Console.Write(Back);
                }
                Console.Write(front);
                for (int j = 0; j < bet; j++)
                {
                    Console.Write(Back);
                }
                Console.Write(front);
                for (int j = 0; j < net; j++)
                {
                    Console.Write(Back);
                }
                Console.Write(front);
                for (int j = i; j < N; j++)
                {
                    Console.Write(Back);
                }
                Console.WriteLine();
                bet += 2;
                net -= 2;
            }
            Console.WriteLine(topline);
            bet = 1;
            net = 1;
            for (int i = 1; i < N - 1; i++)
            {
                net += 2;
            }
            for (int i = 0; i < N - 1; i++)
            {
                for (int j = i; j < N - 1; j++)
                {
                    Console.Write(Back);
                }
                Console.Write(front);
                for (int j = 0; j < bet; j++)
                {
                    Console.Write(Back);
                }
                Console.Write(front);
                for (int j = 0; j < net; j++)
                {
                    Console.Write(Back);
                }
                Console.Write(front);
                for (int j = 0; j < bet; j++)
                {
                    Console.Write(Back);
                }
                Console.Write(front);
                for (int j = i; j < N - 1; j++)
                {
                    Console.Write(Back);
                }
                Console.WriteLine();
                bet += 2;
                net -= 2;
            }
            Console.WriteLine(middleline);
            bet = 1;
            net = 1;
            for (int i = 1; i < N - 1; i++)
            {
                net += 2;
            }
            for (int i = N - 1; i > 0; i--)
            {
                for (int j = i; j < N; j++)
                {
                    Console.Write(Back);
                }
                Console.Write(front);
                for (int j = 0; j < net; j++)
                {
                    Console.Write(Back);
                }
                Console.Write(front);
                for (int j = 0; j < bet; j++)
                {
                    Console.Write(Back);
                }
                Console.Write(front);
                for (int j = 0; j < net; j++)
                {
                    Console.Write(Back);
                }
                Console.Write(front);
                for (int j = i; j < N; j++)
                {
                    Console.Write(Back);
                }
                Console.WriteLine();
                bet += 2;
                net -= 2;
            }
            Console.WriteLine(topline);
        }
    }
}
