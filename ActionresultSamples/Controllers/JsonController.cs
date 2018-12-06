using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ActionresultSamples.Models;
namespace ActionresultSamples.Controllers
{
    public class JsonController : Controller
    {
        // GET: Json
        public JsonResult Index()
        {
            var products = new List<Product>
            {
                new Product
                {
                    Name ="Laptop",
                    UnitPrice =10
                },
                new Product
                {
                    Name ="Mouse",
                    UnitPrice =3
                }
            };
            return Json(products,JsonRequestBehavior.AllowGet);
            //return Json(products,"application/json",System.Text.Encoding.UTF8,JsonRequestBehavior.AllowGet);
        }
    }
}