using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_InterestCalculator
{
    public class Program
    {
        private const int n = 12;

        static void Main()
        {
            Console.WriteLine("'Money' 'Interest' 'Years' 'Type' with spaces as separator:");

            while (true)
            {
                string[] commandargs = Console.ReadLine().Split(' ');
                if (commandargs[0].Equals("end"))
                {
                    break;
                }

                decimal money = decimal.Parse(commandargs[0]);
                double interest = double.Parse(commandargs[1]);
                int years = int.Parse(commandargs[2]);

                InterestCalculator calculator = null;

                switch (commandargs[3])
                {
                    case "compound":
                        calculator = new InterestCalculator(money, interest, years, new CalculateInterestDelegate(GetCompoundInterest));
                        break;
                    case "simple":
                        calculator = new InterestCalculator(money, interest, years, new CalculateInterestDelegate(GetSimpleInterest));
                        break;
                }

                Console.WriteLine("{0:F4}", calculator.GetInterest());
            }
        }

        private static double GetSimpleInterest(decimal sum, double interest, int years)
        {
            return (double)sum * (1 + (interest / 100) * years);
        }

        private static double GetCompoundInterest(decimal sum, double interest, int years)
        {
            return (double)sum * Math.Pow(1 + ((interest / 100) / n), years * n);
        }
    }
}
