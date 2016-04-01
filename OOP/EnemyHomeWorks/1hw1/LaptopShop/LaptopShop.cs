using System;
using System.Linq;

namespace LaptopShop
{
    class LaptopShop
    {
        static void Main()
        {
            Laptop laptop = new Laptop("Y50", 2000);
            Console.WriteLine(laptop);

            Laptop laptopFull = new Laptop("Y50", "Lenovo", "Intel i7", 16, "Nvidia GTX 860m", "1 TB", "15.6\" UHD", new Battery("Different models", 15), 2000);
            Console.WriteLine(laptopFull);
        }
    }
}
