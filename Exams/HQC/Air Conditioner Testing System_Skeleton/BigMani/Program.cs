
using BigMani.UI;

namespace BigMani
{
    using Core;
    using System.Collections.Generic;
    using Models;

    public class Program
    {
        public static void Main()
        {
            var engine = new AirConditionerTestingEngine(new ConsoleUserInterface());
            engine.Run();
        }
    }
}
