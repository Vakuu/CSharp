using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _01_DifferenceBetweenDates
{
    class _01_DifferenceBetweenDates
    {
        static void Main(string[] args)
        {
            Console.Write("Enter date in format \"dd.MM.yyyy\": ");
            string date1 = Console.ReadLine();
            string[] formats = {"dd.MM.yyyy"};
            DateTime td1;
            if (DateTime.TryParseExact(date1, formats, CultureInfo.InvariantCulture, DateTimeStyles.None, out td1))
            {
                Console.Write("Enter date in format \"dd.MM.yyyy\": ");
                string date2 = Console.ReadLine();
                DateTime td2;
                if (DateTime.TryParseExact(date2, formats, CultureInfo.InvariantCulture, DateTimeStyles.None, out td2))
                {
                    if (td1 > td2)
                    {
                        int diff = (td1 - td2).Days;
                        Console.WriteLine(diff);
                    }
                    else
                    {
                        int diff = (td2 - td1).Days;
                        Console.WriteLine(diff);
                    }
                }
            }
        }
    }
}