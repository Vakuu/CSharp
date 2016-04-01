using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.HumanStudentAndWorker
{
    public class Worker : Human
    {
        private double weekSalary;
        private double workHoursPerDay;

        public Worker(string firstName, string lastName, double weekSalary, double workHoursPerDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public double WeekSalary 
        {
            get 
            {
                return this.weekSalary;
            }
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(value.ToString(), "Week salary cannot be negative.");
                }
                this.weekSalary = value;
            }
        }

        public double WorkHoursPerDay 
        {
            get 
            {
                return this.workHoursPerDay;
            }
            set 
            {
                 if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(value.ToString(),"Work howers salary cannot be negative.");
                }
                this.workHoursPerDay = value;
            }
        }

        public double MoneyPerHour()
        {
            return this.weekSalary / (double)(5 * this.workHoursPerDay);
        }

        public override string ToString()
        {
            return base.ToString() + this.WeekSalary + " " + this.WorkHoursPerDay;
        }
    }
}


