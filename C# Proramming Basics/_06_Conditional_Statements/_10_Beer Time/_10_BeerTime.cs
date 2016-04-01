using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _10_BeerTime
{
    class _10_BeerTime
    {
        static void Main()
        {
            string midnight = "00:00 AM";
            DateTime mt = DateTime.ParseExact(midnight, "hh:mm tt", CultureInfo.InvariantCulture);
            TimeSpan mts = mt.TimeOfDay;
            string midnightlower = "12:59 PM";
            DateTime mtl = DateTime.ParseExact(midnightlower, "hh:mm tt", CultureInfo.InvariantCulture);
            TimeSpan mtsl = mtl.TimeOfDay;
            string time1 = "01:00 PM";
            DateTime t1 = DateTime.ParseExact(time1, "hh:mm tt", CultureInfo.InvariantCulture);
            TimeSpan ts1 = t1.TimeOfDay;
            string time3 = "03:00 AM";
            DateTime t3 = DateTime.ParseExact(time3, "hh:mm tt", CultureInfo.InvariantCulture);
            TimeSpan ts3 = t3.TimeOfDay;
            Console.Write("Enter time in format \"hh:mm tt\": ");
            string timed = Console.ReadLine();
            string[] formats = {"hh:mm tt", "h:mm tt","h:m tt","hh:m tt"};
            DateTime td;
            if (DateTime.TryParseExact(timed, formats, CultureInfo.InvariantCulture, DateTimeStyles.None, out td))
            {
                TimeSpan tsd = td.TimeOfDay;
                Console.WriteLine(tsd);
                if ((ts1 <= tsd) && (tsd >= mtsl) || (ts3 > tsd) && (tsd >= mts))
                {
                    Console.WriteLine("beer time");
                }
                else
                {
                    Console.WriteLine("non-beer time");
                }
            }
            else
            {
                Console.WriteLine("invalid time");
                Console.WriteLine("AGAIN!!!");
                Main();
            }
        }
    }
}
