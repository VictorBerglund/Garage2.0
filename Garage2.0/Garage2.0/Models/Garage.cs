using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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
        [RegularExpression(@"^[A-Z]{3}[0-9]{3}$",ErrorMessage ="Has to follow naming rule AAA111")]
        [StringLength(6, MinimumLength = 6)]
        [DisplayName("Registration Number")]
        public string RegNr { get; set; }

        [DisplayName("Vehicle")]
        public Vehicles Vehicle { get; set; }

        [DisplayName("Colour")]
        public string Colour { get; set; }

        [RegularExpression(@"[0-9]",ErrorMessage = "Has to be between 0 and 18")]
        [Range(0, 18)]
        [DisplayName("Number of Wheels")]
        public int NbrOfWheels { get; set; }

        [DisplayName("Time When Parked")]
        public DateTime Tid { get; set; }
    }
}