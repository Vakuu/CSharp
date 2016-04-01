using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.CompanyHierarchy.Models
{
    using Interfaces;
    public class Customer : Person, ICustomer
    {
        private double netPurchaseAmount;

        public Customer(int id, string firstName, string lastName, double netPurchaseAmount)
            : base(id, firstName, lastName)
        {
            this.NetPurchaseAmount = netPurchaseAmount;
        }

        public double NetPurchaseAmount 
        {
            get { return this.netPurchaseAmount; }
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Wrong format!");
                }
                this.netPurchaseAmount = value;
            }
        }       
    }
}

