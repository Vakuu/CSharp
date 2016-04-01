using System;
using MyFuncs;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_GravitationOnTheMoon
{
    class _02_GravitationOnTheMoon
    {
        static void Main()
        {
            int num1 = MyFuncs.MyFuncs.getIntNumber("Enter integer number to check if it is odd or even: ");
            float moonWeight = num1*17/100f;
            Console.WriteLine(moonWeight);
        }
    }
}
