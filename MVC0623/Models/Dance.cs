using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC0623.Models
{
    public class Dance
    {
        [Required(ErrorMessage = "请输入你的姓名")]
        public string Name { get; set; }

        [Required(ErrorMessage ="请输入合法的邮件地址")]
        [RegularExpression(".+\\@.+\\..+",ErrorMessage ="请输入合法的邮件地址")]
        public string Email { get; set; }

        [Required(ErrorMessage ="请录入你的手机号码")]
        public string Phone { get; set; }

        [Required(ErrorMessage ="请输入你的将要参加会议的选项")]
        public bool? WillAttend { get; set; }
    }
}
