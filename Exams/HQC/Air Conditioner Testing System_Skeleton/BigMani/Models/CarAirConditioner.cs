namespace BigMani.Models
{
    using System;
    using System.Text;

    class CarAirConditioner : AirConditioner
    {
        private int volumeCovered;

        public CarAirConditioner(string manufacturer, string model, int volumeCovered)
            : base(manufacturer, model)
        {
            this.VolumeCovered = volumeCovered;
        }

        public int VolumeCovered
        {
            get
            {
                return this.volumeCovered;
            }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException(string.Format(OutputMessages.NONPOSITIVE, "Volume Covered"));
                }

                this.volumeCovered = value;
            }
        }

        public override bool Test()
        {
            double sqrtVolume = Math.Sqrt(volumeCovered);
            if (sqrtVolume < 3)
            {
                return false;
            }
            return true;
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();

            output.Append(base.ToString());

            output.Append("Volume Covered: " + VolumeCovered + "\r\n");
            output.Append("====================");

            return output.ToString().Trim();
        }
    }
}
