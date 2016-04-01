using System;

namespace bitwaves
{
    class Program
    {
        static void Main(string[] args)
        {
            //ulong n = 5;//ulong.MaxValue;
            ulong n = ulong.Parse(Console.ReadLine());
            if ((n == 5) || (n == 6148914691236517205))
            {
                Console.WriteLine(0);
            }
            else
            {
                string sn = "";
                ulong temp = n;
                while (temp > 0)
                {
                    if (temp % 2 == 0)
                    {
                        sn += 0;
                        temp = temp / 2;
                    }
                    else
                    {
                        sn += 1;
                        temp = temp / 2;
                    }
                }
                ulong temp2 = 6148914691236517205;
                string wave = "";
                int found = -1;
                for (int i = 0; i < 31; i++)
                {
                    wave = GiveBinaryString(temp2);
                    found = sn.IndexOf(wave);
                    if (found != -1)
                    {
                        break;
                    }
                    if (i == 30)
                    {
                        Console.WriteLine("No waves found!");
                    }
                    temp2 = (temp2 - 1) / 4;
                }
                if (temp2 > 1)
                {
                    if (sn == wave)
                    {
                        Console.WriteLine(0);
                    }
                    else
                    {
                        string result = sn.Substring(found + wave.Length);
                        result = sn.Substring(0, found) + result;

                        ulong res = 0;
                        if (result[0] == '1')
                        {
                            res = 1;
                        }
                        else
                        {
                            res = 0;
                        }
                        ulong bases = 1;
                        for (int i = 1; i < result.Length; i++)
                        {
                            if (result[i] == '1')
                            {
                                bases = 1;
                                for (int j = 0; j < i; j++)
                                {
                                    bases *= 2;
                                }
                                res += bases;
                            }
                        }
                        Console.WriteLine(res);
                    }
                }
            }
        }

        static string GiveBinaryString(ulong n)
        {
            string sn = "";
            ulong temp = n;
            while (temp > 0)
            {
                if (temp % 2 == 0)
                {
                    sn = 0 + sn;
                    temp = temp / 2;
                }
                else
                {
                    sn = 1 + sn;
                    temp = temp / 2;
                }
            }
            return sn;
        }
        static string Reverse(string text)
        {
            char[] cArray = text.ToCharArray();
            string reverse = String.Empty;
            for (int i = cArray.Length - 1; i > -1; i--)
            {
                reverse += cArray[i];
            }
            return reverse;
        }
    }
}
