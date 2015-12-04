using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public struct Location
    {
        private double latitude;
        private double longitude;
        private Planet planet;

        public Planet Planet { get; set; }

        public double Latituted
        {
            get { return this.latitude; }
            set
            {
                if (value < -90 || value > 90)
                {
                    throw new ArgumentOutOfRangeException("Latitudes can be in range from -90 to 90.");
                }
                this.latitude = value;
            }
        }

        public double Longitude
        {
            get { return this.longitude; }
            set
            {
                if (value < -180 || value > 180)
                {
                    throw new ArgumentOutOfRangeException("Longitudes can be in range from -90 to 90.");
                }
                this.longitude = value;
            }
        }

        public Location(double latitude, double longitude, Planet planet) : this()
        {
            this.Latituted = latitude;
            this.Longitude = longitude;
            this.Planet = planet;
        }

        public override string ToString()
        {
            return string.Format("{0}, {1} - {2}",
                this.latitude,
                this.longitude,
                this.Planet);
        }
    }
}
