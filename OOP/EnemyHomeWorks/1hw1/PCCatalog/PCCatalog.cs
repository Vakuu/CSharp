using System;
using System.Collections.Generic;
using System.Linq;

namespace PCCatalog
{
    class PCCatalog
    {
        static void Main(string[] args)
        {
            Component ram1 = new Component("8GB RAM", 116);
            Component ram2 = new Component("4GB RAM", 72);

            Component hdd1 = new Component("500GB HHD", 78);
            Component hdd2 = new Component("1TB HDD", 131);
            Component hdd3 = new Component("1TB SSD", 370);

            Component gpu1 = new Component("None", 0);
            Component gpu2 = new Component("ATI 5890", 255);
            Component gpu3 = new Component("NVidia GTX Titan", 598);

            Component cpu1 = new Component("Intel Core i3 2.4 GHz", 78);
            Component cpu2 = new Component("Intel Core i5 3.2 GHz", 131);
            Component cpu3 = new Component("Intel Core i7 4.0 GHz", 515);

            Computer PC1 = new Computer("PC1", new List<Component>() { ram1, hdd1, gpu1, cpu1 });
            Computer PC2 = new Computer("PC2", new List<Component>() { ram2, hdd2, gpu2, cpu2 });
            Computer PC3 = new Computer("PC4", new List<Component>() { ram1, hdd3, gpu3, cpu3 });
            Computer PC4 = new Computer("UnknownTrash");

            List<Computer> computers = new List<Computer>() { PC1, PC2, PC3, PC4 };
            computers = computers.OrderBy(pr => pr.Price).ToList();
            foreach (var computer in computers)
            {
                Console.WriteLine(computer);
            }
        }
    }
}
