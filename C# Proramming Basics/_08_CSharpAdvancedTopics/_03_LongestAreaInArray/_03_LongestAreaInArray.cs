using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_LongestAreaInArray
{
    class _03_LongestAreaInArray
    {
        public static int getIntNumber(string msg)
        {
            Console.Write(msg);
            string first_String = Console.ReadLine();
            int first_real = 0;
            try
            {
                first_real = int.Parse(first_String);
            }
            catch (FormatException)
            {
                Console.WriteLine("'{0}' is not in a valid format.", first_String);
                first_real = getIntNumber("Enter the number again: ");
            }
            catch (OverflowException)
            {
                Console.WriteLine("{0} is outside the range of a float.", first_String);
                first_real = getIntNumber("Enter the number again: ");
            }
            return first_real;
        }
        static void Main(string[] args)
        {
            int n = getIntNumber("Enter n: ");
            string[] strings;
            strings = new string[n];
            for (int i = 0; i < n; i++)
            {
                strings[i] = Console.ReadLine();
            }
            IDictionary<string, int> dict = new Dictionary<string, int>();
            foreach (string word in strings)
            {
                if (dict.ContainsKey(word))
                {
                    dict[word] = dict[word] + 1;
                }else
                {
                    dict[word] = 1;
                }
            }
            string theWord = "";
            int theNumber=0;
            foreach (KeyValuePair<string, int> entry in dict)
            {
                if (theWord=="")
                {
                    theWord = entry.Key;
                    theNumber = entry.Value;
                }
                else
                    if (entry.Value>theNumber)
                    {
                        theWord = entry.Key;
                        theNumber = entry.Value;
                    }
            }
            Console.WriteLine(theNumber);
            for (int i = 0; i < theNumber; i++)
            {
                Console.WriteLine(theWord);
            }
        }
    }
}
