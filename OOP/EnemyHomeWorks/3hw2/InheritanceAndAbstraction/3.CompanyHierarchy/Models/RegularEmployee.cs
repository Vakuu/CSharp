using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.CompanyHierarchy.Models
{
    using Interfaces;
    public abstract class RegularEmployee : Employee, IRegularEmployee
    {
        public RegularEmployee(int id, string firstName, string lastName, double salary, Department department)
            : base(id, firstName, lastName, salary, department)
        {

        }
    }
}
