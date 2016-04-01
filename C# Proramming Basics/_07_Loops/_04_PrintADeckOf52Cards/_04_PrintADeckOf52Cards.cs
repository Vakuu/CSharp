using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_PrintADeckOf52Cards
{
    class _04_PrintADeckOf52Cards
    {
        static void Main(string[] args)
        {
            string[] cards = "2,3,4,5,6,7,8,9,10,J,Q,K,A".Split(',');
            string[] colors = "♣,♦,♥,♠".Split(',');
            for (int i = 0; i < cards.Length; i++)
			{
                for (int j = 0; j < colors.Length; j++)
			    {
                    switch (colors[j])
                    {
                        case "♠":
                            Console.Write(cards[i] + colors[j]);
                            break;
                        default:
                            Console.Write(cards[i] + colors[j] + " ");
                            break;
                    }
			    }
			    Console.WriteLine();
			}
            //better:
            //foreach (string card in cards)
            //{
            //    foreach (string color in colors)
            //    {
            //        switch(color)
            //        {
            //            case "♠":
            //                Console.Write(card + color);
            //                break;
            //            default:
            //                Console.Write(card + color + " ");
            //                break;
            //        }
            //    }
            //    Console.WriteLine();
            //}
        }
    }
}
