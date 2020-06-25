using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MVC0623.Controllers
{
    public class AboutController : Controller
    {
        //public IActionResult Index()
        //public string index()
        public ViewResult index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.zoomla = hour < 12 ? "早上好" : "下午好";
            return View();
            //return "你好，aobut页面";
        }
    }
}