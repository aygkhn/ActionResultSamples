using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ActionresultSamples.Controllers
{
    public class JavaScriptController : Controller
    {
        // GET: JavaScript
        public ActionResult Index()
        {
            return View();
        }
        public JavaScriptResult Alert()
        {
            return JavaScript("alert('Hello World')");
        }
        public ContentResult Alert2()
        {
            return Content("<script>alert('Hello World Content')</script>");
        }
    }
}