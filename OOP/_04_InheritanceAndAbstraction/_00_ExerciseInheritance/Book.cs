using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_ExerciseInheritance
{
    public class Book
    {
        //fields
        protected string title;
        protected string author;
        protected double price;
        //props
        public string Title
        {
            get { return this.title; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Invalid title!");
                this.title = value;
            }
        }
        public string Author
        {
            get { return this.author; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Invalid author!");
                this.author = value;
            }
        }
        public virtual double Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Price can't be a negative number!");
                this.price = value;
            }
        }
        //ctors
        public Book(string title, string author, double price)
        {
            this.Title = title;
            this.Author = author;
            this.Price = price;
        }
        //
        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendFormat("-Type: {0}{1}", this.GetType().Name, Environment.NewLine);
            output.AppendFormat("-Title: {0}{1}", this.Title, Environment.NewLine);
            output.AppendFormat("-Author: {0}{1}", this.Author, Environment.NewLine);
            output.AppendFormat("-Price: {0}{1}", this.Price, Environment.NewLine);
            return output.ToString();
        }
    }
}
