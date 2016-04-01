using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excersize1
{
    class excersize1
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете първото число цяло между 0 и 500: ");
            string first_String = Console.ReadLine();
            int first = int.Parse(first_String);
            //firstbin=Convert.ToString(first, 2)
            Console.Write("Въведете второто реално число: ");
            string second_String = Console.ReadLine();
            double second_real = double.Parse(second_String);
            Console.Write("Въведете трето реално число: ");
            string third_String = Console.ReadLine();
            double third_real = double.Parse(third_String);
            Console.WriteLine("|{0,-10:X}|{1,-10}|{2,10:F2}|{3,-10:F3}|", first, Convert.ToString(first, 2), second_real, third_real);
        }
    }
}
