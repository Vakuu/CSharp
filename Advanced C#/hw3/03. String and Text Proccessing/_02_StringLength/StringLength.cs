using System;
using System.Text;

namespace _02_StringLength
{
    class StringLength
    {
        static void Main()
        {
            string text = Console.ReadLine();

            Console.WriteLine(FillOrCut(text));
        }

        static string FillOrCut(string text)
        {
            if (text.Length < 20)
            {
                StringBuilder resText = new StringBuilder();
                resText.Append(text);
                resText.Append('*', 20 - text.Length);
                return resText.ToString();
            }

            return text.Substring(0,20);
        }
    }
}
