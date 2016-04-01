using System;
using System.Text;

namespace LaptopShop
{
    class Laptop
    {
        private string model;
        private string manufacturer;
        private string processor;
        private int ram;
        private string gpu;
        private string hdd;
        private string screen;
        private Battery battery;
        private int price;

        public Laptop(string model, int price)
        {
            this.Model = model;
            this.Price = price;
        }

        public Laptop(string model, string manufacturer, string processor, int ram, string gpu,
            string hdd, string screen, Battery battery, int price)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Processor = processor;
            this.RAM = ram;
            this.GPU = gpu;
            this.HDD = hdd;
            this.Screen = screen;
            this.Battery = battery;
            this.Price = price;
        }

        public string Model
        {
            get { return this.model; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Laptop model cannot be empty!");
                }
                this.model = value;
            }
        }

        public int Price
        {
            get { return this.price; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Laptop price cannot be zero or negative!");
                }
                this.price = value;
            }
        }

        public string Manufacturer
        {
            get { return this.manufacturer; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Manufacturer name cannot be empty!");
                }
                this.manufacturer = value;
            }
        }

        public string Processor
        {
            get { return this.processor; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Processor nodel cannot be empty!");
                }
                this.processor = value;
            }
        }

        public int RAM
        {
            get { return this.ram ; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("RAM cannot be zero or negative!");
                }
                this.ram = value;
            }
        }

        public string GPU
        {
            get { return this.gpu; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("GPU model be empty!");
                }
                this.gpu = value;
            }
        }

        public string HDD
        {
            get { return this.hdd; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("HDD model cannot be empty!");
                }
                this.hdd = value;
            }
        }

        public string Screen
        {
            get { return this.screen; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Screen model cannot be empty!");
                }
                this.screen = value;
            }
        }

        public Battery Battery
        {
            get { return this.battery; }
            set
            {
                this.battery = value;
            }
        }

        public override string ToString()
        {
            string seperator = "+" + new string('-', 15) + "+" + new string('-', 35) + "+";
            StringBuilder output = new StringBuilder();
            output.AppendLine(seperator);

            output.AppendLine($"|{"Model",-15}|{this.Model,-35}|");
            output.AppendLine(seperator);

            if (this.Manufacturer != null)
            {
                output.AppendLine($"|{"Manufacturer",-15}|{this.Manufacturer,-35}|");
                output.AppendLine(seperator);
            }

            if (this.Processor != null)
            {
                output.AppendLine($"|{"Processor",-15}|{this.Processor,-35}|");
                output.AppendLine(seperator);
            }

            if (this.RAM > 0)
            {
                output.AppendLine($"|{"RAM",-15}|{this.RAM,-35}|");
                output.AppendLine(seperator);
            }

            if (this.GPU != null)
            {
                output.AppendLine($"|{"GPU",-15}|{this.GPU,-35}|");
                output.AppendLine(seperator);
            }

            if (this.HDD != null)
            {
                output.AppendLine($"|{"HDD",-15}|{this.HDD,-35}|");
                output.AppendLine(seperator);
            }

            if (this.Screen != null)
            {
                output.AppendLine($"|{"Screen",-15}|{this.Screen,-35}|");
                output.AppendLine(seperator);
            }

            if (this.Battery != null)
            {
                output.AppendLine($"|{"Battery",-15}|{this.Battery.BatteryType,-35}|");
                output.AppendLine(seperator);
                output.AppendLine($"|{"Battery life",-15}|{this.Battery.BatteryLife + " hours",-35}|");
                output.AppendLine(seperator);
            }

            output.AppendLine($"|{"Price",-15}|{this.Price,-35:C}|");
            output.AppendLine(seperator);

            return output.ToString();
        }
    }
}
