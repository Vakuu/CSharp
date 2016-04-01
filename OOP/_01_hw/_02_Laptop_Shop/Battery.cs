using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Laptop_Shop
{
    class Battery
    {
        private string type;
        private int cells;
        private int mAh;
        public Battery(string type, int cells, int mAh)
        {
            this.Type = type;
            this.Cells = cells;
            this.MAh = mAh;
        }

        public string Type
        {
            get { return this.type; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Invalid battery type!");
                this.type = value;
            }
        }
        public int Cells
        {
            get { return this.cells; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Cells can't be a negative number!");
                this.cells = value;
            }
        }
        public int MAh
        {
            get { return this.mAh; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("mAh can't be a negative number!");
                this.mAh = value;
            }
        }
        public string ToString()
        {
            return this.type + ", " + this.cells + ", " + this.mAh;
        }
    }
}
