using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_MatrixOfPalindromes
{
    class _04_MatrixOfPalindromes
    {
        static void Main(string[] args)
        {
            string entries = Console.ReadLine();
            string[] coords = entries.Split(' ');
            int r = int.Parse(coords[0]);
            int c = int.Parse(coords[1]);
            if ((97 + r > 124) || (97 + r+c > 124))
            { }
            else
            {
                char character1;
                char character2;
                for (int i = 97; i < 97 + r; i++)
                {
                    for (int j = 0; j < c; j++)
                    {
                        character1 = (char)i;
                        character2 = (char)(i + j);
                        if (j == 0)
                        {
                            Console.Write(character1.ToString() + character2.ToString() + character1.ToString());
                        }
                        else
                        {
                            Console.Write(" "+character1.ToString() + character2.ToString() + character1.ToString());
                        }
                    }
                    Console.WriteLine();
                }
                //int ascii = (int)'z';
            }
        }
    }
}
