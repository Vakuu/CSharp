using System;

namespace _03_CompanyHierarchy.Interfaces
{
    using Enumerations;
    interface IEmployee
    {
        decimal Salary { get; set; }
        Department Department { get; set; }
    }
}