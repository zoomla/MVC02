using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Langua2复杂属性读取.Models
{
    public class Product { 
    private string name;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    }
}