using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigMani.Data
{
    class RegisteredAirConditioners : IRegisteredAirConditioners
    {
        public IDictionary<string, string> models { get; private set; }

        public RegisteredAirConditioners()
        {
            
        }
    }
}
