using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<List<int>> numbers = new List<List<int>>();
            List<int> job = new List<int>();
            for (int i = 0; i < n; i++)
            {
                int[] work = Array.ConvertAll(Console.ReadLine().Split(' '), c => int.Parse(c));
                job = new List<int>();
                for (int j = 0; j < work.Length; j++)
                {
                    job.Add(work[j]);
                }
                //job.Sort();
                job = job.OrderByDescending(x => x).ToList();
                numbers.Add(job);
            }
            int s = 0;
            foreach (var item in numbers)
            {
                s = item.Sum();
                if (s % 3 != 0)
                {
                    Console.WriteLine("No");
                }
                else
                {
                    if (item[0] > s / 3)
                    {
                        Console.WriteLine("No");
                    }
                    else
                    {
                        item.Insert(0,s/3);
                        List<int> left = new List<int>();
                        List<int> right = new List<int>();
                        int i, j;
                        left.Add(0);
                        right.Add(0);
                        for (i = 0, j = item.Count - 1; i <= j;)
                        {
                            if (left.Sum() <= right.Sum())
                            {
                                left.Add(item[i]);
                                i++;
                            }
                            else
                            {
                                right.Add(item[j]);
                                j--;
                            }
                        }
                        if (left.Sum() == right.Sum())
                        {
                            //left.RemoveAt(0);
                            List<int> leftR = new List<int>();
                            List<int> rightR = new List<int>();
                            leftR.Add(0);
                            rightR.Add(0);
                            for (i = 0, j = right.Count - 1; i <= j;)
                            {
                                if (leftR.Sum() <= rightR.Sum())
                                {
                                    leftR.Add(right[i]);
                                    i++;
                                }
                                else
                                {
                                    rightR.Add(right[j]);
                                    j--;
                                }
                            }
                            if (leftR.Sum() == rightR.Sum())
                            {
                                Console.WriteLine("Yes");
                            }
                            else
                            {
                                Console.WriteLine("No");
                            }
                        }
                        else
                        {
                            Console.WriteLine("No");
                        }
                        //if (recurse(item, s / 3, s / 3, 3, 0))
                        //{
                        //    Console.WriteLine("Yes");
                        //}
                        //else
                        //{
                        //    Console.WriteLine("No");
                        //}
                    }
                }
            }
        }

        //static bool canBalance(List<int> nums)
        //{
        //    int leftSum = 0, rightSum = 0, i, j;
        //    if (nums.Count == 1)
        //        return false;
        //    for (i = 0, j = nums.Count - 1; i <= j;)
        //    {
        //        if (leftSum <= rightSum)
        //        {
        //            leftSum += nums[i];
        //            i++;
        //        }
        //        else {
        //            rightSum += nums[j];
        //            j--;
        //        }
        //    }
        //    return (rightSum == leftSum);
        //}


        //static bool recurse(List<int> items, int orig_sum, int temp_sum, int br, int minOrMax)
        //{
        //    if (items[0] == temp_sum)
        //    {
        //        if ((br == 1)&&(items.Count==1))
        //        {
        //            return true;
        //        }
        //        else
        //        {
        //            items.RemoveAt(0);
        //            if (items.Any())
        //            {
        //                if (minOrMax==1)
        //                {
        //                    items=items.OrderByDescending(x => x).ToList();
        //                }
        //                return recurse(items, orig_sum, orig_sum, br - 1, 0);
        //            }
        //            else
        //            {
        //                return false;
        //            }
        //        }
        //    }
        //    else
        //    {
        //        if (items[0] < temp_sum)
        //        {
        //            int valueForRemove = items[0];
        //            items.RemoveAt(0);
        //            if (minOrMax==0)
        //            {
        //                items.Sort();
        //                return recurse(items, orig_sum, temp_sum - valueForRemove, br, 1);
        //            }
        //            else
        //            {
        //                return recurse(items, orig_sum, temp_sum - valueForRemove, br, 1);
        //            }
        //        }
        //        else
        //        {
        //            return false;
        //        }
        //    }
        //}
    }
}
