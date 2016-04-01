using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace _01_Persons
{
    class Person
    {
        //defaults
        private static string defaultEmail = null;
        //fields
        private string name;
        private int age;
        private string email;
        //contructors
        public Person(string name, int age, string email)
        {
            this.Name = name;
            this.Age = age;
            this.Email = email;
        }
        public Person(string name, int age)
            : this(name, age, defaultEmail)
        {
        }
        //properties
        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Invalid name!");
                this.name = value;
            }
        }
        //fun :)
        //fixed and working property string while its field is int
        //public string Age
        //{
        //    get { return this.age.ToString(); }
        //    set
        //    {
        //        if (int.Parse(value)<1||int.Parse(value)>100)
        //            throw new ArgumentException("Invalid age!");
        //        this.age = int.Parse(value);
        //    }
        //}
        public int Age
        {
            get { return this.age; }
            set
            {
                if (value < 1 || value > 100)
                    throw new ArgumentException("Invalid age!");
                this.age = value;
            }
        }
        public string Email
        {
            get { return this.email; }
            set
            {
                if ((value=="")||(value.IndexOf('@') == -1))
                    throw new ArgumentException("Invalid email!");
                this.email = value;
            }
        }
        //methods
        public static void Antetka ()
        {
            Console.WriteLine("{0,-40}{1,-5}{2}","Name","Age","Email");
        }
        public void ToString ()
        {
            Console.WriteLine("{0,-40}{1,-5}{2}",this.name,this.age,this.email);
        }
    }
}
