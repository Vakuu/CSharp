using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_HumanStudentAndWorker
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s00 = new Student("fn0", "ln0", "00000");
            Student s01 = new Student("fn1", "ln1", "11111");
            Student s02 = new Student("fn2", "ln2", "11112");
            Student s03 = new Student("fn3", "ln3", "11113");
            Student s04 = new Student("fn4", "ln4", "11114");
            Student s05 = new Student("fn5", "ln5", "11115");
            Student s06 = new Student("fn6", "ln6", "11116");
            Student s07 = new Student("fn7", "ln7", "11117");
            Student s08 = new Student("fn8", "ln8", "11118");
            Student s09 = new Student("fn9", "ln9", "11119");
            List<Student> students = new List<Student>
            {
                s00,
                s01,
                s02,
                s03,
                s04,
                s05,
                s06,
                s07,
                s08,
                s09
            };
            List<Student> SortedStudentList = students.OrderBy(o => o.FacultyNumber).ToList();
            Worker w00 = new Worker("fn00", "ln00", 00000, 0);
            Worker w01 = new Worker("fn11", "ln11", 11111, 1);
            Worker w02 = new Worker("fn22", "ln22", 11112, 2);
            Worker w03 = new Worker("fn33", "ln33", 11113, 3);
            Worker w04 = new Worker("fn44", "ln44", 11114, 4);
            Worker w05 = new Worker("fn55", "ln55", 11115, 5);
            Worker w06 = new Worker("fn66", "ln66", 11116, 6);
            Worker w07 = new Worker("fn77", "ln77", 11117, 7);
            Worker w08 = new Worker("fn88", "ln88", 11118, 8);
            Worker w09 = new Worker("fn99", "ln99", 11119, 9);
            List<Worker> workers = new List<Worker>
            {
                w00,
                w01,
                w02,
                w03,
                w04,
                w05,
                w06,
                w07,
                w08,
                w09
            };
            List<Worker> SortedWorkerstList = workers.OrderByDescending(o => o.MoneyPerHour()).ToList();
            List<Human> shumans = new List<Human>(students);
            List<Human> whumans = new List<Human>(workers);
            List<Human> mergedAndSorted = new List<Human>(shumans.Concat(whumans).OrderBy(x => x.FName).ThenBy(c => c.LName).ToList());
            foreach (Human human in mergedAndSorted)
            {
                Console.WriteLine(human.FName + " " + human.LName);
            }
        }
    }
}
