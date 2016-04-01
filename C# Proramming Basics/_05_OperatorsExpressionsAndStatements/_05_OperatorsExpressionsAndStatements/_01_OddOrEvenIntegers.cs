using System;
//using MyFuncs;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_OperatorsExpressionsAndStatements
{
    class _01_OddOrEvenIntegers
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
        static void Main()
        {
            int num1 = getIntNumber("Enter integer number to check if it is odd or even: ");
            if (num1%2>0)
            {   
                Console.WriteLine("odd?: true");
            }else
            {
                Console.WriteLine("odd?: false");
            }
        }
    }
}

