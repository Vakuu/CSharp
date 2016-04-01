using System;

namespace _03_CompanyHierarchy.Interfaces
{
    using Projects_and_Sales;
    using System.Collections.Generic;
    interface IDeveloper
    {
        List<Project> Projects { get; set; }
    }
}