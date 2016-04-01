using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_6
{
    class _05_6
    {
        static void Main(string[] args)
        {
            string word = "";
            int counter = 2;
            long floor = 0;
            long score = 0;
            long tempAp = -1;
            long tempap2=1;
            int ons = 0;
            while (word != "Stop, God damn it")
            {
                word = Console.ReadLine();
                if (word != "Stop, God damn it")
                {
                    if (counter % 2 == 0)
                    {
                        floor = uint.Parse(word);
                    }
                    else
                    {
                        string[] aparts = word.Split(' ');
                        for (int i = 0; i < aparts.Length; i++)
                        {
                            tempAp = int.Parse(aparts[i]);
                            tempap2 = 1;
                            for (int j = 0; j < tempAp; j++)
                            {
                                tempap2 = tempap2 * 2;
                            }
                            floor = floor ^ tempap2;
                        }
                        score += floor;
                        while (floor != 0)
                        {
                            if((floor & 1) == 1)
                            {
                                ons++;
                            }
                            floor >>= 1;
                        }
                    }
                    counter++;
                }
            }
            Console.WriteLine("Bohemcho left {0} lights on and his score is {1}", ons,score);
        }
    }
}
