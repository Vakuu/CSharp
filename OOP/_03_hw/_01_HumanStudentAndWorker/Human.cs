using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_HumanStudentAndWorker
{
    public abstract class Human
    {
        private string fName;
        private string lName;
        public string FName { get; set; }
        public string LName { get; set; }
        public Human(string fName, string lName)
        {
            this.FName = fName;
            this.LName = lName;
        }
    }
}
