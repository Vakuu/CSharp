using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _01_Exam_Schedule
{
    class _01_Exam_Schedule
    {
        static void Main(string[] args)
        {
            string time = Console.ReadLine();
            time += ":" + Console.ReadLine();
            time += " " + Console.ReadLine();
            double hours = double.Parse(Console.ReadLine());
            double minutes = double.Parse(Console.ReadLine());
            string[] formats = { "hh:mm tt", "h:mm tt", "h:m tt", "hh:m tt" };
            DateTime t1;
            if (DateTime.TryParseExact(time, formats, CultureInfo.InvariantCulture, DateTimeStyles.None, out t1))
            {
                t1=t1.AddHours(hours);
                t1=t1.AddMinutes(minutes);
                TimeSpan ts1 = t1.TimeOfDay;
                string output = t1.ToString("hh:mm:tt");
                Console.WriteLine(output);
            }
        }
    }
}
