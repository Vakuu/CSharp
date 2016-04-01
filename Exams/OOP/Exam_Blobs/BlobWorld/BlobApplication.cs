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
            var reader = new ConsoleReader();
            var writer = new ConsoleWriter();
            var data = new Dictionary<string, Blob>();

            var engine = new Engine(reader, writer, data);
            engine.Run();
        }
    }
}
