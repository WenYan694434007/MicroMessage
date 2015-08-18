using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Routing;

namespace MVCMonitor
{
    public class RouteTable
    {
        static RouteTable()
        {
            Routes = new RouteCollection();
            Namespaces = new List<string>();
            Assemblies = new List<string>();
        }
        public static RouteCollection Routes { get; private set; }
        public static IList<string> Namespaces { get; private set; }
        public static IList<string> Assemblies { get; private set; }

    }
}