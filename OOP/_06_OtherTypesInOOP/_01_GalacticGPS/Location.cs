using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_GalacticGPS
{
    using Enumerations;
    struct Location
    {
        private double latitude;
        private double longitude;
        private Planet planet;
        public double Latitude
        {
            get
            {
                return this.latitude;
            }

            private set
            {
                if (value < -90 || value > 90)
                {
                    throw new ArgumentOutOfRangeException("Latitude is between -90 and 90.");
                }
                this.latitude = value;
            }
        }
        public double Longitude
        {
            get
            {
                return this.longitude;
            }

            private set
            {
                if (value < -180 || value > 180)
                {
                    throw new ArgumentOutOfRangeException("Latitude is between -180 and 180.");
                }
                this.longitude = value;
            }
        }
        public Planet Planet
        {
            get
            {
                return this.planet;
            }
        }
        public Location(double latitude, double longitude, Planet planet)
            : this()
        {
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.planet = planet;
        }
        public override string ToString()
        {
            return string.Format("{0}, {1} - {2}",
                this.Latitude, this.Longitude, this.Planet);
        }
    }
}
