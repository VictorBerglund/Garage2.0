using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Garage2._0.DataAccessLayer
{
    public class GarageContext : DbContext
    {
        public GarageContext(): base()
        {    
          
        }

        public DbSet<Models.Garage> Garage { get; set; }
    }
}