using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Customer
{
    public class Payment : IPayment
    {
        private string name;
        private decimal price;

        public Payment(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be null or empty.");
                }
                this.name = value;
            }
        }
        public decimal Price
        {
            get
            {
                return this.price;
            }

            private set
            {
                if (value<0)
                {
                    throw new ArgumentOutOfRangeException("Price can be only positive.");
                }
                this.price = value;
            }
        }
    }
}
