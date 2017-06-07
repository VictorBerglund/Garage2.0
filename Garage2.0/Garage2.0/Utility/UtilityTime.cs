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
            return String.Format("{0:D2}:{1:D2}:{2:D2}",t.Hours,t.Minutes,t.Seconds);
        }
    }
}