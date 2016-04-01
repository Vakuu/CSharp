using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_CompanyHierarchy
{
    using Persons;
    using Enumerations;
    using Projects_and_Sales;
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<Person> persons = new List<Person>
                {
                    new Manager("Shefo", "Accountev", 235635, 3500, Department.Accounting,
                        new Employee("Gergana", "Hristova", 64256, 1000, Department.Sales),
                        new Employee("Stoyan", "Ivanov", 56463, 800, Department.Production)),
                    new SalesEmployee("Selar", "Marketinger", 12567, 1200, Department.Marketing,
                        new Sale("Game Engine", new DateTime(2015, 04, 02), 12000),
                        new Sale("Facebook Application", new DateTime(2013, 10, 07), 6000),
                        new Sale("Bank Database", new DateTime(2014, 07, 17), 7400),
                        new Sale("Shop Program", new DateTime(2010, 09, 01), 2300)
                        ),
                    new Developer("Ivan", "Vasilev", 54362, 6400, Department.Production, 
                        new Project("Super Cars", new DateTime(2014, 05, 03), "This project will consider the problem with the super cars.", State.Open),
                        new Project("Financial Help", new DateTime(2009, 02, 05), "This project will concern the problem with financial help.", State.Closed),
                        new Project("Increase Company Profits", new DateTime(2015, 10, 01), "This project will increase the profits of the company.", State.Open)
                        ),
                };

                foreach (Person person in persons)
                {
                    Console.WriteLine("{0}{1}", person, Environment.NewLine);
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
