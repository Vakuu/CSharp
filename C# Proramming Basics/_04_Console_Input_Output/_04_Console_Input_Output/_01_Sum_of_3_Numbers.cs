using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Console_Input_Output
{
    class _01_Sum_of_3_Numbers
    {
        public static double get_number(int attempt)
        {
            if (attempt == 0)
            {
                Console.Write("Enter a real number: ");
            }else
            {
                Console.Write("Enter the number again: ");
            }
            string first_String = Console.ReadLine();
            double first_real=0;
            try
            {
                first_real = double.Parse(first_String);
            }
            catch (FormatException)
            {
                Console.WriteLine("'{0}' is not in a valid format.", first_String);
                first_real=get_number(1);
            }
            catch (OverflowException)
            {
                Console.WriteLine("{0} is outside the range of a float.", first_String);
                first_real=get_number(1);
            }
            return first_real;
        }
        static void Main(string[] args)
        {
            double first=get_number(0);
            double second = get_number(0);
            double third = get_number(0);
            Console.WriteLine("sum={0}", (first + second + third));
            if (first == 0 || second == 0 || third == 0)
            {
                Console.WriteLine("Imposible!");
            }
        }
    }
}
