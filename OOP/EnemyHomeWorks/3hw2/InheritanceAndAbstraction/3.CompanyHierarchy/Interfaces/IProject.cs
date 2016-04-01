using System;

namespace _3.CompanyHierarchy.Interfaces
{
    using Models;
    public interface IProject
    {
        string ProjectName { get; set; }
        DateTime StartDate { get; set; }
        string ProjectDetails { get; set; }
        State ProjectState { get; set; }
        void CloseProject();
        
    }
}
