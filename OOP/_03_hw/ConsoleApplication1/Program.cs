using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 1000; i++)
            {
                if ((60*i+1)%7==0)
                {
                    Console.WriteLine((60 * i + 1));
                }
            }
        }
    }
}
