﻿using BigMani.Core.Interfaces;

namespace BigMani.UI
{
    using System;

    public class ConsoleUserInterface : IUserInterface
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }

        public void WriteLine(string message)
        {
            Console.WriteLine(message);
        }
    }
}