using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.CompanyHierarchy
{
    using Models;
    public static class TestPeple
    {
        static void Main()
        {
            var employees = new List<Employee>
            {
                new Developer(69, "Maëly", "Howell", 998.88, Department.Production),
                new SalesEmployee(159, "Matthew", "Hart", 898.88, Department.Sales),
                new SalesEmployee(85, "Alice", "Nguyen", 798.88, Department.Sales),
                new Manager(1, "Beverly", "Jenkins", 698.88, Department.Accounting),
                new Manager(333, "Steven", "Rose", 1998.88, Department.Marketing),
                new Developer(5698, "Norma", "Lynch", 2098.88, Department.Production),
                new SalesEmployee(197, "Heather", "Simpson", 80.88, Department.Sales),
                new SalesEmployee(179, "Samuel", "Price", 80.88, Department.Sales),
                new Manager(6, "Kathy", "Lawson", 9908.88, Department.Marketing),
                new Developer(9, "Janet", "Willis", 198.88, Department.Production),
                new Manager(123, "Kelly", "Gutierrez", 398.88, Department.Accounting),
            };

            foreach (var employee in employees)
            {
                Console.WriteLine(employee);
            }
        }
    }
}
