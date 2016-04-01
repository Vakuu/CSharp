using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_2
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong x = ulong.Parse(Console.ReadLine());
            List<char> bits = new List<char>();
            int i = 0;
            while (x != 0)
            {
                bits.Insert(0, ((x & 1) == 1 ? '1' : '0'));
                x >>= 1;
                i++;
            }
            for (int j = i; j < 64; j++)
            {
                bits.Insert(0, '0');
            }
            for (int j = 2; j < bits.Count(); j++)
            {
                if (bits[j] == bits[j - 1] && bits[j] == bits[j - 2])
                {
                    if (bits[j]=='0')
                    {
                        bits[j] = '1';
                        bits[j - 1] = '1';
                        bits[j - 2] = '1';
                        j = j + 2;
                    }
                    else
                    {
                        bits[j] = '0';
                        bits[j - 1] = '0';
                        bits[j - 2] = '0';
                        j = j + 2;
                    }
                }
            }
            string result = "";
            for (int l = 0; l < bits.Count(); l++)
            {
                result += bits[l];
            }
            Console.WriteLine((ulong)Convert.ToInt64(result, 2));
            //Console.WriteLine(bits.Count());
        }
    }
}
