using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitalism.Models
{
    public interface IBoss
    {
        ICollection<Employee> Subordinants { get; set; }
    }
}
