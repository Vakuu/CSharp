using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_PC_Catalog
{
    class Program
    {
        static void Main(string[] args)
        {
            Component firstCPU = new Component("processor", "Intel Core i5-4210U (2-core, 1.70 - 2.70 GHz, 3MB cache)", 200.00m);
            Component firstGPU = new Component("graphics card", 100.00m);
            Computer firstPC = new Computer("HP 250 G2", firstCPU, firstGPU, firstCPU.Price + firstGPU.Price);

            Component secondCPU = new Component("processor", "AMD something", 150.00m);
            Computer secondPC = new Computer("Not HP", secondCPU, secondCPU.Price);

            Computer thirdPC = new Computer("ASUS?!?!", 0.00m);
            Computer[] computers = new Computer[] { firstPC, secondPC, thirdPC };
            foreach (Computer computer in computers)
            {
                computer.ToString();
                Console.WriteLine();
            }
        }
    }
}
