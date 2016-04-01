using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitalism.Models
{
    using Interfaces;
    public abstract class PaidPerson : IPaidPerson, IPerson
    {
        private string firstName;
        private string lastName;
        private decimal salary;
        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value) || (value.Length < 2))
                {
                    throw new ArgumentException("The name should be valid!");
                }
            }
        }
        public string LastName
        {
            get
            {
                return this.lastName;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value) || (value.Length < 2))
                {
                    throw new ArgumentException("The name should be valid!");
                }
            }
        }
        public decimal Salary
        {
            get
            {
                return this.salary;
            }
            set
            {
                if (value<=0)
                {
                    throw new ArgumentOutOfRangeException("salary", "The salary should be positive!");
                }
            }
        }
    }
}
