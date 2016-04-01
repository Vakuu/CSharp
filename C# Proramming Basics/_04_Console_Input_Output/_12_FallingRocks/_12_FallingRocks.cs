using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_FallingRocks
{
    class _12_FallingRocks
    {
        public static string getNextPage()
        {
            return "";
        }
        public static string getNewLine()
        {
            string[] symbolList = " , ,^, , ,@, , ,*, , ,&, , ,+, , ,%, , ,$, , ,#, , ,!, , ,., , ,;, , ,-, , ".Split(',');
            string[] line = new String[100];
            Random rnd = new Random();
            for (int i = 0; i < 100; i++)
            {
                int number = rnd.Next(0, symbolList.Length);
                if (i > 2)//more than 3 rocks in a row are not allowed on a single line
                {
                    if ((line[i - 1] != " ") && (line[i - 2] != " "))
                    {
                        line[i] = " ";
                    }
                    else
                    {
                        line[i] = symbolList[number];
                    }
                }
                else
                {
                    line[i] = symbolList[number];
                }
            }
            return String.Join("", line);
        }
        static void Main(string[] args)
        {
            //gameFrame();
            //while (Console.ReadKey().Key != '')
            //{
            //}
            Console.WindowHeight = 41;
            Console.WindowWidth = 100;
            //on read key getNextPage();
            Console.WriteLine(getNewLine());
        }
    }
}