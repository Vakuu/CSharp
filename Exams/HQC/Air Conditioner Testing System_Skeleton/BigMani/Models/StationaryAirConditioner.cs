namespace BigMani.Models
{
    using System;
    using System.Text;

    class StationaryAirConditioner : AirConditioner
    {
        private int powerUsage;
        private string energyEfficiencyRating;

        public StationaryAirConditioner(string manufacturer, string model, int powerUsage, string energyEfficiencyRating)
            : base(manufacturer, model)
        {
            this.PowerUsage = powerUsage;
            this.EnergyEfficiencyRating = energyEfficiencyRating;
        }

        public int PowerUsage
        {
            get { return this.powerUsage; }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException(string.Format(OutputMessages.NONPOSITIVE, "Power usage"));
                }

                this.powerUsage = value;
            }
        }

        public string EnergyEfficiencyRating
        {
            get { return this.energyEfficiencyRating; }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length > 1 || value[0] < 'Á' || value[0] > 'E')
                {
                    throw new ArgumentOutOfRangeException(
                        "A stationary air conditioner’s required energy efficiency rating must be a valid rating from “A” to “E”.");
                }

                this.energyEfficiencyRating = value;
            }
        }

        public override bool Test()
        {
            char requiredEfficency = this.energyEfficiencyRating[0];
            if (this.PowerUsage<1000)
            {
                return true;
            }
            if (this.PowerUsage <= 1250 && requiredEfficency > 'A')
            {
                return true;
            }
            if (this.PowerUsage <= 1500 && requiredEfficency > 'B')
            {
                return true;
            }
            if (this.PowerUsage <= 2000 && requiredEfficency > 'C')
            {
                return true;
            }
            if (this.PowerUsage > 2000 && requiredEfficency > 'D')
            {
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();

            output.Append(base.ToString());

            output.Append("Required energy efficiency rating: " + this.energyEfficiencyRating + "\r\n" +
                          "Power Usage(KW / h): " + this.PowerUsage + "\r\n");
            output.Append("====================");

            return output.ToString().Trim();
        }
    }
}
