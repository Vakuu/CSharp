using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitalism.UserInterface
{
    public class IWriter
    {
        void Write(string output);
        void WriteLine(string format, params object[] args);
    }
}
