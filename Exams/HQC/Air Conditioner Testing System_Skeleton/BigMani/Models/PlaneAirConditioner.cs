namespace BigMani.Models
{
    using System;
    using System.Text;

    class PlaneAirConditioner : CarAirConditioner
    {
        private int electricityUsed;

        public PlaneAirConditioner(string manufacturer, string model, int volumeCovered, int electricityUsed)
            : base(manufacturer, model, volumeCovered)
        {
            this.ElectricityUsed = electricityUsed;
        }

        public int ElectricityUsed
        {
            get
            {
                return this.electricityUsed;
            }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException(string.Format(OutputMessages.NONPOSITIVE, "Electricity Used"));
                }

                this.electricityUsed = value;
            }
        }

        public override bool Test()
        {
            double sqrtVolume = Math.Sqrt(base.VolumeCovered);
            if (this.ElectricityUsed / sqrtVolume < OutputMessages.MinPlaneElectricity)
            {
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();

            output.Append(base.ToString());

            output.Append("Volume Covered: " + VolumeCovered + "\r\n" + "Electricity Used: " + ElectricityUsed + "\r\n");
            output.Append("====================");

            return output.ToString().Trim();
        }
    }
}
