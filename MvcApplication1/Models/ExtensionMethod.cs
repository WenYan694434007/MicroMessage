using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public static class ExtensionMethod
    {
        public static string GetStandardTime(this DateTime date)
        {
            return date.ToString("yyyy-MM-dd");
        }
    }
}