using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_
{
    class _04_
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;
            int d;
            int e;
            int[] charwheghts = new int[5] {5, -12, 47, 7, -32};
            string word;
            List<string> words= new List<string>();
            List<int> weigths = new List<int>();
            int count;
            for (int i = 97; i < 102; i++)
            {
                for (int j = 97; j < 102; j++)
                {
                    for (int k = 97; k < 102; k++)
                    {
                        for (int l = 97; l < 102; l++)
                        {
                            for (int m = 97; m < 102; m++)
                            {
                                count = 0;

                                a = charwheghts[i - 97];
                                count++;

                                if (j == i)
                                {
                                    b = 0;
                                }
                                else
                                {
                                    count++;
                                    b = count * charwheghts[j - 97];
                                }

                                if ((k == j) || (k == i))
                                {
                                    c = 0;
                                }
                                else
                                {
                                    count++;
                                    c = count * charwheghts[k - 97];
                                }

                                if ((l == k) || (l == j) || (l == i))
                                {
                                    d = 0;
                                }
                                else
                                {
                                    count++;
                                    d = count * charwheghts[l - 97];
                                }

                                if ((m == l) || (m == k) || (m == j) || (m == i))
                                {
                                    e = 0;
                                }
                                else
                                {
                                    count++;
                                    e = count * charwheghts[m - 97];
                                }
                                weigths.Add(a + b + c + d + e);

                                word = ((char)i).ToString() + ((char)j).ToString() + ((char)k).ToString() + ((char)l).ToString() + ((char)m).ToString();
                                words.Add(word);
                            }
                        }
                    }
                }
            }
            int start=int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            count = 0;
            for (int i = 0; i < weigths.Count(); i++)
            {
                if ((weigths[i]>=start)&&(weigths[i]<=end))
                {
                    if (count == 0)
                    {
                        Console.Write(words[i]);
                        count++;
                    }
                    else
                    {
                        Console.Write(" "+words[i]);
                    }
                }
            }
            if (count == 0)
            {
                Console.Write("No");
            }
            Console.WriteLine("");
        }
    }
}
