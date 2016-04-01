using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_anal
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "jadg";
            string b = "jadjgadg";
            //bool success = false;
            ////string c = "hjghgafsfsgsasgd";
            //int i = 0;
            //int j = 0;
            //for (;;)
            //{
            //   if ((i==a.Length)&&(j==b.Length))
            //   {
            //       break;
            //   }
            //   else
            //   {
            //       if (a[i]==b[j])
            //       {
            //           if (i == a.Length-1)
            //           {
            //               //sydyrja sy6tata duma nerazbyrkana
            //               success = true;
            //               break;
            //           }
            //           i++;
            //           j++;
            //       }
            //       else
            //       {
            //           j++;
            //       }
            //   }
            //}
            //if (success)
            //{
            //    Console.WriteLine("ne e anag a e sy6toto");
            //}
            int previ = 0;
            int i = 0;
            bool yes = false;
            for (int k = 0; k < a.Length; k++)
            {
                previ = i;
                i = b.IndexOf(a[k], i) + 1;
                if (i == 0)
                {
                    if (previ == 0)
                    {//previ e 0 na pyrvi simvol a 6tom pyrvi simvol go nqma, zna4i nqma nito duma nito anagrama
                        break;
                    }
                    else
                    {
                        if ((b.IndexOf(a[k], 0, previ - 1) != -1) && (i > 0))
                        {//ako nqkoq bukva q nqma napred no q ima nazad, nqma zna4enieve i-to //ve4e, i za da prodylji for-a trqbva da se podade validno i ot stringa a ne 0
                            yes = true;
                            i = previ;
                        }
                        else
                        {//ако я няма напред нито назад дадена буква излиза с false.
                            yes = false;
                            break;
                        }
                    }
                }
                else
                {
                    if ((b.IndexOf(a[k], 0, previ - 1) != -1)&&(i>0))
                    {//ako samo edna bukva q ima osven napred I nazad, zna4i ima i anagrama
                        yes = true;
                    }
                    else
                    {//ako nito edna bukva q nqma i nazad a gi ima vsi`kite do kraq no samo napred zna4i sme namerili dumata no do kydeto ni e stignalo i ot niza v koito tyrsim, natatyka sledva da se proveri dali ima nqkoq ot predhodnite bukvi
                        if ((k==a.Length-1)&&(!yes)&&(i<b.Length-1))
                        {//ako sme stignali poslednata pukva ot dumata, i ako sme oceleli do tuka, i "yes" e vse o6te false, i ako ne sme stignali kraq na vtoriq string, tova zna4i 4e dumata q ima cqlata no posledovatelno, no ako nqkyde napred ima nqkoq ot predhodnite bukvi na dumata, zna4i ima anagrama
                            char[] anyOf = a.ToCharArray(0, a.Length-2);
                            if (b.IndexOfAny(anyOf, i) != -1)
                            {
                                yes = true;
                            }
                        }
                    }
                }
            }
            if (yes)
            {
                Console.WriteLine("ima anagrama");
            }
            else
            {
                Console.WriteLine("nqma anagrama");
            }
        }
    }
}
