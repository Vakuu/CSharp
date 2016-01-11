using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            string snum = Console.ReadLine();
            string nnum = Console.ReadLine();
            int[] t1 = Array.ConvertAll(snum.Split(':'), c => (c == "") ? 0 : int.Parse(c));
            int[] t2 = Array.ConvertAll(nnum.Split(':'), c => (c == "") ? 0 : int.Parse(c));
            int d = 0;
            int h = 0;
            int m = 0;
            if (t1.Length == 2)
            {
                t1 = new int[4] { 0, 0, t1[0], t1[1] };
            }
            if (t2.Length == 2)
            {
                t2 = new int[4] { 0, 0, t2[0], t2[1] };
            }
            if (t1[3] + t2[3] > 59)
            {
                h = 1;
                m = t1[3] + t2[3] - 60;
                if (t1[2] + t2[2] + h > 23)
                {
                    d = 1 + t1[0] + t2[0];
                    h = h + t1[2] + t2[2] - 24;
                }
                else
                {
                    d = t1[0] + t2[0];
                    h = h + t1[2] + t2[2];
                }
            }
            else
            {
                m = t1[3] + t2[3];
                if (t1[2] + t2[2] + h > 23)
                {
                    d = 1 + t1[0] + t2[0]; ;
                    h = h + t1[2] + t2[2] - 24;
                }
                else
                {
                    d = t1[0] + t2[0];
                    h = h + t1[2] + t2[2];
                }
            }
            if (d > 0)
            {
                Console.Write(d + "::");
            }
            Console.Write(h + ":");
            if (m < 10)
            {
                Console.Write("0" + m);
            }
            else
            {
                Console.WriteLine(m);
            }
        }
    }
}
