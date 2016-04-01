using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_AsynchronousTimer
{
    class Program
    {
        static void Main(string[] args)
        {
            Action action = new Action(Eventing);
            AsyncTimer t = new AsyncTimer(action, 5, 1000);

            t.Run();

            string msg = Console.ReadLine();

            while (!msg.ToLower().Equals("end") && !msg.ToLower().Equals("quit") && !msg.ToLower().Equals("exit"))
            {
                msg = Console.ReadLine();
            }

            t.thread.Join();
        }

        static void Eventing()
        {
            Console.WriteLine("tick");
        }
    }
}
