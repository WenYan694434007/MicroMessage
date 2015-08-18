using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace Core.Models
{

    public class Product
    {
        public int Id { get; set; }
         [Display(Name = "用户名"),
        Required(ErrorMessage = "请输入{0}"),
        StringLength(20, ErrorMessage = "{0}在{2}位至{1}位之间", MinimumLength = 1), RegularExpression(@"^[0-5]*$", ErrorMessage = "只能输入0-5间的数字")]
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }

    }

}
