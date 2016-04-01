using System;

namespace _03_CompanyHierarchy.Interfaces
{
    interface IPerson
    {
        string FirstName { get; set; }

        string LastName { get; set; }

        int Id { get; set; }
    }
}