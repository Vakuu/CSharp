using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    interface IRectancle : IFigureOperations
    {
         double Width { get; set; }
         double Height { get; set; }
    }

}
