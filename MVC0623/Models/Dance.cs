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

        public string Email { get; set; }
        public string Phone { get; set; }
        public bool? WillAttend { get; set; }


    }
}
