using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_PC_Catalog
{
    class Component
    {
        //fields
        private string name;
        private string details;
        private decimal price;
        //ctors
        public Component(string name, string details, decimal price)
        {
            this.Name         = name;
            this.Details = details;
            this.Price         = price;
        }
        public Component(string name, decimal price)
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
                    throw new ArgumentException("Invalid Component name!");
                this.name = value;
            }
        }
        public string Details
        {
            get { return this.details; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Invalid details!");
                this.details = value;
            }
        }
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
    }
}
