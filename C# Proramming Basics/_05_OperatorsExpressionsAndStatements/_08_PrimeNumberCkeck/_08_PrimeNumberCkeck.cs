using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_PrimeNumberCkeck
{
    class _08_PrimeNumberCkeck
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
                Console.WriteLine("{0} is outside the range of a float.", first_String);
                first_real = getIntNumber("Enter the number again: ");
            }
            return first_real;
        }
        public static Boolean if_nth_prime(int nth)
        {
            if (nth == 1)
            {
                return true;
            }if (nth == 2)
            {
                return true;
            }
            int prime_numb = 1;
            int chisloto = 0;
            bool yes = false;
            for (int i = 3; prime_numb < 101; i += 2)
            {
                int j;
                double sqrti = Math.Sqrt(i);
                for (j = 3; i % j != 0 && sqrti>j; j += 2);
                bool prime;
                if (j > sqrti)
                {
                    prime = true;
                }else
                {
                    prime = false;
                }
                if (prime)
                {
                    prime_numb = prime_numb + 1;
                    chisloto = i;
                    if (nth==i)
                    {
                        yes = true;
                    }
                }
            }
            return yes;
        }
        static void Main(string[] args)
        {
            int nth = getIntNumber("Enter n<=100: ");
            if (if_nth_prime(nth))
                Console.WriteLine("true");
            else
                Console.WriteLine("false");
        }
    }
}
