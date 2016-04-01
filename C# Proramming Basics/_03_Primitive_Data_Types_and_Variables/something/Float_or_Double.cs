using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace something
{
    class Float_or_Double
    {
        static void Main(string[] args)
        {
            double num1 = 34.567839023d;
            float num2 = 12.345f;
            double num3 = 8923.1234857d;
            float num4 = 3456.091f;
            Console.WriteLine("като текст: {0},\nкато число: {1}", "34.567839023", num1);
            Console.WriteLine("като текст: {0},\nкато число: {1}", "12.345", num2);
            Console.WriteLine("като текст: {0},\nкато число: {1}", "8923.1234857", num3);
            Console.WriteLine("като текст: {0},\nкато число: {1}", "3456.091", num4);
        }
    }
}
