using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication1.Filters;
using MvcApplication1.Models;

namespace MvcApplication1.Controllers
{
    public class UserController : Controller
    {
        //
        // GET: /User/
        [LoginActionFilter(LogMessage = "日志写入：Validation方法")]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.UserName == "yanwen" & model.Password == "123456")
                    Response.Write("正确");
                else
                {
                    Response.Write("错误");
                }

            }
            return View();
        }

        public ActionResult UserDetail()
        {
            UserModel userModel = new UserModel();
            userModel.UserName = "用户名";
            userModel.Password = "密码";
            userModel.Sex = 0;
            userModel.Age = 30;
            userModel.Height = 170;
            userModel.Weight = 70;
            userModel.Graduated = "毕业院校";
            return View(userModel);
        }

        [HttpPost]//UserEdit
        public ActionResult UserDetail(UserModel userModel)
        {

            return View(userModel);
        }


        public ActionResult UserList(int id = 1)
        {
            int pageSize = 0;
            if (ConfigurationManager.AppSettings["PageSize"] != null)
            {
                pageSize = int.Parse(ConfigurationManager.AppSettings["PageSize"]);
            }
            List<RegeditModel> source = new List<RegeditModel>
            {
                new RegeditModel {Password = "123456", Age = 10, Sex = 0, UserName = "yanwen1"},
                new RegeditModel {Password = "123", Age = 10, Sex = 0, UserName = "yanwen2"},
                new RegeditModel {Password = "123456", Age = 10, Sex = 0, UserName = "yanwen3"},
                new RegeditModel {Password = "123456", Age = 10, Sex = 0, UserName = "yanwen4"},
                new RegeditModel {Password = "123456", Age = 10, Sex = 0, UserName = "yanwen5"},
                new RegeditModel {Password = "123456", Age = 10, Sex = 0, UserName = "yanwen6"},
                new RegeditModel {Password = "123456", Age = 10, Sex = 0, UserName = "yanwen7"},
                new RegeditModel {Password = "123456", Age = 10, Sex = 0, UserName = "yanwen8"},
                new RegeditModel {Password = "123456", Age = 10, Sex = 0, UserName = "yanwen9"},
                new RegeditModel {Password = "123456", Age = 10, Sex = 0, UserName = "yanwen10"},
            };
            PageModel<RegeditModel> pageModel = new PageModel<RegeditModel>(pageSize,10, source.Skip((id - 1)*pageSize).Take(pageSize));
            pageModel.PageIndex = id;
            return View(pageModel);
        }


    }
}
