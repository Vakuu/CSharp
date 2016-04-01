using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> bits= new List<char>();
            int x=int.Parse(Console.ReadLine());
            int f = int.Parse(Console.ReadLine());
            int r = int.Parse(Console.ReadLine());
            int i = 0;

            while (x != 0)
            {
                bits.Insert(0,((x & 1) == 1 ? '1' : '0'));
                x >>= 1;
                i++;
            }
            for (int j = i; j < 19; j++)
			{
			    bits.Insert(0,'0');
			}
            char save=bits[18-f];
            char buffer;
            bits.RemoveAt(18-f);
            for (int k = 0; k < r; k++)
			{
			    buffer=bits[17];
                bits.RemoveAt(17);
                bits.Insert(0,buffer);
			}
            bits.Insert(18-f, save);
            string result="";
            for (int l = 0; l < 19; l++)
			{
			    result+=bits[l];
			}
            Console.WriteLine(Convert.ToInt32(result,2));
        }
    }
}
