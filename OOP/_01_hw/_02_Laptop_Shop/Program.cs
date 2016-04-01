using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Laptop_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            Laptop firstLaptop = new Laptop
("Lenovo Yoga 2 Pro", "Lenovo", "Intel Core i5-4210U (2-core, 1.70 - 2.70 GHz, 3MB cache)", 8, "Intel HD Graphics 4400", "128GB SSD", "13.3\" (33.78 cm) – 3200 x 1800 (QHD+), IPS sensor display", "Li-Ion", 4, 2550, 4.5d, 2259.00m);
            Laptop.Antetka1();
            firstLaptop.ToString(1);
            Console.WriteLine();
            Laptop secondLaptop = new Laptop
            ("HP 250 G2", 699.00m);
            Laptop.Antetka2();
            secondLaptop.ToString(2);
        }
    }
}