using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_InterestCalculator
{
    public class InterestCalculator
    {
        public InterestCalculator(decimal money, double interest, int years, CalculateInterestDelegate interestCalculationDelegate)
        {
            this.Money = money;
            this.Interest = interest;
            this.Years = years;
            this.InterestCalculationDelegate = interestCalculationDelegate;
        }

        public decimal Money { get; set; }
        public double Interest { get; set; }
        public int Years { get; set; }
        public CalculateInterestDelegate InterestCalculationDelegate { get; set; }

        public double GetInterest()
        {
            return this.InterestCalculationDelegate(this.Money, this.Interest, this.Years);
        }
    }
}
