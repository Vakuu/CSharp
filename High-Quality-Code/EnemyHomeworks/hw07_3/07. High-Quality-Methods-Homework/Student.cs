using System;

namespace Methods
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string OtherInfo { get; set; }


        public DateTime GetAge()
        {
            DateTime studentAge =
                DateTime.Parse(this.OtherInfo.Substring(this.OtherInfo.Length - 10));
            return studentAge;
        }


        public bool IsOlderThan(Student other)
        {

            return this.GetAge() > other.GetAge();
        }
    }
}
