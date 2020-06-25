using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC0623.Models;

namespace MVC0623.Controllers
{
    public class DanceController : Controller
    {
        /// <summary>
        /// 跳舞应用
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }
        [HttpPost]
        public ViewResult RsvbForm(Dance guestResponse)
        {
            //对晚会的组织者发送Email响应
            return View("Thanks", guestResponse);
        }
    }
}