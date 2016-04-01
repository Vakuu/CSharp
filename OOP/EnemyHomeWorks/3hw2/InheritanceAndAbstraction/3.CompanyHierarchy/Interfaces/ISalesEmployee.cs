using System.Collections.Generic;

namespace _3.CompanyHierarchy.Interfaces
{
    public interface ISalesEmployee : IRegularEmployee
    {
        IEnumerable<ISale> Sales
        {
            get;
            set;
        }
    }
}
