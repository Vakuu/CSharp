using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Quotes_in_Strings
{
    class Program
    {
        static void Main()
        {
            string var1 = "The \"use\" of quotations causes difficulties";
            string var2 = @"The ""use"" of quotations causes difficulties";
            string var3 = "The "+'"'+"use"+'"'+" of quotations causes difficulties";
            string var4 = "The {0}use{1} of quotations causes difficulties";
            char quo1 = '"';
            Console.WriteLine(var1);
            Console.WriteLine(var2);
            Console.WriteLine(var3);
            Console.WriteLine(var4, quo1, quo1);
        }
    }
}