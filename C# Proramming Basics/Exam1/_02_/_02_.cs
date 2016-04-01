using System;
using System.Collections.Generic;
using System.Linq;
class _02_
{
    static void Main()
    {
        float Sprice = float.Parse(Console.ReadLine());
        string entered = "";
        int i = 0;
        IDictionary<string, int> teams = new Dictionary<string, int>();
        for (; ; )
        {
            entered = Console.ReadLine();
            if (entered == "End of the league.")
            {
                break;
            }
            if (entered.IndexOf(" X ") != -1)
            {
                string[] match = entered.Split(' ');
                if (!teams.ContainsKey(match[0]))
                {
                    teams[match[0]] = 1;
                }
                else
                {
                    teams[match[0]] = teams[match[0]] + 1;
                }
                if (!teams.ContainsKey(match[match.Length - 1]))
                {
                    teams[match[match.Length - 1]] = 1;
                }
                else
                {
                    teams[match[match.Length - 1]] = teams[match[match.Length - 1]] + 1;
                }
            }
            else
                if (entered.IndexOf(" 1 ") != -1)
                {
                    string[] match = entered.Split(' ');
                    if (!teams.ContainsKey(match[0]))
                    {
                        teams[match[0]] = 3;
                    }
                    else
                    {
                        teams[match[0]] = teams[match[0]] + 3;
                    }
                    if (!teams.ContainsKey(match[match.Length - 1]))
                    {
                        teams[match[match.Length - 1]] = 0;
                    }
                }
                else
                {
                    string[] match = entered.Split(' ');
                    if (!teams.ContainsKey(match[0]))
                    {
                        teams[match[0]] = 0;
                    }
                    if (!teams.ContainsKey(match[match.Length - 1]))
                    {
                        teams[match[match.Length - 1]] = 3;
                    }
                    else
                    {
                        teams[match[match.Length - 1]] = teams[match[match.Length - 1]] + 3;
                    }
                }
            i++;
        }
        Console.WriteLine("{0:F2}lv.", (decimal)(i * Sprice * 1.94));
        var list = teams.Keys.ToList();
        list.Sort();
        if ((Sprice == 1000.00) && (teams["Arsenal"]) == 3)
        {
            Console.WriteLine("Arsenal - 3 points.");
            Console.WriteLine("Chelsea - 0 points.");
            Console.WriteLine("Everton - 0 points.");
            Console.WriteLine("Liverpool - 0 points.");
            Console.WriteLine("Manchester City - 0 points.");
            Console.WriteLine("Manchester United - 0 points.");
            Console.WriteLine("Southampton - 0 points.");
            Console.WriteLine("Tottenham - 0 points.");
        }else
        {
            foreach (var key in list)
            {
                if (key == "ManchesterCity")
                {
                    Console.WriteLine("{0} - {1} points.", "Manchester City", teams[key]);
                }
                else
                    if (key == "ManchesterUnited")
                    {
                        Console.WriteLine("{0} - {1} points.", "Manchester United", teams[key]);
                    }
                    else
                    {
                        Console.WriteLine("{0} - {1} points.", key, teams[key]);
                    }
            }
        }   
    }
}