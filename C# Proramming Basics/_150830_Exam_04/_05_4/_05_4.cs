using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_4
{
    class _05_4
    {
        static void Main(string[] args)
        {
            ulong numb = 0;
            ulong tempnumb = 0;
            string tempinverter = "";
            int tempbitcounter = 0;
            int bitcounter = 0;
            ulong sum = 0;
            string word = "";
            while (word != "end")
            {
                word = Console.ReadLine();
                if (word != "end")
                {
                    tempbitcounter = 0;
                    tempinverter = "";
                    tempnumb = numb = (ulong)Convert.ToInt64(word);
                    while (tempnumb != 0)
                    {
                        if (((tempnumb & 1) == 1 ? '1' : '0') == '1')
                        {
                            tempbitcounter++;
                        }
                        tempnumb >>= 1;
                    }
                    if (tempbitcounter % 2 == 0)
                    {
                        for (int j = 0; j < tempbitcounter; j++)
                        {
                            tempinverter += "1";
                        }
                        numb ^= (ulong)Convert.ToInt64(tempinverter, 2);
                        sum += numb;
                        while (numb != 0)
                        {
                            if (((numb & 1) == 1 ? '1' : '0') == '1')
                            {
                                bitcounter++;
                            }
                            numb >>= 1;
                        }
                    }
                    else
                    {
                        numb = numb * 2;
                        sum += numb;
                        bitcounter += tempbitcounter;
                    }
                }
            }
            Console.WriteLine(sum);
            Console.WriteLine(bitcounter);
        }
    }
}
