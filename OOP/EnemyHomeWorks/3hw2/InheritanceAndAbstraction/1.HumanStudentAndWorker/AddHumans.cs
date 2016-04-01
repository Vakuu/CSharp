using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.HumanStudentAndWorker
{
    class AddHumans
    {
        static void Main()
        {
            List<Student> students = new List<Student>();
            List<Worker> workers = new List<Worker>();
            try
            {
               
                students.Add(new Student("Petar", "Petrov", "A11119"));
                students.Add(new Student("Vasil", "Petrov", "11112"));
                students.Add(new Student("Petar", "Vasilev", "11117"));
                students.Add(new Student("Petar", "Yordanov", "B11121"));
                students.Add(new Student("Yordan", "Petrov", "11115"));
                students.Add(new Student("Dimitar", "Petrov", "11116"));
                students.Add(new Student("Petar", "Dimitrov", "011113"));
                students.Add(new Student("Stamat", "Petrov", "11118"));
                students.Add(new Student("Georgi", "Dinev", "C11111"));
                students.Add(new Student("Mancho", "Cvetkov", "11114"));

                workers.Add(new Worker("Yordan", "Petkov", 500, 8));
                workers.Add(new Worker("Vasil", "Stoyanov", 200, 4));
                workers.Add(new Worker("Petko", "Vasilev", 500, 6));
                workers.Add(new Worker("Petko", "Yordanov", 550, 8));
                workers.Add(new Worker("Yordan", "Yordanov", 650, 7));
                workers.Add(new Worker("Dimitar", "Dimitrov", 250, 2));
                workers.Add(new Worker("Petar", "Stoyanov", 350, -8));
                workers.Add(new Worker("Stamat", "Stamatov", 1050, 10));
                workers.Add(new Worker("Anton", "Dinev", 1250, 16));
                workers.Add(new Worker("Mancho", "Peshov", -300, 11));
            }
            catch (ArgumentNullException ne)
            {
                Console.WriteLine("{0}", ne.Message);
            }
            catch(ArgumentOutOfRangeException re)
            {
                Console.WriteLine("{0}", re.Message);
            }

            students = new List<Student>(students.OrderBy(p => p.FacultyNumber));
            foreach (var student in students)
            {
                Console.WriteLine("{0} {1} Faculty number: {2}", student.FirstName, student.LastName, student.FacultyNumber);
            }
            Console.WriteLine();

            workers = new List<Worker>(workers.OrderBy(p => p.MoneyPerHour()));
            foreach (var worker in workers)
            {
                Console.WriteLine("{0} {1} Money per hour: {2:F}", worker.FirstName, worker.LastName, worker.MoneyPerHour());
            }
            Console.WriteLine();

            List<Human> studentsAndWorkers = new List<Human>();
            studentsAndWorkers.AddRange(students);
            studentsAndWorkers.AddRange(workers);

            studentsAndWorkers = new List<Human>(studentsAndWorkers.OrderBy(p => p.FirstName).ThenBy(p => p.LastName));
            foreach (var human in studentsAndWorkers.OrderBy(h => h.FirstName).ThenBy(h => h.LastName))
            {
                Console.WriteLine("{0} {1}", human.FirstName, human.LastName);
            }
           
        }
    }
}
