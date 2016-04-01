using System;

namespace LaptopShop
{
    class Battery
    {
        private string batteryType;
        private int batteryLife;

        public Battery(string batteryType, int batteryLife)
        {
            this.BatteryType = batteryType;
            this.BatteryLife = batteryLife;
        }

        public string BatteryType
        {
            get { return this.batteryType; }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Battery type cannot be empty");
                }
                this.batteryType = value;
            }
        }

        public int BatteryLife
        {
            get { return this.batteryLife; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Battery life cannot be zero or negative!");
                }
                this.batteryLife = value;
            }
        }
    }
}
