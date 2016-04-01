using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Persons
{
    public class Person
    {
        //Declaring fields for name,age,email:
        private string name;
        private int age;
        private string email;

        //Declaring Properties:
        public string Name
        {
            get { return this.name; }
            set
            {
                //Checking If Null or Empty and Throwing Exception: 
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be empty!");
                }
                this.name = value;
            }
        }

        public int Age
        {
            get { return this.age; }
            set
            {
                //Checking If value is in the range [1...100] and Throwing Exception: 
                if (value < 1 || value > 100)
                {
                    throw new ArgumentException("Age must be between 1 and 100!");
                }
                this.age = value;
            }
        }

        public string Email
        {
            get { return this.email; }
            set
            {
                //Checking If the Email string is empty, or not containing "@" Throwing Exception:
                if (!string.IsNullOrEmpty(value) && !value.Contains("@"))
                {
                    throw new ArgumentException("Email must contains @ character!");
                }
                this.email = value;
            }
        }

        //Declaring First Constructor
        public Person(string name, int age, string email)
        {
            this.Name = name;
            this.Age = age;
            this.Email = email;
        }
        //Declaring Second Constructor
        public Person(string name, int age)
            : this(name, age, null)
        {

        }
        //Implement :ToString():
        public override string ToString()
        {
            return string.Format("Name:{0}, Age:{1}, Email:{2}", this.Name, this.Age,
                string.IsNullOrEmpty(this.Email) ? "not set" : this.Email);
        }
    }
}