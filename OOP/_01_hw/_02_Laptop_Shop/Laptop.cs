using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace _02_Laptop_Shop
{
    class Laptop
    {
        //fields
        private string model;
        private string manufacturer;
        private string processor;
        private int ram;
        private string graphicsCard;
        private string hdd;
        private string screen;
        private Battery battery;
        private double batteryLife;
        private decimal price;
        //ctors
        public Laptop(string model, string manufacturer,
                      string processor, int ram, string graphicsCard,
                      string hdd, string screen,
                      string type, int cells, int mAh,
                      double batteryLife, decimal price)
        {
            this.Model         = model;       
            this.Manufacturer  = manufacturer;
            this.Processor     = processor;   
            this.Ram           = ram;         
            this.GraphicsCard  = graphicsCard;
            this.Hdd           = hdd;         
            this.Screen        = screen;
            this.battery       = new Battery(type, cells, mAh);
            this.BatteryLife   = batteryLife; 
            this.Price         = price;
        }
        public Laptop(string model, decimal price)
        {
            this.Model = model;
            this.Price = price;
        }
        //props
        public string Model
        {
            get { return this.model; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Invalid model!");
                this.model = value;
            }
        }
        public string Manufacturer
        {
            get { return this.manufacturer; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Invalid manufacturer!");
                this.manufacturer = value;
            }
        }
        public string Processor
        {
            get { return this.processor; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Invalid processor!");
                this.processor = value;
            }
        }
        public int Ram
        {
            get { return this.ram; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("ram can't be a negative number!");
                this.ram = value;
            }
        }
        public string GraphicsCard
        {
            get { return this.graphicsCard; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Invalid graphicsCard!");
                this.graphicsCard = value;
            }
        }
        public string Hdd
        {
            get { return this.hdd; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Invalid hdd!");
                this.hdd = value;
            }
        }
        public string Screen
        {
            get { return this.screen; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Invalid screen!");
                this.screen = value;
            }
        }
        public double BatteryLife
        {
            get { return this.batteryLife; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("BatteryLife can't be a negative number!");
                this.batteryLife = value;
            }
        }
        public decimal Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Price can't be a negative number!");
                this.price = value;
            }
        }
        //mtods
        public static void Antetka1()
        {
            Console.WriteLine("Sample laptop description (full):");
        }
        public static void Antetka2()
        {
            Console.WriteLine("Sample laptop description (mandatory properties only):");
        }
        public void ToString(int a)
        {
            if (a == 1)
            {
                //Console.WriteLine("{0,-15}{1}"      , "model       ", this.model);
                //Console.WriteLine("{0,-15}{1}"      , "manufacturer", this.manufacturer);
                //Console.WriteLine("{0,-15}{1}"      , "processor   ", this.processor);
                //Console.WriteLine("{0,-15}{1} GB"   , "ram         ", this.ram);
                //Console.WriteLine("{0,-15}{1}"      , "graphicsCard", this.graphicsCard);
                //Console.WriteLine("{0,-15}{1}"      , "hdd         ", this.hdd);
                //Console.WriteLine("{0,-15}{1}"      , "screen      ", this.screen);
                //Console.WriteLine("{0,-15}{1}"      , "battery     ", this.battery.ToString());
                //Console.WriteLine("{0,-15}{1} hours", "batteryLife ", this.batteryLife);
                //Console.WriteLine("{0,-15}{1} lv."  , "price       ", this.price);
                FieldInfo[] fields = this.GetType().GetFields(
                             BindingFlags.NonPublic |
                             BindingFlags.Instance);
                string add = "";
                foreach (FieldInfo field in fields)
                {
                    add = "";
                    if (field.Name == "price")
                    { add = " lv."; }
                    if (field.Name == "batteryLife")
                    { add = " hours"; }
                    if (field.Name == "ram")
                    { add = " GB"; }
                    Console.WriteLine("{0,-15}{1}" + add, field.Name, field.GetValue(this));
                }
            }
            else
            {
                Console.WriteLine("{0,-15}{1}", "model       ", this.model);
                Console.WriteLine("{0,-15}{1} lv.", "price       ", this.price);
            }
        }
    }
}
