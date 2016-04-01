namespace BigMani.Core
{
    using System;

    using Controllers;
    using Models;
    using Interfaces;

    class AirConditionerTestingEngine : IEngine
    {
        public CommandProcessor ac;

        public IUserInterface ui;

        public CommandChecker magic;

        public AirConditionerTestingEngine(IUserInterface userInterface)
        {
            this.ac = new CommandProcessor(this);
            this.ui = userInterface;
        }


        public void Run()
        {
            while (true)
            {
                string line = this.ui.ReadLine();
                if (string.IsNullOrWhiteSpace(line))
                {
                    break;
                }

                line = line.Trim();
                try
                {
                    magic = new CommandChecker(line);
                    this.ac.DoMagic();
                }
                catch (InvalidOperationException ex)
                {
                    this.ui.WriteLine(ex.Message);
                }
            }
        }

        public string Status()
        {
            int reports = MyStuff.GetReportsCount();
            double airConditioners = MyStuff.GetAirConditionersCount();

            double percent = reports / airConditioners;
            percent = percent * 100;
            return string.Format(OutputMessages.STATUS, percent);
        }

        public void ValidateParametersCount(CommandChecker command, int count)
        {
            if (command.Parameters.Length != count)
            {
                throw new InvalidOperationException(OutputMessages.INVALIDCOMMAND);
            }
        }
    }
}
