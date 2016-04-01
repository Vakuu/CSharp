using System;
using System.Text;

namespace _01_ReverseString
{
    class ReverseString
    {
        static void Main()
        {
            string text = Console.ReadLine();

            Console.WriteLine(ReverseText(text));
        }

        static string ReverseText(string text)
        {
            StringBuilder reversedText = new StringBuilder();

            for (int i = text.Length - 1; i >= 0; i--)
            {
                reversedText.Append(text[i]);
            }

            return reversedText.ToString();
        }
    }
}
