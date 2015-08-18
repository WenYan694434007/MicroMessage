using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class LayoutController : Controller
    {
        //
        // GET: /Layout/

        public ActionResult Layout1()
       {
           ViewBag.Title = "布局页一";
           return View();
       }

        //LayoutDemo_02
        public ActionResult Layout2()
        {
            ViewBag.Title = "布局页二";
            return View();
        }

        public ActionResult Layout3()
        {
            ViewBag.Title = "布局页二";
            return View();
        }

    }
}
