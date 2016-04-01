using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.CompanyHierarchy.Interfaces
{
    public interface ISale
    {
        string ProductName { get; set; }
        DateTime SaleDate { get; set; }
        double ProductPrice { get; set; }
    }
}
