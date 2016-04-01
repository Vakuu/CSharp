using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_PC_Catalog
{
    class Computer
    {
        //fields
        private string name;
        private Component component1;
        private bool hasComponent1=false;
        private Component component2;
        private bool hasComponent2=false;
        private decimal price;
        //ctors
        public Computer(string name, Component component1, Component component2, decimal price)
        {
            this.Name         = name;
            this.component1 = component1;
            this.hasComponent1 = true;
            this.component2 = component2;
            this.hasComponent2 = true;
            this.Price         = price;
        }
        public Computer(string name, Component component1, decimal price)
        {
            this.Name = name;
            this.component1 = component1;
            this.hasComponent1 = true;
            this.Price = price;
        }
        public Computer(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }
        //props
        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Invalid PC name!");
                this.name = value;
            }
        }
        public bool HasComponent1 { get { return hasComponent1; } }
        public bool HasComponent2 { get { return hasComponent2; } }
        public decimal Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Price can't be a negative number!");
                this.price = value;
            }
        }
        //mtods
        public void ToString()
        {
                Console.WriteLine("{0,-20}{1}", "Computer name: ", this.name);
                if (HasComponent1)
                {
                    Console.WriteLine("{0,-20}{1}", this.component1.Name, this.component1.Details);
                    Console.WriteLine("{0,-20}{1}", this.component1.Name, this.component1.Price);
                }
                if (HasComponent2)
                {
                    Console.WriteLine("{0,-20}{1}", this.component2.Name, this.component2.Details);
                    Console.WriteLine("{0,-20}{1}", this.component2.Name, this.component2.Price);
                }
                Console.WriteLine("--------------------------");
                Console.WriteLine("{0,-20}{1} lv.", "total price: ", this.price);
        }
    }
}
