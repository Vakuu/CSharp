using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_5
{
    class _04_5
    {
        static void Main(string[] args)
        {
            string msg = "E..v..e..r..y.. ..t..h..i..r..d.. ..o..n..e....";// Console.ReadLine();
            int code_number = 0;
            string buffer;
            int step=0;
            for (int i = 0; i < msg.Length; i++)
            {
                code_number += msg[i];
            }
            while (code_number > 9)
            {
                buffer = code_number.ToString();
                code_number = 0;
                for (int i = 0; i < buffer.Length; i++)
                {
                    code_number += int.Parse(buffer[i].ToString());
                }
            }
            if (code_number < 4) { step = 2; }
            else
                if (code_number < 7) { step = 3; }
                else
                    if (code_number < 10) { step = 4; }
            for (int i = 0; i < msg.Length; i+=step)
            {
                Console.Write(msg[i]);
            }
            Console.WriteLine();
        }
    }
}
