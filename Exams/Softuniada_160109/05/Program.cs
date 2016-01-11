using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _05
{
    class Program
    {
        public static double getDistance(double cp1, double cp2, double rp1, double rp2)
        {
            return Math.Sqrt((cp1 - rp1) * (cp1 - rp1)
                            + (cp2 - rp2) * (cp2 - rp2)
                            );
        }

        static void Main(string[] args)
        {
            //int n = 1;
            int n = int.Parse(Console.ReadLine());
            string[,] t = new string[n, 2];
            for (int i = 0; i < n; i++)
            {
                //t[i, 0] = "circle(-6, 3, 1)";
                t[i, 0] = Console.ReadLine();
                //t[i, 1] = "rectangle(-3, 2, 2, -1)";
                t[i, 1] = Console.ReadLine();
            }
            string[] scn = new string[3];
            string[] srn = new string[4];
            double[] cn = new double[3];
            double[] rn = new double[4];
            for (int i = 0; i < n; i++)
            {
                if (t[i, 0].IndexOf("circle") > -1)
                {
                    string cnums = t[i, 0].Substring(7, t[i, 0].Length - 8);
                    scn = cnums.Split(',');
                    string rnums = t[i, 1].Substring(10, t[i, 1].Length - 11);
                    srn = rnums.Split(',');
                    //Console.WriteLine(cnums);
                    //Console.WriteLine(rnums);
                }
                else
                {
                    string rnums = t[i, 0].Substring(10, t[i, 0].Length - 11);
                    srn = rnums.Split(',');
                    string cnums = t[i, 1].Substring(7, t[i, 1].Length - 8);
                    scn = cnums.Split(',');
                    //Console.WriteLine(cnums);
                    //Console.WriteLine(rnums);
                }
                double cr = double.Parse(scn[2]);
                double cy = double.Parse(scn[1]);
                double cx = double.Parse(scn[0]);
                double rax = double.Parse(srn[0]);
                double ray = double.Parse(srn[1]);
                double rbx = double.Parse(srn[2]);
                double rby = double.Parse(srn[3]);
                //Console.WriteLine(cr);
                //Console.WriteLine(cy);
                //Console.WriteLine(cx);
                //Console.WriteLine(rax);
                //Console.WriteLine(ray);
                //Console.WriteLine(rbx);
                //Console.WriteLine(rby);
                if ((getDistance(cx, cy, rax, ray) < cr) && (getDistance(cx, cy, rbx, ray) < cr) &&
                    (getDistance(cx, cy, rax, rby) < cr) && (getDistance(cx, cy, rbx, rby) < cr))
                {
                    Console.WriteLine("Rectangle inside circle");
                }
                else
                {
                    if ((cx - cr >= rax) && (cx + cr <= rbx) && (cy + cr <= ray) && (cy - cr >= rby))
                    {
                        Console.WriteLine("Circle inside rectangle");
                    }
                    else
                    {
                        if (((cx + cr <= rax) && (cy - cr >= ray) && (getDistance(cx, cy, rax, ray) >= cr)) ||
                            ((cx - cr >= rbx) && (cy - cr >= ray) && (getDistance(cx, cy, rbx, ray) >= cr)) ||
                            ((cx - cr >= rbx) && (cy + cr <= rby) && (getDistance(cx, cy, rbx, rby) >= cr)) ||
                            ((cx + cr <= rax) && (cy + cr <= rby) && (getDistance(cx, cy, rax, rby) >= cr)))
                        {
                            Console.WriteLine("Rectangle and circle do not cross");
                        }
                        else
                        {
                            Console.WriteLine("Rectangle and circle cross");
                        }
                    }
                }
            }
        }
    }
}
