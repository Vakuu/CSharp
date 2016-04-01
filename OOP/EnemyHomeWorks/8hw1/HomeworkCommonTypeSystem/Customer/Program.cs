using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer
{
    class Program
    {
        static void Main()
        {
            var pesho = new Customer("Petar", "Petrov", "Petrov", 123456789);
            var ivan = new Customer("Ivan", "Ivanov", "Ivanov", 123456789);

            Payment[] payments =
            {
                new Payment("book", 25.5m),
                new Payment("phone", 250.89m)
            };

            foreach (var payment in payments)
            {
                pesho.AddPayment(payment);
                ivan.AddPayment(payment);
            }

            var petarCloning = (Customer)pesho.Clone();

            Console.WriteLine(pesho == ivan);
            Console.WriteLine(pesho == pesho);
            Console.WriteLine(pesho == petarCloning);

            Console.WriteLine(pesho.CompareTo(ivan));
            Console.WriteLine(pesho.CompareTo(petarCloning));

            Customer cloning = (Customer)pesho.Clone();

            pesho.Payments[0].Price = 200;
            cloning.Payments[0].Price = 100000;

            Console.WriteLine("Pesho cloning:\n{0}", cloning.Payments[0].Price);
            Console.WriteLine("Pesho:\n{0}", pesho.Payments[0].Price);
        }
    }
}
