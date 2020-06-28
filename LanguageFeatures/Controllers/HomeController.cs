using LanguageFeatures.Models;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public string Index()
        {
            return "Navigate to a url to show an example 导航到一个网址以显示示例";
        }

        public ViewResult AutoProperty()
        {
            //创建一个新的Product对象
            Product myProduct = new Product();

            //设置属性值 
            myProduct.Name = "发哥";

            //读取属性
            string productName = myProduct.Name;

            //生成视图
            return View("Result",
                (object)string.Format("Product name:{0}", productName));
        }
    }
}