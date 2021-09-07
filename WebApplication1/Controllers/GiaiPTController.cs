using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class GiaiPTController : Controller
    {
        // GET: GiaiPT
        public ActionResult GiaiPT()
        {
            return View();
        }

        [HttpPost]
        public ActionResult GiaiPT(string SoA, string SoB)
        {
            double so1 = Convert.ToDouble(SoA);
            double so2 = Convert.ToDouble(SoB);
            double ketqua = -so2 / so1;
            ViewBag.GPT = ketqua;
            return View();
        }
    }
}