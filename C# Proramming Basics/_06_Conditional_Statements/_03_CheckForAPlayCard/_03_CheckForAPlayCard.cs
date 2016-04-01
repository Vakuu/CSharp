using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_CheckForAPlayCard
{
    class _03_CheckForAPlayCard
    {
        static void Main(string[] args)
        {
            string cards = ",2,3,4,5,6,7,8,9,10,J,Q,K,A,";
            Console.Write("Enter a string to be checked if it is a card or not: ");
            string entered= Console.ReadLine();
            if (cards.IndexOf(','+entered+',')==-1)
            {
                Console.WriteLine("no");
            }else
                Console.WriteLine("yes");
        }
    }
}
