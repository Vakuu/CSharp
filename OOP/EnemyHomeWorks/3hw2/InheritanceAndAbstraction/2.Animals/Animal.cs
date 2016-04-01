using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _2.Animals
{
    public abstract class Animal : ISoundProducible
    {
        private string name;
        private double age;

        protected Animal(string name, double age, Gender gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public string Name 
        {
            get 
            {
                return this.name;
            }
            set 
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(value, "Name cannot be empty!");
                }
                this.name = value;
            }
        }
        public double Age 
        {
            get 
            {
                return this.age;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(value.ToString(), "Age cannot be negative");
                }
                this.age = value;
            }
        }
        private Gender Gender { get; set; }

        public abstract string ProduceSound();

        public override string ToString()
        {
            return string.Format(this.GetType().Name + " Name: " + this.Name + " Age: " + this.Age + " Gender: " + this.Gender + " Say: " + this.ProduceSound());
        }
    }
}
