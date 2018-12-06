using ActionresultSamples.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ActionresultSamples.Controllers
{
    public class CustomController : Controller
    {
        // GET: Custom
        public CustomResult Index()
        {
            return new CustomResult();
        }
        public XmlResult Index2()
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
            return new XmlResult(products);
        }
    }
}