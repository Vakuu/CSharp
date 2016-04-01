using System;
using System.Numerics;

namespace Some_Factorials
{
    class Some_Factorials
    {
        public static BigInteger get_factorial_of(int numb) //функция която връща !numb
        {
            var bi = new BigInteger(1);
            for (int i = 2; i <= numb; i++)
            {
                bi *= i;
            } return bi;
        }
        static void Main()
        {
            BigInteger fact100 = get_factorial_of(100);
            BigInteger fact171 = get_factorial_of(171);
            BigInteger fact250 = get_factorial_of(250);
            //BigInteger fact1000 = get_factorial_of(1000);
            Console.WriteLine("!100 = " + fact100); Console.WriteLine();
            Console.WriteLine("!171 = " + fact171); Console.WriteLine();
            Console.WriteLine("!250 = " + fact250);
            //Console.WriteLine("!1000 = " + fact1000);
        }
    }
}
