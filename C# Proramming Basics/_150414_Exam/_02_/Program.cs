using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_
{
    class Program
    {
        static void Main(string[] args)
        {
            int numb = int.Parse(Console.ReadLine());
            int length = 0;
            bool trigger=true;
            for (int i = 0; i < numb; i++)
            {
                if (trigger)
                {
                    int cab = int.Parse(Console.ReadLine());
                    string meas = Console.ReadLine();
                    if (meas=="meters")
                    {
                        trigger = false;
                        length=cab*100; 
                    }
                    if (meas == "centimeters")
                    {
                        if (cab>=20)
                        {
                            trigger = false;
                            length = cab;
                        }
                    }
                }
                else
                {
                    int cab = int.Parse(Console.ReadLine());
                    string meas = Console.ReadLine();
                    if (meas == "meters")
                    {
                        length += (cab * 100)-3;
                    }
                    if (meas == "centimeters")
                    {
                        if (cab >= 20)
                        {
                            length += cab-3;
                        }
                    }
                }
            }
            int left = length % 504;
            int howMany = (length - left) / 504;
            Console.WriteLine(howMany);
            Console.WriteLine(left);
        }
    }
}
