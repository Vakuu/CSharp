using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Customer
{
    public interface IPayment
    {
        string Name { get; }
        decimal Price { get; }

     
    }
}
