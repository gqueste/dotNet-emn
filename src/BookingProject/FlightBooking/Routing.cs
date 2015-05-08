using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlightBooking
{
    public static class Routing
    {

        public static String BASEPATH = "~/Models";

        public static String EXT = ".aspx";

        public static String ROOT = "/";


        public static String path(String viewName)
        {
            if (String.IsNullOrWhiteSpace(viewName) || viewName.Replace("~", "").Equals("/"))
            {
                return ROOT;
            }
            else if (viewName.Equals("default", StringComparison.InvariantCultureIgnoreCase) || viewName.EndsWith("default.aspx"))
            {
                return ROOT;
            }
            else 
            {
                return BASEPATH + (viewName.StartsWith("/") ? "" : "/") + viewName + (viewName.StartsWith(EXT) ? "" : EXT);
            }
        }
        

    }
}