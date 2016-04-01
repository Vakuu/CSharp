using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaptopShop
{
    public class Battery
    {
        private string batteryModel;
        private double batteryLife;

        public Battery(string batteryModel, double batteryLife)
        {
            this.BatteryModel = batteryModel;
            this.BatteryLife = batteryLife;
        }

        public string BatteryModel
        {
            get
            {
                return this.batteryModel;
            }
            set
            {
                if (value != string.Empty)
                {
                    this.batteryModel = value;
                }
                else
                {
                    throw new Exception("Empty string");
                }
            }
        }

        public double BatteryLife
        {
            get
            {
                return this.batteryLife;
            }
            set
            {
                if (value >= 0)
                {
                    this.batteryLife = value;
                }
                else
                {
                    throw new Exception("Numeric data cannot be negative");
                }
            }
        }
    }
}
