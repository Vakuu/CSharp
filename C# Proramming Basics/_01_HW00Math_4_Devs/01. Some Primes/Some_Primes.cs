using System;

namespace Some_Primes
{   class Some_Primes
    {   public static int get_nth_prime(int nth)
        {
            if (nth == 1)
            {
                return 1;
            }if (nth == 2)
            {
                return 2;
            }int prime_numb = 1;
            int chisloto = 0;
            for (int i = 3; prime_numb < nth; i += 2)
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
                }if (prime)
                {
                    prime_numb = prime_numb + 1;
                    chisloto = i;
                }
            }
        return chisloto;
        }
        static void Main()
        {
            //Console.Write("enter which prime number you want to be found: ");
            //string num1str = Console.ReadLine();
            //int num1 = int.Parse(num1str);
            //int res = get_nth_prime(num1);
            int th24 = get_nth_prime(24);
            int st101 = get_nth_prime(101);
            int st251 = get_nth_prime(251);
            Console.WriteLine("{0} prime number is: {1}", "24th", th24);
            Console.WriteLine("{0} prime number is: {1}", "101st", st101);
            Console.WriteLine("{0} prime number is: {1}", "251st", st251);
        }
    }
}
