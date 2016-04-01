namespace BigMani.Models
{
    using System;
    using System.Text;
    using Core.Interfaces;

    public class AirConditioner : IAirConditioner
    {
        private string manufacturer;
        private string model;

        public AirConditioner(string manufacturer, string model)
        {
            this.Manufacturer = manufacturer;
        }

        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value)||value.Length< OutputMessages.ManufacturerMinLength)
                {
                    throw new ArgumentException(string.Format(OutputMessages.INCORRECT_PROPERTY_LENGTH, "Manufacturer", OutputMessages.ManufacturerMinLength));
                }

                this.manufacturer = value;
            }
        }

        public string Model
        {
            get
            {
                return this.model;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < OutputMessages.ModelMinLength)
                {
                    throw new ArgumentException(string.Format(OutputMessages.INCORRECT_PROPERTY_LENGTH, "Model", OutputMessages.ModelMinLength));
                }

                this.model = value;
            }
        }

        public virtual bool Test()
        {
            return true;
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();

            output.Append("Air Conditioner" + "\r\n" + "====================" + "\r\n" + "Manufacturer: " +
                           this.Manufacturer + "\r\n" + "Model: " + this.Model + "\r\n");

            return output.ToString().Trim();
        }
    }
}
