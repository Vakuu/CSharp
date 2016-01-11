using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] X = new string[n];
            string[] Y = new string[n];
            string[] Z = new string[n];
            for (int i = 0; i < n; i++)
            {
                X[i] = Console.ReadLine();
            }
            string[,,] cube = new string[n, n, n];
            for (int i = 0; i < n; i++)
            {
                Y = X[i].Split('|');
                for (int j = 0; j < n; j++)
                {
                    Z = Y[j].Split(' ');
                    for (int k = 0; k < n; k++)
                    {
                        cube[i, j, k] = Y[k];
                    }
                }
            }
            Dictionary<string, int> data = new Dictionary<string, int>();
            int broq4 = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        if (((i > 0 && j > 0)||
                            (i > 0 && k > 0) ||
                            (k > 0 && j > 0))
                            &&
                            ((i < n - 1 && j < n - 1)||
                            (i < n - 1 && k < n - 1) ||
                            (k < n - 1 && j < n - 1))
                            )
                        {
                            if ((cube[i, j, k] == cube[i, j - 1, k + 1]) &&
                            (cube[i, j, k] == cube[i, j + 1, k + 1]) &&
                            (cube[i, j, k] == cube[i, j, k + 1]) &&
                            (cube[i, j, k] == cube[i, j, k + 2]) &&
                            (cube[i, j, k] == cube[i - 1, j, k + 1]) &&
                            (cube[i, j, k] == cube[i + 1, j, k + 1]))
                            {
                                broq4++;
                                if (data.ContainsKey(cube[i, j, k]))
                                {
                                    data[cube[i, j, k]] = data[cube[i, j, k]] + 1;
                                }
                                else
                                {
                                    data.Add(cube[i, j, k], 1);
                                }
                            }
                        }
                    }
                }
            }
            var l = data.OrderBy(key => key.Key);
            var dic = l.ToDictionary((keyItem) => keyItem.Key, (valueItem) => valueItem.Value);
            Console.WriteLine(broq4);
            foreach (var item in dic)
            {
                Console.WriteLine(item.Key + " -> " + item.Value);
            }
        }
    }
}
