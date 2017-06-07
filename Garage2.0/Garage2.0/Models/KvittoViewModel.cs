using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Garage2._0.Models
{
    public class KvittoViewModel 
    {
        [DisplayName("Registration Number")]
        public string RegNum { get; set; }

        [DisplayName("Vehicle")]
        public Vehicles vehicle { get; set; }

        [DisplayName("Time When Parked")]
        public DateTime ParkTime { get; set; }

        [DisplayName("Check Out Time")]
        public string CheckOutTime { get; set; }

        [DisplayName("Total Time Parked")]
        public string totParkTime { get; set; }

        [DisplayName("Price")]
        public int Price { get; set; }
    }
}