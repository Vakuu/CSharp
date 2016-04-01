using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Persons
{
    class Program
    {
        static void Main(string[] args)
        {
            Person firstPerson = new Person("Vasil Andreev Andreev",34,"vakuu_@abv.bg");
            Person secondPerson = new Person("Miroslav Iordanov Chernev", 29, "miro_@abv.bg");
            Person thirdPerson = new Person("Valentina Cheshmedjieva Shokoladova", 58, "valq_@abv.bg");
            Person[] persons = new Person[] { firstPerson, secondPerson, thirdPerson };
            Person.Antetka();
            foreach (Person person in persons)
            {
                person.ToString();
            }
        }
    }
}
