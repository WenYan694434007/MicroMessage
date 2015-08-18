using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using MvcApplication1.Validation;

namespace MvcApplication1.Models
{
    public class UserModel
    {
        public int UserID { get; set; }                 //用户编号
        public string UserName { get; set; }            //用户名
        public string Password { get; set; }            //密码
        public int Sex { get; set; }                    //性别，0男，1女
        public int Age { get; set; }                    //年龄
        public int Political { get; set; }              //政治面貌
        public int Height { get; set; }                 //身高
        public int Weight { get; set; }                 //体重
        public string Graduated { get; set; }           //毕业院校
        public string Professional { get; set; }        //专业
        public DateTime GraduatedDate { get; set; }         //毕业日期
        public string Address { get; set; }             //现住地址
        public string Phone { get; set; }               //联系电话
        public string ImagePath { get; set; }           //头相地址
        public string Other { get; set; }               //其他描述
    }

    public class LoginModel
    {
        [Display(Name = "用户名"),
        Required(ErrorMessage = "请输入{0}"),
        StringLength(20, ErrorMessage = "{0}在{2}位至{1}位之间", MinimumLength = 1),RegularExpression(@"^[0-5]*$",ErrorMessage = "只能输入0-5间的数字")]
        public string UserName { get; set; }            //用户名
        [Display(Name = "密码"),
        Required(ErrorMessage = "请输入{0}"),
        StringLength(20, ErrorMessage = "{0}在{2}位至{1}位之间", MinimumLength = 1),SpecialValidation]
        public string Password { get; set; }            //密码
    }

    public class RegeditModel
    {
        public string UserName { get; set; }            //用户名
        public string Password { get; set; }            //密码
        public int Sex { get; set; }                    //性别
        public int Age { get; set; }                    //年龄
    }

}