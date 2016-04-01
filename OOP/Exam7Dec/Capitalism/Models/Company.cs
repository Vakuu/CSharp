using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitalism.Models 
{
    class Company : ICompanyStructure
    {
        private CEO ceo;
        public string Name { get; set; }
        public CEO CEO 
        {
            get
            {
                return this.CEO;
            }
            private set
            {
                if (value==null)
                {
                    throw new ArgumentNullException("name","The name cannot be empty!");
                    this.CEO = value;
                }
            }
        }
        public ICollection<Department> Departments { get; set; }
    }
}
