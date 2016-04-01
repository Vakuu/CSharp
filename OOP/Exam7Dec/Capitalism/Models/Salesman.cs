using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitalism.Models
{
    class Salesman : Employee
    {
        protected override double SalaryFactor
        {
            get
            {
                return CleaningLadySalaryFactor;
            }
        }
    }
}
