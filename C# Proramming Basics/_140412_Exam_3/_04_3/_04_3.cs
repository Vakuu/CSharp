using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _04_3
{
    class _04_3
    {
        static void Main(string[] args)
        {
            string fy = Console.ReadLine();
            string sy = Console.ReadLine();
            int weight = int.Parse(Console.ReadLine());
            string first_date = "01-01-" + fy;
            string final_date = "31-12-" + sy;
            DateTime start = DateTime.ParseExact(first_date, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime fin = DateTime.ParseExact(final_date, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime neww = start;
            string ch;
            int sum;
            int count = 0;
            while (neww <= fin)
            {
                sum = 0;
                ch = neww.ToString().Substring(0, 10);
                for (int i = 0; i < ch.Length; i++)
                {
                    if ((i != 2) && (i != 5))
                    {
                        for (int j = i + 1; j < ch.Length; j++)
                        {
                            if ((j != 2) && (j != 5))
                            {
                                sum += int.Parse(ch[i].ToString()) * int.Parse(ch[j].ToString());
                            }
                        }
                    }
                }
                if (sum == weight)
                {
                    count++;
                    Console.WriteLine(neww.ToString().Substring(0, 2) + "-" + neww.ToString().Substring(3, 2) + "-" + neww.ToString().Substring(6, 4));
                }
                neww = neww.AddDays(1);
            }
            if (count == 0)
            {
                Console.WriteLine("No");
            }
        }
    }
}