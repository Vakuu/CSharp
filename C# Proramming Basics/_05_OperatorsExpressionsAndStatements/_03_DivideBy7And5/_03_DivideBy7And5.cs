using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_DivideBy7And5
{
    class _03_DivideBy7And5
    {
        static void Main()
        {  
            string num1str = Console.ReadLine();
            int num1 = int.Parse (num1str);
            if (num1%35>0)
            {   
                Console.WriteLine("false");
            }
            else
            {
                Console.WriteLine("true");
            }
            //if (Console.ReadLine() == " "){Main();}
        }
    }
}
