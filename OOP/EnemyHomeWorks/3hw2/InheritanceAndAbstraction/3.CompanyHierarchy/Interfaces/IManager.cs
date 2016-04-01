using System.Collections.Generic;

namespace _3.CompanyHierarchy.Interfaces
{
    using Models;
    public interface IManager
    {
        IEnumerable<Employee> employeesUnderComand { get; set; }
    }
}
