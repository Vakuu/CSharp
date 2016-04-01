using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Persons
{
    public class Person
    {
        private string name;
        private int age;
        private string email;
        private const string EmailPattern = @"(?<=\s|^)([A-Za-z0-9]*(?:[_.-][A-Za-z0-9]*)*@(?:[A-Za-z]*\-?[A-Za-z]*\.)*[A-Za-z]*\-?[A-Za-z]*)\b";


        public Person(string name, int age)
            : this(name, age, null)
        {
            
        }

        public Person(string name, int age, string email)
        {
            this.Name = name;
            this.Age = age;
            this.Email = email;
        }

       

     
        public string Name
        {
            get { return this.name; }

            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Name cannot be empty.");
                }
                this.name = value;
            }
        }

        public int Age
        {
            get { return this.age; }

            set
            {
                if (value <= 0 || value > 100)
                {
                    throw new ArgumentOutOfRangeException("Age must be in the range [1 ... 100].");
                }
                this.age = value;
            }
        }


        public string Email
        {
            get { return this.email; }

         
           set
            {
                if (value != null && !Regex.IsMatch(value, EmailPattern))
                {
                    throw new ArgumentException(@"Email should contain ""@""", "email");
                }

                this.email = value;
            }
        }
           

        public override string ToString()
        {
            return "You are " + this.name + ". You are " + this.age + " years old. Your email is " + (string.IsNullOrEmpty(this.email) ? "not entered." : this.email);
        }

        

        static void Main()

        {
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your age:");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your email:");
            string email = Console.ReadLine();
            Person one = new Person(name, age);
            Console.WriteLine(one);

        }
    }
}
