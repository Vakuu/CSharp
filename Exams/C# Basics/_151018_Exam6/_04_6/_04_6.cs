using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_6
{
    class _04_6
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int Ntemp = N;
            int K=0;
            int Ktemp = 0;
            int A=0;
            int Atemp = 0;
            int S=0;
            int Stemp = 0;
            string word="";
            while (word != "rain")
            {
                Ntemp = N;
                Ktemp = 0;
                Atemp = 0;
                Stemp = 0;
                word = Console.ReadLine();
                if (word!="rain")
                {
                    for (int i = 0; i < word.Length; i++)
                    {
                        if (word[i] == 'K')
                        {
                            Ktemp++;
                        }
                        if (word[i] == 'A')
                        {
                            Atemp++;
                        }
                        if (word[i] == 'S')
                        {
                            Stemp++;
                        }
                    }
                    if (Ntemp>=Ktemp)
                    {
                        K += Ktemp;
                        Ntemp -= Ktemp;
                        if (Ntemp>=Atemp)
                        {
                            A += Atemp;
                            Ntemp -= Atemp;
                            if (Ntemp>=Stemp)
                            {
                                S += Stemp;
                                Ntemp -= Stemp;
                            }
                            else
                            {
                                S+=Ntemp;
                            }
                        }
                        else
                        {
                            A += Ntemp;
                        }
                    }
                    else
                    {
                        K += Ntemp;
                    }
                }
            }
            Console.WriteLine("Kids: "+K);
            Console.WriteLine("Adults: " + A);
            Console.WriteLine("Seniors: " + S);
        }
    }
}
