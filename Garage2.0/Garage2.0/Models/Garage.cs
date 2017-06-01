using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Garage2._0.Models
{
    public enum Vehicles
    {
        Car,
        Airplane,
        Motorcycle,
        Boat
    }

    public class Garage
    {
        public int Id { get; set; }
        public string RegNr { get; set; }
        public Vehicles Vehicle { get; set; }
        public string Colour { get; set; }
        public int NbrOfWheels { get; set; }
        public DateTime Tid { get; set; }
    }
}