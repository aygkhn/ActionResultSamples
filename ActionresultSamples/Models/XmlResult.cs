using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Serialization;

namespace ActionresultSamples.Models
{
    public class XmlResult : ActionResult
    {
        private readonly object _data;
        public XmlResult(object data)
        {
            _data = data;
        }
        public override void ExecuteResult(ControllerContext context)
        {
            if(_data!=null)
            {
                var xs = new XmlSerializer(_data.GetType());
                context.HttpContext.Response.ContentType = "application/xml";
                xs.Serialize(context.HttpContext.Response.Output, _data);
            }
        }
    }
}