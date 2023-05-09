using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MiniCopiloto.Controllers
{
    public class MiniCopilotoController : Controller
    {
        // GET: MiniCopiloto
        public ActionResult Index()
        {
            return View();
        }
    }
}