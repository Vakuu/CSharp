using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_CatalanNumbers
{
    class _08_CatalanNumbers
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
            int n = getIntNumber("Enter n: ");
            BigInteger n_1f= 1;
            BigInteger n2f=n+1;
            for (int i = 1; i <= 2*n; i++)
            {
                if (i < n + 2)
                    n_1f = n_1f * i;
                else
                    n2f = n2f * i;
            }
            Console.WriteLine(n2f*1/n_1f);
        }
    }
}
