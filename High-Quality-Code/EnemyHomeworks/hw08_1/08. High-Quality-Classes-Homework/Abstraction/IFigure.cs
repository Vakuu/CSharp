using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public interface IFigure
    {
        double Width { get; }

        double Height { get; }

        double Radius { get; }

        double CalcPerimeter();

        double CalcSurface();
    }
}
