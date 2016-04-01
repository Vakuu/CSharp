using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Rectangles
{
    class _04_Rectangles
    {
        static void Main()
        {
            Console.Write("a= ");
            string num1str = Console.ReadLine();
            double num1 = double.Parse (num1str);
            Console.Write("b= ");
            string num2str = Console.ReadLine();
            double num2 = double.Parse(num2str);
            double area = num1 * num2;
            Console.WriteLine(area);
            double perimeter = (num1 + num2)*2;
            Console.WriteLine(perimeter);
        }
    }
}
