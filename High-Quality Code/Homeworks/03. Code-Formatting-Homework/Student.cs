using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_HumanStudentAndWorker
{
    public class Student : Human
    {
        private string facultyNumber;
        public string FacultyNumber
        {
            get
            {
                return this.facultyNumber;
            }
            set
            {
                if ((value.Length<5)||(value.Length>10))
                {
                    throw new ArgumentOutOfRangeException("facultyNumber have to be between 5 and 10 symbols");
                }
                this.facultyNumber = value;
            } 
        }
        public Student(string fName, string lName, string facultyNumber)
            : base (fName,lName)
        {
            this.FacultyNumber = facultyNumber;
        }
    }
}
