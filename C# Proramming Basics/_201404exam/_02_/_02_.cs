using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_
{
    class _02_
    {
        static void Main(string[] args)
        {
            decimal OddSum = decimal.MaxValue;
            decimal OddMin = decimal.MinValue;
            decimal EvenMin = decimal.MinValue;
            decimal OddMax = decimal.MaxValue;
            decimal EvenMax = decimal.MaxValue;
            decimal EvenSum = decimal.MaxValue;
            string[] numbers;
            string entry = Console.ReadLine();
            if (entry!="")
            {   
                numbers = entry.Split(' ');
                int end = numbers.Length;
                if (end > 1000) { end = 1000; }
                for (int i = 0; i < end; i++)
                {
                    if (i % 2 == 0)
                    {
                        if (i == 0)
                        {
                            OddSum = decimal.Parse(numbers[i]);
                            OddMax = decimal.Parse(numbers[i]);
                            OddMin = decimal.Parse(numbers[i]);
                        }
                        else
                        {
                            OddSum = OddSum + decimal.Parse(numbers[i]);
                            if (OddMax < decimal.Parse(numbers[i]))
                            {
                                OddMax = decimal.Parse(numbers[i]);
                            }
                            if (OddMin > decimal.Parse(numbers[i]))
                            {
                                OddMin = decimal.Parse(numbers[i]);
                            }
                        }
                    }
                    else
                    {
                        if (i == 1)
                        {
                            EvenSum = decimal.Parse(numbers[i]);
                            EvenMax = decimal.Parse(numbers[i]);
                            EvenMin = decimal.Parse(numbers[i]);
                        }
                        else
                        {
                            EvenSum = EvenSum + decimal.Parse(numbers[i]);
                            if (EvenMax < decimal.Parse(numbers[i]))
                            {
                                EvenMax = decimal.Parse(numbers[i]);
                            }
                            if (EvenMin > decimal.Parse(numbers[i]))
                            {
                                EvenMin = decimal.Parse(numbers[i]);
                            }
                        }
                    }
                }
            }
            if (OddSum == decimal.MaxValue) { Console.Write("OddSum=No, "  ); }         else { Console.Write("OddSum=" +(double)OddSum+", ");}
            if (OddMin == decimal.MinValue) { Console.Write("OddMin=No, "  ); }         else { Console.Write("OddMin=" +(double)OddMin+", ");}
            if (OddMax == decimal.MaxValue) { Console.Write("OddMax=No, "  ); }         else { Console.Write("OddMax=" +(double)OddMax+", ");}
            if (EvenSum == decimal.MaxValue) { Console.Write("EvenSum=No, "); }         else { Console.Write("EvenSum="+(double)EvenSum+", ");}
            if (EvenMin == decimal.MinValue) { Console.Write("EvenMin=No, "); }         else { Console.Write("EvenMin="+(double)EvenMin+", ");}
            if (EvenMax == decimal.MaxValue) { Console.WriteLine("EvenMax=No"); } else { Console.WriteLine("EvenMax=" + (double)EvenMax); }
        }
    }
}