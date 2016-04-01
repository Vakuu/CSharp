using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_BonusScore
{
    class _02_BonusScore
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
        static void Main(string[] args)
        {
            int score = getIntNumber("Enter Score in range [1..9]: ");
            if (score < 1)
            {
                Console.WriteLine("invalid score");
            }
            else
                if (score < 4)
                {
                    Console.WriteLine(score * 10);
                }
                else
                    if (score < 7)
                    {
                        Console.WriteLine(score * 100);
                    }
                    else
                        if (score < 10)
                        {
                            Console.WriteLine(score * 1000);
                        }
                        else
                        {
                            Console.WriteLine("invalid score");
                        }
        }
    }
}
