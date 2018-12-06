using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ActionresultSamples.Controllers
{
    public class ArchiveController : Controller
    {
        // GET: Archive
        [NonAction]
        public string Entry(DateTime? date)
        {
            return date.ToString();
        }
        public string Entry()
        {
            return "a";
        }
    }
}