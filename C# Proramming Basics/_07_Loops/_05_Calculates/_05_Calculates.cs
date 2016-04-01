using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Calculates
{
    class _05_Calculates
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
        static void Main()
        {
            int n = getIntNumber("Enter n: ");
            int x = getIntNumber("Enter x: ");
            double res=1;
            double xprev=1;
            double iprev = 1;
            for (int i = 1; i <= n; i++)
            {
                xprev = xprev * x;
                iprev = iprev * i;
                res += iprev / xprev;
            }
            Console.WriteLine("{0:F5}",res);
        }
    }
}
