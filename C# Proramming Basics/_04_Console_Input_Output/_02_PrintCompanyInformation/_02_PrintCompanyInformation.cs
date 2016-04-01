using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_PrintCompanyInformation
{
    class _02_PrintCompanyInformation
    {
        static void Main(string[] args)
        {
            IDictionary<string, string> dict = new Dictionary<string, string>();
            IDictionary<string, string> dict2 = new Dictionary<string, string>();
            //Hashtable dict = new Hashtable();
            dict["Company name:"] = "";
            dict["Company address:"] = "";
            dict["Phone number:"] = "";
            dict["Fax number:"] = "";
            dict["Web site:"] = "";
            dict["Manager first name:"] = "";
            dict["Manager last name:"] = "";
            dict["Manager age:"] = "";
            dict["Manager phone:"] = "";
            //string showData="{0}\nAdress: {1}\nTel. {2}\nWeb site: {3}\nManager: {4} {5} (age: {6}, tel. {7})";
            //string showPlus="@";
            foreach (KeyValuePair<string, string> entry in dict)
            {
                Console.Write("Enter {0,-20} ", entry.Key);
                dict2[entry.Key]=Console.ReadLine();
                if (dict2[entry.Key]=="")
                {
                    dict2[entry.Key] = "(no " + entry.Key + ")";
                }
                //showPlus = showPlus + ", dict[\"" + entry.Key + "\"]";
                //showData = showData + @", " + dict[entry.Key];
                //Console.Write(showData, entry.Key);
            }
            Console.WriteLine("{0}\nAdress: {1}\nTel. {2}\nfax: {3}\nWeb site: {4}\nManager: {5} {6} (age: {7}, tel. {8}"
                , dict2["Company name:"]
                , dict2["Company address:"]
                , dict2["Phone number:"]
                , dict2["Fax number:"]
                , dict2["Web site:"]
                , dict2["Manager first name:"]
                , dict2["Manager last name:"]
                , dict2["Manager age:"]
                , dict2["Manager phone:"]);
            //Console.WriteLine(showData+showPlus);
        }
    }
}
