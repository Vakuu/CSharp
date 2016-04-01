using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_4
{
    class _03_4
    {
        static void Main(string[] args)
        {
            int w = int.Parse(Console.ReadLine());
            int h = w+w/2;
            string line = "#..";
            int counter=0;
            for (int i = 0; i < h; )
            {
                for (int j = 0; j < w; j++)
                {
                    if (counter==3)
                    {
                        counter = 0;
                    }
                    Console.Write(line.Substring(counter,1));
                    counter++;
                }
                Console.WriteLine();
                i++;
                counter = i;
                while (counter>2)
                {
                    counter -= 3;
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.TeleportPoints
{
    class TeleportPoints
    {
        static void Main(string[] args)
        {
            string[] pointA = Console.ReadLine().Split(' ').ToArray();
            Console.ReadLine();
            string[] pointC = Console.ReadLine().Split(' ').ToArray();
            Console.ReadLine();

            double radius = double.Parse(Console.ReadLine());
            double step = double.Parse(Console.ReadLine());

            double aX = double.Parse(pointA[0]);
            double aY = double.Parse(pointA[1]);
            double cX = double.Parse(pointC[0]);
            double cY = double.Parse(pointC[1]);

            int pointCounter = 0;

            //Check the right side
            for (double x = 0; x <= radius; x += step)
            {
                //Upper quadrant
                for (double y = 0; y <= radius; y += step)
                {
                    if ((x*x + y*y) <= radius*radius)
                    {
                        if ((x > aX && x < cX) && (y < cY && y > aY))
                        {
                            pointCounter++;
                        }
                    }
                }

                //Lower quadrant
                for (double y = -step; y >= -radius; y -= step)
                {
                    if ((x * x + y * y) <= radius * radius)
                    {
                        if ((x > aX && x < cX) && (y < cY && y > aY))
                        {
                            pointCounter++;
                        }
                    }
                }

            }

            //Check the left side
            for (double x = -step; x >= -radius; x -= step)
            {
                //Upper quadrant
                for (double y = 0; y <= radius; y += step)
                {
                    if ((x * x + y * y) <= radius * radius)
                    {
                        if ((x > aX && x < cX) && (y < cY && y > aY))
                        {
                            pointCounter++;
                        }
                    }
                }

                //Lower quadrant
                for (double y = -step; y >= -radius; y -= step)
                {
                    if ((x*x + y*y) <= radius*radius)
                    {
                        if ((x > aX && x < cX) && (y < cY && y > aY))
                        {
                            pointCounter++;
                        }
                    }
                }
            }

            Console.WriteLine(pointCounter);
        }
    }
}

