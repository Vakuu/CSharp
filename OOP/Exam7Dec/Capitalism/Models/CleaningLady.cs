using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitalism.Models
{
    class CleaningLady : Employee
    {
        protected override double SalaryFactor
        {
            get
            {
                return 0.98;
            }
        }
    }
}
