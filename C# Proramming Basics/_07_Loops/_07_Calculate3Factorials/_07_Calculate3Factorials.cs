using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Calculate3Factorials
{
    class _07_Calculate3Factorials
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
            int k = getIntNumber("Enter k: ");
            BigInteger n_kf = 1;
            BigInteger nf = 1;
            for (uint i = 1; i <= n; i++)
            {
                if (i <= n-k)
                    n_kf = n_kf * i;
                if (i > k)
                    nf = nf * i;
            }
            Console.WriteLine(nf/n_kf);
        }
    }
}
