using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace ActionresultSamples.Controllers
{
    public class HttpController : Controller
    {
        // GET: http
        public HttpStatusCodeResult Index()
        {
           // return new HttpStatusCodeResult(HttpStatusCode.BadGateway);
           // return new HttpStatusCodeResult(HttpStatusCode.BadGateway, "Bad gateway from Mvc");
            return new HttpStatusCodeResult(502);
        }
        public HttpUnauthorizedResult Index2()
        {
           // return new HttpUnauthorizedResult();
            return new HttpUnauthorizedResult("Not Authenticate");
        }
        public HttpNotFoundResult Index3()
        {
            //return HttpNotFound();
            return HttpNotFound("Sayfa Bulunamadi.");
            return new HttpNotFoundResult();
        }
    }
}