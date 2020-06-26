using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC0626.Models
{
    public class Dance
    {
        [Required(ErrorMessage ="请输入你的姓名")]
        public string Name { get; set; }

        [Required(ErrorMessage ="请输入合法的电子邮件")]
        [RegularExpression(".+\\@.+\\..+",ErrorMessage ="请输入合法的电子邮件地址")]
        public string Email { get; set; }

        [Required(ErrorMessage ="请输入你的电话号码")]
        [RegularExpression("^1[0-9]{10}$", ErrorMessage ="手机号码必须是11位")]
        public string Phone { get; set; }

        [Required(ErrorMessage ="请选择一个选项")]
        public bool? WillAttend { get; set; }
    }
}