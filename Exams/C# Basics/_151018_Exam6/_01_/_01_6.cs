using System;

namespace _01_
{
    class _01_6
    {
        static void Main()
        {
            int EuN = int.Parse(Console.ReadLine());
            decimal EuP = decimal.Parse(Console.ReadLine());
            int NAN = int.Parse(Console.ReadLine());
            decimal NAP = decimal.Parse(Console.ReadLine());
            int SAN = int.Parse(Console.ReadLine());
            decimal SAP = decimal.Parse(Console.ReadLine());
            int conc = int.Parse(Console.ReadLine());
            decimal concP = decimal.Parse(Console.ReadLine());
            decimal WEuP = EuN * EuP * 1.94M;
            decimal WNAP = NAN * NAP * 1.72M;
            decimal WSAP = (SAN * SAP) / 332.74M;
            decimal AProf = WEuP + WNAP + WSAP;
            decimal Aprof35 = (AProf - (AProf * 35M / 100M));
            decimal Aprof3520 = (Aprof35 - Aprof35 / 5M);
            decimal WconcP = conc * concP * 1.94M;
            decimal WconcP15 = 0M;
            if (WconcP > 100000M)
            {
                WconcP15 = (WconcP - (WconcP * 15M / 100M));
            }
            else
            {
                WconcP15 = WconcP;
            }
            if (Aprof3520>WconcP15)
            {
                Console.WriteLine("Let's record some songs! They'll bring us {0:F2}lv.", (double)Aprof3520);
            }
            else
            {
                Console.WriteLine("On the road again! We'll see the world and earn {0:F2}lv.", (double)WconcP15);
            }
        }
    }
}
