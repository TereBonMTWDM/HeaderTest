using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ApiService.Controllers
{
    public class Students : Controller
    {
        public ActionResult Index()
        {
            return View ();
        }
    }
}
