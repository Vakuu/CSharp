using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    interface ICircle : IFigureOperations
    {
        double Radius { get; set; }
    }
}
