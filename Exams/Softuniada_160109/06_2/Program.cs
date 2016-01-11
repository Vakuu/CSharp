using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<List<int>> arrays = new List<List<int>>();
        List<int> job = new List<int>();
        for (int i = 0; i < n; i++)
        {
            int[] work = Array.ConvertAll(Console.ReadLine().Split(' '), c => int.Parse(c));
            job = new List<int>();
            for (int j = 0; j < work.Length; j++)
            {
                job.Add(work[j]);
            }
            arrays.Add(job);
        }
        int s = 0;
        foreach (var array in arrays)
        {
            s = array.Sum();
            if (s % 3 != 0)
            {
                Console.WriteLine("No");
            }
            else
            {
                Subsequences(array, 3).Where(ss => ss.Sum(item => item) == (s / 3));
            }
            //string yes = "No";
            //IEnumerable<IEnumerable<int>> partitions = Partition(array, 3);
            //if (partitions.Any())
            //{
            //    foreach (var item in partitions)
            //    {
            //        List<int> bitch = array;
            //        foreach (var subitem in item)
            //        {
            //            bitch.Remove(subitem);
            //        }
            //        IEnumerable<IEnumerable<int>> partitions2 = Partition(bitch, 2);
            //        if (partitions2.Any())
            //        {
            //            yes = "Yes";
            //            break;
            //        }
            //    }
            //}
            //Console.WriteLine(yes);
        }
    }

    //static IEnumerable<IEnumerable<int>> Partition(List<int> array, int parts)
    //{
    //    var sum = array.Sum();
    //    if ((sum % parts) != 0) return Enumerable.Empty<IEnumerable<int>>();

    //    return Subsequences(array, parts).Where(ss => ss.Sum(item => item) == (sum / parts));
    //}
    private static IEnumerable<IEnumerable<T>> Subsequences<T>(IEnumerable<T> source, int parts)
    {
        if (source.Any())
        {
            foreach (var comb in Subsequences(source.Skip(1), parts))
            {
                yield return comb;
                if (parts==3)
                {
                    List<int> bitch = (List<int>)source;
                    foreach (var subitem in comb)
                    {
                        bitch.Remove(int.Parse(subitem.ToString()));
                    }
                    int s = bitch.Sum();
                    if (s % 2 != 0)
                    {
                        Console.WriteLine("No");
                        yield return Enumerable.Empty<T>();
                    }
                    else
                    {
                        if ((Subsequences(bitch, 2).Where(ss => ss.Sum(item => item) == (s / 2))).Any())
                        {
                            Console.WriteLine("Yes");
                            yield break;
                        }
                        else
                        {
                            Console.WriteLine("No");
                            yield return Enumerable.Empty<T>();
                        }
                    }
                }
                yield return source.Take(1).Concat(comb);
            }
        }
        else
        {
            yield return Enumerable.Empty<T>();
        }
    }
}

