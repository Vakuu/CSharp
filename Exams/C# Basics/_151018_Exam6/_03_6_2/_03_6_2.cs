using System;
class _03_6_2
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        int length = 4 * N + 1;
        string back = Console.ReadLine();
        string front = Console.ReadLine();
        int n1 = N;
        int n2 = N;
        int n3 = 3 * N;
        int n4 = 3 * N;
        for (int i = 0; i < length; i++)
        {
            for (int j = 0; j < length; j++)
            {
                if ((j == n1) || (j == n2) || (j == n3) || (j == n4))
                {
                    Console.Write(front);
                }
                else
                {
                    Console.Write(back);
                }
            }
            if ((i < N) || ((i >= 2 * N) && (i < 3 * N)))
            {
                n1--;
                n2++;
                n3--;
                n4++; 
            }
            else 
            { 
                n1++; 
                n2--; 
                n3++; 
                n4--; 
            }
            Console.WriteLine();
        }
    }
}