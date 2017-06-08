using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Garage2._0.Models
{
    public class StatisticsViewModel
    {
        [DisplayName("Vehicles")]
        public IEnumerable<Garage> vehicles { get; set; }

        [DisplayName("Total Number of Wheels")]
        public int NbrOfWheels { get; set; }

        [DisplayName("Price for All Vehicles")]
        public int Price { get; set; }
    }
}