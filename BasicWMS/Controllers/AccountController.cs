using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BasicWMS.ViewModels;

namespace BasicWMS.Controllers
{
    public class AccountController : Controller
    {
        //
        // GET: /Account/

        public ActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        // Get 
        public ActionResult Register()
        {
            return View("Register", new RegisterViewModel());
        }

    }
}
