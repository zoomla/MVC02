using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Management;
using System.Web.Mvc;
using MVC0626.Models;

namespace MVC0626.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "早上好" : "下午好";
            return View();
        }

        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult RsvpForm(Dance dance)
        {
            if (ModelState.IsValid)
            {
                //给晚会组织者发送电子邮件
                return View("Thanks", dance);
            }
            else
            {
                //验证错误响应
                return View();
            }

            //TODO:对晚会的组织者发送Email响应
            //return View("Thanks", dance);
        }
    }
}