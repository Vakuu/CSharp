using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_
{
    class Program
    {
        static void Main(string[] args)
        {
            //string ch = "ABCEHKMPTX";
            int[] chwheghts = new int[10] { 10, 20, 30, 50, 80, 110, 130, 160, 200, 240 };
            int length = 10;
            //List<string> carNumb = new List<string>();
            List<int> weigths = new List<int>();
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    for (int k = 0; k < length; k++)
                    {
                        //carNumb.Add("CA"+i+i+i+i+ch[j]+ch[k]);//aaaa
                        weigths.Add(40+4*i+chwheghts[j]+chwheghts[k]);
                    }
                }
            }
            for (int l = 0; l < length; l++)
            {
                for (int i = 0; i < length; i++)
                {
                    for (int j = 0; j < length; j++)
                    {
                        for (int k = 0; k < length; k++)
                        {
                            if (i != l)
                            {
                                //carNumb.Add("CA" + l + i + i + i + ch[j] + ch[k]);//abbb
                                weigths.Add(40 + 3 * i + l + chwheghts[j] + chwheghts[k]);
                                //carNumb.Add("CA" + i + i + i + l + ch[j] + ch[k]);//bbba
                                weigths.Add(40 + 3 * i + l + chwheghts[j] + chwheghts[k]);
                                //carNumb.Add("CA" + l + i + l + i + ch[j] + ch[k]);//abab
                                weigths.Add(40 + 2 * i + 2 * l + chwheghts[j] + chwheghts[k]);
                                //carNumb.Add("CA" + l + l + i + i + ch[j] + ch[k]);//aabb
                                weigths.Add(40 + 2 * i + 2 * l + chwheghts[j] + chwheghts[k]);
                                //carNumb.Add("CA" + i + l + l + i + ch[j] + ch[k]);//abba
                                weigths.Add(40 + 2 * i + 2 * l + chwheghts[j] + chwheghts[k]);
                            }
                        }
                    }
                }
            }
            int weight = int.Parse(Console.ReadLine());
            int counter = 0;
            foreach (var item in weigths)
            {
                if (item==weight)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
