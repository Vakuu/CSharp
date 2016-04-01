using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.CompanyHierarchy.Models
{
    public class Project
    {
        private string projectName;
        private DateTime startDate;
        private string projectDetails;

        public Project(string projectName, DateTime startDate, string projectDetails, State projectState)
        {
            this.ProjectName = projectName;
            this.StartDate = startDate;
            this.ProjectDetails = projectDetails;
            this.ProjectState = projectState;
        }

        public string ProjectName { get; set; }
        public DateTime StartDate { get; set; }
        public string ProjectDetails { get; set; }
        public State ProjectState { get; set; }

        public void CloseProject()
        {
            Console.WriteLine("Closed project!");
        }
    }
}
