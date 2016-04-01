﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitalism.Execution
{
    using Interfaces;
    public class Command : ICommand
    {
        public Command(string commandString)
        {
            string[] commandParts = commandString.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            this.Name = commandParts[0];
            if (commandParts.Length > 1)
            {
                this.Parameters = commandParts.Skip(1).ToArray();
            }
        }
        public string Name { get; set; }
        public ICollection<string, string> Parameters { get; set; }
    }
}
