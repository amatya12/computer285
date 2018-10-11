using computer285.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace computer285.Controllers
{
    public class BaseController : Controller
    {
        protected Boolean IsAdmin()
        {
            return Session["Role"] != null && ((Role)Session["Role"] == Role.ADMIN);

        }

        protected Boolean IsLoggedIn()
        {
            return Session["Id"] != null;
        }


        protected ActionResult Unauthorized()
        {
            return new HttpStatusCodeResult(HttpStatusCode.Unauthorized);
        }

        

        protected ActionResult UnauthorizedOrSendToLoginPage()
        {
            if (IsLoggedIn())
            {
                return Unauthorized();
            }else
            {
               return  RedirectToAction("Login");
            }
        }
    }
}