using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitalism.Models
{
    public abstract class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        protected virtual double SalaryFactor
        {
            get
            {

            }
        }
    }
}
