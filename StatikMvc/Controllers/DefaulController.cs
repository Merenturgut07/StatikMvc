using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StatikMvc.Controllers
{
    public class DefaulController : Controller
    {
        // GET: Defaul
        public ActionResult Index()
        {
            return View();
        }
    }
}