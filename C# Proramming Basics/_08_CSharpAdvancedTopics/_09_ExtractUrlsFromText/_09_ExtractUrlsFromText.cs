using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_ExtractUrlsFromText
{
    class _09_ExtractUrlsFromText
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ');
            List<string> urls = new List<string>();
            foreach (var word in words)
            {
                if (word[word.Length - 1] == '.')
                {
                    if (word.IndexOf("www.") > -1)
                    {
                        urls.Add(word.Substring(0, word.Length - 2));
                    }
                    if (word.IndexOf("http://") > -1)
                    {
                        urls.Add(word.Substring(0, word.Length - 2));
                    }
                }
                else
                {
                    if (word.IndexOf("www.") > -1)
                    {
                        urls.Add(word);
                    }
                    if (word.IndexOf("http://") > -1)
                    {
                        urls.Add(word);
                    }
                }
            }
        }
    }
}
