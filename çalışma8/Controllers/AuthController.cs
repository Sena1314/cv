using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace çalışma8.Controllers
{
    public class AuthController : Controller
    {
        // GET: Auth
        public ActionResult login()
        {
            return View();
        }
    }
}