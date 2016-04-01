using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_PlayWithInt_DoubleAndString
{
    class Program
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
        public static double getDoubleNumber(string msg)
        {
            Console.Write(msg);
            string first_String = Console.ReadLine();
            double first_real = 0;
            try
            {
                first_real = double.Parse(first_String);
            }
            catch (FormatException)
            {
                Console.WriteLine("'{0}' is not in a valid format.", first_String);
                first_real = getDoubleNumber("Enter the number again: ");
            }
            catch (OverflowException)
            {
                Console.WriteLine("{0} is outside the range of a float.", first_String);
                first_real = getDoubleNumber("Enter the number again: ");
            }
            return first_real;
        }
        static void Main(string[] args)
        {
            int choice = getIntNumber("Please choose a type:\n1 --> int\n2 --> double\n3 --> string\n");
            switch (choice)
            {
                case 1:
                    int entered1 = getIntNumber("Enter an integer: ");
                    Console.WriteLine(entered1+1);
                    break;
                case 2:
                    double entered2 = getDoubleNumber("Enter a double: ");
                    Console.WriteLine(entered2+1d);
                    break;
                case 3:
                    Console.WriteLine("Enter a string: ");
                    string entered3 = Console.ReadLine();
                    Console.WriteLine(entered3+"*");
                    break;
                default:
                    break;
            }
        }
    }
}
