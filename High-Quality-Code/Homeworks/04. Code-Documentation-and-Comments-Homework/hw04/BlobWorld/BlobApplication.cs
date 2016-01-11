using BlobWorld.Enums;

namespace BlobWorld
{
    using Core;
    using IO;
    using System.Collections.Generic;
    using Models;
    class BlobApplication
    {
        static void Main(string[] args)
        {
            //TRY TO ADD "." AFTER () OF AN INSTANCE OR AFTER CREATED OBJECT, OR TO INPUT NEW BUT VALID PARAMETERS TO ENGINE INSTANCE CREATION
            var reader = new ConsoleReader();
            var writer = new ConsoleWriter();
            var data = new Dictionary<string, Blob>();
            
            var engine = new Engine(reader,writer,data);
            engine.Run();
        }
    }
}
