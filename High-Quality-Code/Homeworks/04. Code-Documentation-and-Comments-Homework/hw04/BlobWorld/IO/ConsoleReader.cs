namespace BlobWorld.IO
{
    using System;
    using Interfaces;

    public class ConsoleReader : IInputReader
    {   
        /// <summary>
        /// Reads a line
        /// </summary>
        /// <returns></returns>
        public string ReadLine()
        {
            var input = Console.ReadLine();
            return input;
        }
    }
}
