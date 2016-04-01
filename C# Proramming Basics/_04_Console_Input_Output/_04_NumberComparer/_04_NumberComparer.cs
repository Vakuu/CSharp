using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_NumberComparer
{
    class _04_NumberComparer
    {
        public static double getNumber(string msg)
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
                first_real = getNumber("Enter the number again: ");
            }
            catch (OverflowException)
            {
                Console.WriteLine("{0} is outside the range of a float.", first_String);
                first_real = getNumber("Enter the number again: ");
            }
            return first_real;
        }
        static void Main(string[] args)
        {
            double firstNumber = getNumber("Enter first of 2 numbers: ");
            double seecondNumber = getNumber("Enter second of 2 numbers: ");
            bool thirdnumber=firstNumber>seecondNumber;
            switch(thirdnumber)
            {
                case (true):
                    Console.WriteLine("The greater number is: {0}", firstNumber);
                break;
                case (false):
                    bool fourthNumber = firstNumber == seecondNumber;
                    switch(fourthNumber)
                    {
                        case(true):
                            Console.WriteLine("both number are equal: {0}", seecondNumber);
                        break;
                        case (false):
                            Console.WriteLine("The greater number is: {0}", seecondNumber);
                        break;
                    }
                break;
            }
        }
    }
}
