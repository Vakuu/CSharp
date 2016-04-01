using System;
using System.Collections.Generic;
using System.Text;

namespace PCCatalog
{
    public class Computer
    {
        private string name;
        private List<Component> components = new List<Component>();
        private decimal price;

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be empty!");
                }
                this.name = value;
            }
        }

        public decimal Price
        {
            get { return this.price; }
            private set
            {
                this.price = value;
            }
        }

        public Component[] Components { get; set; }

        public Computer(string name) : this(name, null) { }
        public Computer(string name, List<Component> components)
        {
            this.Name = name;
            if (components != null)
            {
                for (int i = 0; i < components.Count; i++)
                {
                    this.components.Add(components[i]);
                }
                this.Price = CalcPrice(components);
            }
        }

        private decimal CalcPrice(List<Component> components)
        {
            decimal total = 0.0m;
            foreach (var comp in components)
            {
                total += comp.Price;
            }
            return total;
        }

        override public string ToString()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("Computer Name: ");
            strBuilder.Append(this.Name);
            strBuilder.AppendLine();
            foreach (var component in this.components)
            {
                strBuilder.Append(component.ToString());
                strBuilder.AppendLine();
            }
            strBuilder.Append("Total Computer Price: ");
            strBuilder.Append(this.Price.ToString());
            strBuilder.AppendLine();
            return strBuilder.ToString();
        }
    }
}
