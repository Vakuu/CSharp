using System;

namespace _03_CompanyHierarchy.Persons
{
    using Enumerations;

    public abstract class RegularEmployee : Employee
    {
        protected RegularEmployee(string firstName, string lastName, int id,
            decimal salary, Department department)
            : base(firstName, lastName, id, salary, department)
        {
        }
    }
}