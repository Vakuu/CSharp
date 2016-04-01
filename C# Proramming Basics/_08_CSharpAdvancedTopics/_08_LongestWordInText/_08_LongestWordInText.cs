using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_LongestWordInText
{
    class _08_LongestWordInText
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            int length = 0;
            string theLongestWord="";
            foreach (var word in words)
            {
                if (word == words[words.Length - 1])
                {
                    if (word[word.Length-1]=='.')
                        if (word.Length - 2 > length)
                        {
                            length = word.Length - 2;
                            theLongestWord = word;
                        }
                }
                else
                {
                    if (word.Length - 1 > length)
                    {
                        length = word.Length - 1;
                        theLongestWord = word;
                    }
                }
            }
            Console.WriteLine(theLongestWord);
        }
    }
}
