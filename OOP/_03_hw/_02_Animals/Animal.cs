using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Animals
{
    public abstract class Animal : ISoundProducible
    {
        private string name;
        private int age;
        private string gender;
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
                    throw new ArgumentNullException ("Name cannot be a null or empty");
                }
                this.name = value;
            }
        }
        public int Age 
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Age cannot be a negative number");
                }
                this.age = value;
            }
        }
        public string Gender
        {
            get
            {
                return this.gender;
            }
            set
            {
                if ((value != "male") && (value != "female"))
                {
                    throw new ArgumentNullException("Gender can be \"male\" or \"female\".");
                }
                this.gender = value;
            }
        }
        public Animal(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }
        public abstract string ProduceSound();
    }
}
