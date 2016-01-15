namespace Methods
{
    using System;
    using System.Globalization;
    using System.Text.RegularExpressions;

    class Student
    {
        private string _firstName;
        private string _lastName;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="firstName">Enter first name of the student</param>
        /// <param name="lastName">Enter last name of the student</param>
        /// <param name="otherInfo">Enter other info containing the birth date in format dd.mm.yyyy</param>
        public Student(string firstName, string lastName, string otherInfo = "")
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.OtherInfo = otherInfo;
        }

        public string FirstName
        {
            get
            {
                return this._firstName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The firstName cannot be empty or null.");
                }
                this._firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return this._lastName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The lastName cannot be empty or null.");
                }
                this._lastName = value;
            }
        }
        public string OtherInfo { get; set; }

        public bool IsOlderThan(Student other)
        {
            DateTime? firstDate = this.GetFirstDateFromString(this.OtherInfo);
            DateTime? secondDate = this.GetFirstDateFromString(other.OtherInfo);
            if (firstDate==null)
            {
                throw new ArgumentException(this.FirstName+" does not contain a valid date in otherInfo data section");
            }
            if (secondDate==null)
            {
                throw new ArgumentException(other.FirstName+" does not contain a valid date in otherInfo data section", other.FirstName);
            }
            return firstDate < secondDate;
        }

        private DateTime? GetFirstDateFromString(string inputText)
        {
            var regex = new Regex(@"\b\d{2}\.\d{2}.\d{4}\b");
            foreach (Match m in regex.Matches(inputText))
            {
                DateTime dt;
                if (DateTime.TryParseExact(m.Value, "dd.MM.yyyy", null, DateTimeStyles.None, out dt))
                    return dt;
            }
            return null;
        }
    }
}
