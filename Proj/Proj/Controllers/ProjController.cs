using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proj.Controllers
{
    public class ProjController : Controller
    {
        // GET: Proj
        public ActionResult Index()
        {
            return View();
        }
    }
}