using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_NumbersInIntervalDividableByGivenNumber
{
    class _11_NumbersInIntervalDividableByGivenNumber
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
        public static int HowMany(int first, int second, int factor)
        {
            if ((first < factor) && (second < factor))
            {
                return 0;
            }
            //string list="";
            int the_larger;
            int real_first;
            if (second < first)
            {
                the_larger = first;
                if (second < factor)
                {
                    real_first = factor;
                }
                else
                {
                    int finding_first = factor;
                    for (int i = 1; finding_first < second; i++)
                    {
                        finding_first = factor * i;
                    }
                    real_first = finding_first;
                }
            }
            else
            {
                the_larger = second;
                if (first < factor)
                {
                    real_first = factor;
                }
                else
                {
                    int finding_first = factor;
                    for (int i = 1; finding_first < first; i++)
                    {
                        finding_first = factor * i;
                    }
                    real_first = finding_first;
                }
            }
            int first_number;
            for (int i = real_first; ; )
            {
                if (i % factor == 0)
                {
                    first_number = i;
                    //list = list+first_number;
                    break;
                }
                else
                {
                    i++;
                }
            }
            int next_number = first_number;
            int counter = 1;
            for (int i = first_number; i <= the_larger; i = i + factor)
            {
                counter++;
                //list = list + first_number;
            }
            return counter - 1;
        }
        static void Main(string[] args)
        {
            int first = getIntNumber("Enter first of 2 numbers:");
            int second = getIntNumber("Enter second of 2 numbers:");
            if ((first < 0) || (second < 0))
            {
                Console.WriteLine("One of the entered number is negative which contradicts to the conditions of the task. Go try again tongue emoticon");
            }
            else
            {
                int factor = 5;
                int howMany = HowMany(first, second, factor);
                Console.WriteLine("{0}", howMany);
            }
        }
    }
}