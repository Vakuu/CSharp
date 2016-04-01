using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_3
{
    class _05_3
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int step = int.Parse(Console.ReadLine());
            List<char> bits=new List<char>();
            string chislo;
            int g;
            for (int i = 0; i < n; i++)
            {
                g = 0;
                int x = int.Parse(Console.ReadLine());
                while (x != 0)
                {
                    bits.Insert(i*8, ((x & 1) == 1 ? '1' : '0'));
                    x >>= 1;
                    g++;
                }
                for (int j = g; j < 8; j++)
                {
                    bits.Insert(i*8, '0');
                }
            }
            for (int i = 1; i < bits.Count; i=i+step-1)
            {
                bits.RemoveAt(i);
            }
            for (int i = 0; i < bits.Count%8; )
            {
                bits.Add('0');
            }
            for (int i = 0; i < bits.Count/8; i++)
            {
                chislo="";
                for (int j = i*8; j < i*8+8; j++)
                {
                    chislo+=bits[j];
                }
                Console.WriteLine(Convert.ToInt32(chislo,2));
            }
        }
    }
}
