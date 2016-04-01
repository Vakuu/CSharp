using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate_Hypotenuse
{
    class Calculate_Hypotenuse
    {
        public static double get_hypotenuse(int a, int b) //функция която връща позицията във фибоначи редицата на подадено число, а ако подаденото й число не е от фибоначи редицата връща 0
        {
            return Math.Sqrt((a*a) + (b*b));
        }
        static void Main()
        {
            double hypo_3_4 = get_hypotenuse(3, 4);
            double hypo_10_12 = get_hypotenuse(10, 12);
            double hypo_100_250 = get_hypotenuse(100, 250);
            Console.WriteLine("The hypotenuse of catheti 3 and 4 is: " + hypo_3_4);
            Console.WriteLine("The hypotenuse of catheti 10 and 12 is: " + hypo_10_12);
            Console.WriteLine("The hypotenuse of catheti 100 and 250 is: " + hypo_100_250);
        }
    }
}
