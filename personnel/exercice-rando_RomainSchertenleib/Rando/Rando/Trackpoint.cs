using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rando
{
    class Trackpoint
    {
        public double Latitude { get; private set; }
        public double Longitude { get; private set; }
        public double Elevation { get; private set; }
        public Trackpoint(double latitude, double longitude, double elevation)
        {
            Latitude = latitude;
            Longitude = longitude;
            Elevation = elevation;
        }
        public override string ToString()
        {
            return $"Lat: {Latitude}, Lon: {Longitude}, Ele: {Elevation}";
        }
    }
}