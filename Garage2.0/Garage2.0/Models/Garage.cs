using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        [DisplayName("Registration Number")]
        public string RegNr { get; set; }
        [DisplayName("Vehicle")]
        public Vehicles Vehicle { get; set; }
        [DisplayName("Colour")]
        public string Colour { get; set; }
        [DisplayName("Number of Wheels")]
        public int NbrOfWheels { get; set; }
        [DisplayName("Time When Parked")]
        public DateTime Tid { get; set; }
    }
}