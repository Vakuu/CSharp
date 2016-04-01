using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_HumanStudentAndWorker
{
    class Worker : Human
    {
        private double weekSalary;
        private double workHoursPerDay;
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
                    throw new ArgumentOutOfRangeException("WeekSalary cannot be a negative number");
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
                    throw new ArgumentOutOfRangeException("WorkHoursPerDay cannot be a negative number");
                }
                this.workHoursPerDay = value;
            } 
        }
        public Worker(string fName, string lName, double weekSalary, double workHoursPerDay)
            : base (fName,lName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }
        public double MoneyPerHour()
        {
            return this.WeekSalary / (5 * this.WorkHoursPerDay);
        }
    }
}
