using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ActionresultSamples.Controllers
{
    public class EmptyController : Controller
    {
        // GET: Empty
        public void Index()
        {
        }
        public ActionResult Index2()
        {
            return null;
        }
        public ActionResult Index3()
        {
            if (!User.Identity.IsAuthenticated)
                return new EmptyResult();
            return Content("Already Logged");
        }
    }
}