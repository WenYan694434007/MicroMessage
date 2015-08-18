using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication1.CommonControl;

namespace MvcApplication1.Controllers
{
    public class ValidateController : Controller
    {
        //
        // GET: /Validate/

        public ActionResult GetValidateCode()
        {
            CreateValidateCode c= new CreateValidateCode();
            var code = c.CreateCode();
            Session["validateCode"] = code;
            var bytes = c.CreateImage(code);
            return File(bytes, @"image/jpeg");
        }

        public ActionResult GetTime()
        {
            return Content(DateTime.Now.ToString());
        }

    }
}
