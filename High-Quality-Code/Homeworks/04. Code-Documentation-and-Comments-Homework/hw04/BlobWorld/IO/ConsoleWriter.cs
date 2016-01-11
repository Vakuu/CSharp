namespace BlobWorld.IO
{
    using System;
    using Interfaces;

    public class ConsoleWriter : IOutputWriter
    {
        /// <summary>
        /// Writes a line.
        /// </summary>
        /// <param name="message">Message to be writen</param>
        public void Print(string message)
        {
            Console.WriteLine(message);
        }
    }
}
