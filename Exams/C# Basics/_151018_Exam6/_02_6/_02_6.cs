using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_6
{
    class _02_6
    {
        static void Main(string[] args)
        {
            ulong N = ulong.Parse(Console.ReadLine());
            ulong sla = 0;
            ulong esc = 0;
            ulong beers = 0;
            for (ulong i = 0; i < N; i++)
            {
                ulong escAt = ulong.Parse(Console.ReadLine());
                if (escAt > 5)
                {
                    sla += 5;
                    esc += escAt - 5;
                }
                else
                {
                    sla += escAt;
                }
                ulong BescAt = ulong.Parse(Console.ReadLine());
                beers += BescAt;
            }
            Console.WriteLine("{0} thieves slapped.",sla);
            Console.WriteLine("{0} thieves escaped.", esc);
            Console.WriteLine("{0} packs, {1} bottles.", beers/6,beers%6);
        }
    }
}
