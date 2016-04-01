using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.CompanyHierarchy.Models
{
    using Interfaces;
    public abstract class Employee : Person, IEmployee
    {
        private double salary;
        private Department department;

        protected Employee(int id, string firstName, string lastName, double salary, Department department)
            : base(id, firstName, lastName)
        {
            this.Salary = salary;
            this.Department = department;
        }

        public double Salary { get; set; }
        public Department Department
        {
            get;
            set;
        }

    }
}
