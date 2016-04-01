namespace _01_GalacticGPS
{
    using System;
    using Enumerations;
    class Program
    {
        static void Main()
        {
            //Location home = new Location(18.037986, 28.870097, Planet.Earth);
            //Location mars = new Location(18.037986, 28.870097, Planet.Mars);
            //Console.WriteLine(home);
            //Console.WriteLine(mars);
            try
            {
                Location home = new Location(18.037986, 29.870097, Planet.Earth);

                Console.WriteLine(home);

                Location jupiter = new Location(62.436253, 26.356235, Planet.Jupiter);

                Console.WriteLine(jupiter);

                Location outOfRange = new Location(152.512552, -200.421553, Planet.Saturn);

                Console.WriteLine(outOfRange);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
