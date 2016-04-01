using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_3
{
    class _01_3
    {
        static void Main(string[] args)
        {
            int Ax = int.Parse(Console.ReadLine());
            int Ay = int.Parse(Console.ReadLine());
            int Bx = int.Parse(Console.ReadLine());
            int By = int.Parse(Console.ReadLine());
            int Cx = int.Parse(Console.ReadLine());
            int Cy = int.Parse(Console.ReadLine());
            double a = Math.Sqrt((Ax - Bx) * (Ax - Bx) + (Ay - By) * (Ay - By));
            double b = Math.Sqrt((Cx - Bx) * (Cx - Bx) + (Cy - By) * (Cy - By));
            double c = Math.Sqrt((Ax - Cx) * (Ax - Cx) + (Ay - Cy) * (Ay - Cy));
            if ((a+b>c)&&(a+c>b)&&(c+b>a))
            {
                Console.WriteLine("Yes");
                double p = (a + b + c) / 2d;
                double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                Console.WriteLine("{0:F2}", (decimal)area);
            }
            else
            { 
                Console.WriteLine("No");
                Console.WriteLine("{0:F2}",(decimal)a);
            }
        }
    }
}
