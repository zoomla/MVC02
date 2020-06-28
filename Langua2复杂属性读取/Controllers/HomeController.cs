using Langua2复杂属性读取.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Langua2复杂属性读取.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public string Index()
        {
            return "跳到一个例子的URL";
        }

        public ViewResult AutoProperty()
        {
            //创建一个新的Product对象
            Product myProduct = new Product();

            //设置属性
            myProduct.Name = "kayak";

            //读取属性
            string productName = myProduct.Name;

            //生成视图
            return View("Result", (object)string.Format("Product name: {0}", productName));
        }
    }
}