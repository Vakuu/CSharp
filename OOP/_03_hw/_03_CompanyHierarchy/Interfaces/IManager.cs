using System;

namespace _03_CompanyHierarchy.Interfaces
{
    using Persons;
    using System.Collections.Generic;
    interface IManager
    {
        List<Employee> Employees { get; set; }
    }
}