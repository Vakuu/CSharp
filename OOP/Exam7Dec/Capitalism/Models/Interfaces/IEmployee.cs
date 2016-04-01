using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitalism.Interfaces
{
    using Models;
    public interface IEmployee : IPaidPerson
    {
        Department Department { get;  }
        protected double SalaryFactor { get; protected set; }
    }
}
