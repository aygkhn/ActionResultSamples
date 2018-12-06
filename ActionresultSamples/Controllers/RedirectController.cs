using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ActionresultSamples.Controllers
{
    [RoutePrefix("Default")]
    public class RedirectController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        // GET: Redirect
        public RedirectResult Index2()
        {
            //return Redirect("~/view");
            return Redirect("http://google.com.tr");
        }
        public RedirectToRouteResult Index3()
        {
            RouteValueDictionary r = new RouteValueDictionary(){  } ;
            //return RedirectToAction("Index");
            //return RedirectToAction("Index","View");
            // return RedirectToAction("Index", new { controller = "view", id = 5 });
            //return RedirectToAction("Index", new System.Web.Routing.RouteValueDictionary()
            //{
            //    {"controller","View" },
            //    {"id","6" }
            //});
            //return RedirectToRoute("Default",new { controller="View",action="Index2" });
            return RedirectToRoute("Blog", new { controller = "Archive", action = "Entry" });
        }
    }
}