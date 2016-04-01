using System.Collections.Generic;

namespace _3.CompanyHierarchy.Interfaces
{
    public interface IDeveloper : IRegularEmployee
    {
        IEnumerable<IProject> Projects
        {
            get;
            set;
        }
    }
}
