namespace _01_HumanStudentAndWorker
{
    using System;

    public class Student : Human
    {
        private string facultyNumber;

        public Student(string fName, string lName, string facultyNumber)
            : base(fName, lName)
        {
            this.FacultyNumber = facultyNumber;
        }

        public string FacultyNumber
        {
            get
            {
                return this.facultyNumber;
            }
            set
            {
                if ((value.Length < 5) || (value.Length > 10))
                {
                    throw new ArgumentOutOfRangeException("facultyNumber have to be between 5 and 10 symbols");
                }

                this.facultyNumber = value;
            }
        }
    }
}
