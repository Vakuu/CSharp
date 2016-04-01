using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintASequence
{
    class PrintASequence
    {
        static void Main(string[] args)
        {
            for (int i = 2; i < 12; i += 2)
            {
                if (i == 10)
                {
                    Console.WriteLine(i + ",-" + (i + 1));
                }
                else
                {
                    Console.Write(i + ",-" + (i + 1)+",");
                }
            }
        }
    }
}
