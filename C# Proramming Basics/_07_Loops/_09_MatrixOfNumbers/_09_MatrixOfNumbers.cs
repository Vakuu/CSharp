using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_MatrixOfNumbers
{
    class _09_MatrixOfNumbers
    {
        public static int getIntNumber(string msg)
        {
            Console.Write(msg);
            string first_String = Console.ReadLine();
            int first_real = 0;
            try
            {
                first_real = int.Parse(first_String);
            }
            catch (FormatException)
            {
                Console.WriteLine("'{0}' is not in a valid format.", first_String);
                first_real = getIntNumber("Enter the number again: ");
            }
            catch (OverflowException)
            {
                Console.WriteLine("{0} is outside the range of an integer.", first_String);
                first_real = getIntNumber("Enter the number again: ");
            }
            return first_real;
        }
        static void Main(string[] args)
        {
            int n = getIntNumber("");
            for (int i = 0; i < n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (j == 1)
                    {
                        Console.Write(i + j);
                    }
                    else
                    {
                        Console.Write(" " + (i + j));
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
