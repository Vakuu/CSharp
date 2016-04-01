using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.CompanyHierarchy.Models
{
    using Interfaces;
    public class Sale : ISale
    {
        private string productName;
        private DateTime saleDate;
        private double productPrice;

        public Sale(string productName, DateTime saleDate, double productPrice)
        {
            this.ProductName = productName;
            this.SaleDate = saleDate;
            this.ProductPrice = productPrice;
        }

        public string ProductName { get; set; }
        public DateTime SaleDate { get; set; }
        public double ProductPrice { get; set; }
    }
}

//sale holds product name, date and price.