using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitalism.Execution
{
    using Interfaces;
    public class CapitalismEngine : IEngine
    {
        private IUserInterface userInterface;
        private 
        public CapitalismEngine()
        {
            this.userInterface = new ConsoleUserInterface();
        }
        public void run 
        { 
            //TODO
        }
    }
}
