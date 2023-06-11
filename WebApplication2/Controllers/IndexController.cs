using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2;

namespace WebApplication2.Controllers
{
    public class IndexController : Controller
    {
        // GET: Index
        public ActionResult Index()
        {
            DataRequest u =new DataRequest();
            u.Username = "Customer";
            u.Products=new List<string> { };
            return View(u);
        }
        
    }
}