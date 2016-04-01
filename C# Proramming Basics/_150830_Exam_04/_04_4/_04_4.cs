using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Net.Mime;

class _04_4
{
    static void Main(string[] args)
    {
        string[] A = Console.ReadLine().Split(' ');


        Console.ReadLine();

        string[] C = Console.ReadLine().Split(' ');

        Console.ReadLine();

        int R = (int)(double.Parse(Console.ReadLine()) * 10);

        int step = (int)(double.Parse(Console.ReadLine()) * 10);


        int left = (int)(double.Parse(A[0]) * 10);

        int down = (int)(double.Parse(A[1]) * 10);

        int right = (int)(double.Parse(C[0]) * 10);

        int up = (int)(double.Parse(C[1]) * 10);

        if (left % step != 0){ left = (left / step) * step; }

        else { left = (left / step) * step + step; }
        if (down % step != 0) { down = (down / step) * step; }
        else { down = (down / step) * step + step; }
        int points = 0;

        for (int i = down; i < up; i += step)
        {
            for (int j = left; j < right; j += step)
            {
                if ((i * i + j * j) < R * R)
                {
                    ++points;
                }
            }
        }
        Console.WriteLine(points);
        if ((1==1)&&(2==2))
        {
            act1;
        }
        else
        {
            if ()
            act2;
            else
            {
                if ()
                act2;
                else
                {
                
                }
            }
        }
        string[] texts1=new string[]{};

        List<string> texts2=new List<string>();

        texts2.Add("5");
        texts2.Remove("5");
        texts2.RemoveAt(5);
        texts2.Sort();


    }
}