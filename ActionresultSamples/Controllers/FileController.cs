using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ActionresultSamples.Controllers
{
    public class FileController : Controller
    {
        // GET: File
        public FileResult Index()
        {
            //return File("~/Content/deneme.txt", "application/text");
            //return File("~/Content/deneme.txt", "application/text","deneme.txt");
            return new FilePathResult("~/Content/deneme.txt", "application/text") { FileDownloadName="denedim.txt"};
        }
        public FileContentResult Index2()
        {
            return File(System.IO.File.ReadAllBytes(Server.MapPath("~/Content/deneme.txt")), "text/plain");
        }
        public ActionResult Index3()
        {
            var file = new FileStream(Server.MapPath("~/Content/deneme.txt"),FileMode.Open);
            return File(file,"deneme.txt");
        }
    }
}