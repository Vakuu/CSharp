namespace Events
{
    using System;

    public class EventMain
    {
        public static void Main()
        {
            //Console.WriteLine("Enter a template:" + Environment.NewLine);
            while (CommandExecutor.ExecuteNextCommand())
            {
            }

            Console.Write(Messages.Output);
        }
    }
}