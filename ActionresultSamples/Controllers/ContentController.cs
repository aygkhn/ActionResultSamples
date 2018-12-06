using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace ActionresultSamples.Controllers
{
    public class ContentController : Controller
    {
        // GET: Content
        public ContentResult Index()
        {
            //return Content("Gokhan");
            //return Content("Gokhan","text/html;charset=utf-8");  (default)
            return Content("Gokhan","text/html",Encoding.UTF8); 
        }
        public ContentResult Index2()
        {
            //return Content("<b>Gokhan</b>");
            return Content("<b>Gokhan</b>", "text/plain");
        }
        public ContentResult Index3()
        {
            //return Content("<products><product><name>Laptop</name><price>10</price></product></products>");
            return Content("<products><product><name>Laptop</name><price>10</price></product></products>","application/xml");
        }
    }
}