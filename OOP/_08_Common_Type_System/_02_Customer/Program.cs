using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Customer
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer first = new Customer("Кой", "Съм", "Аз", 123456789, "address", "123456789", "email@alb.bl", CustomerType.One_time);
            Payment pokupka1 = new Payment("torta", 23.5m);
            first.AddPayment(pokupka1);
            Customer second = first.Clone() as Customer;

            Console.WriteLine(second);
            Console.WriteLine(first == second);
            Console.WriteLine(first.CompareTo(second));
        }
    }
}
