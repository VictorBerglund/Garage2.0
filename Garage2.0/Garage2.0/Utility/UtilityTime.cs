using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Garage2._0.Utility
{
    public class UtilityTime
    {
        static public string TimeFix(TimeSpan t)
        {
            return String.Format("{0:D2}h {1:D2}min {2:D2}sec",t.Hours,t.Minutes,t.Seconds);
        }
    }
}