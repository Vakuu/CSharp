using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_JoinLists
{
    class _07_JoinLists
    {
        static void Main(string[] args)
        {
            string entries1 = Console.ReadLine();
            string entries2 = Console.ReadLine();
            string resent = entries1 + " " + entries2;
            string[] snumbs = resent.Split(' ');
            List<int> numbers = new List<int>();
            foreach (var numb in snumbs)
            {
                if (!numbers.Contains(int.Parse(numb)))
                {
                    numbers.Add(int.Parse(numb));
                }
            }
            numbers.Sort();
            foreach (var numb in numbers)
            {
                if (numbers[0] == numb)
                {
                    Console.Write(numb);
                }
                else
                {
                    Console.Write(" " + numb);
                }
            }
            //с масив със собствена сортировка
            //int[] distsnumb = new int[snumbs.Length];
            //int k = 1;
            //string testk = "";
            //for (int i = 0; i < snumbs.Length; i++)
            //{
            //    if (i == 0)
            //    {
            //        distsnumb[0] = int.Parse(snumbs[i]);
            //    }
            //    else
            //    {
            //        for (int j = k - 1; j >= 0; j--)
            //        {
            //            if (distsnumb[j] < int.Parse(snumbs[i]))
            //            {
            //                distsnumb[j + 1] = int.Parse(snumbs[i]);
            //                if (testk != snumbs[i])
            //                {
            //                    k++;
            //                    testk = snumbs[i];
            //                }
            //                break;
            //            }
            //            else
            //            {
            //                if (Array.IndexOf(distsnumb, int.Parse(snumbs[i])) == -1)
            //                {
            //                    distsnumb[j + 1] = distsnumb[j];
            //                    if (j == 0)
            //                    {
            //                        distsnumb[j] = int.Parse(snumbs[i]);
            //                    }
            //                    if (testk != snumbs[i])
            //                    {
            //                        k++;
            //                        testk = snumbs[i];
            //                    }
            //                }
            //                else
            //                {
            //                    break;
            //                }
            //            }
            //        }
            //    }
            //}
            //for (int i = 0; i < distsnumb.Length; i++)
            //{
            //    if (i == 0)
            //    {
            //        Console.Write(distsnumb[i]);
            //    }
            //    else
            //    {
            //        Console.Write(" " + distsnumb[i]);
            //    }
            //}
            //Console.WriteLine("");
        }
    }
}
