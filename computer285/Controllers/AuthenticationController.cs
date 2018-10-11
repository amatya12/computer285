using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;
using computer285.Helpers;
using computer285.Models;  

namespace computer285.Controllers
{
    public class AuthenticationController : Controller
    {
        // GET: Authentication
        Authentication Authentication = new Authentication();
        public OurDbContext _dbContext = new OurDbContext();

        public ActionResult Register()
        {
            return View();
        }

       

        [HttpPost]
        public ActionResult Register(User user)
        {
            if (ModelState.IsValid)
            {
                var userNameExists = _dbContext.User.SingleOrDefault(u => u.Username == user.Username);
                if (userNameExists == null)
                {
                    // created new model
                    user.Password = Authentication.Hash(user.Password);
                    _dbContext.User.Add(user);
                    _dbContext.SaveChanges();
                    ModelState.Clear();
                    ViewBag.Message = user.FirstName + " " + user.LastName + " is successfully added.";

                    //return to home index after register
                }
                else
                {
                    ViewBag.Message = "Username already exists.";
                    return View("Register");
                }
            }

            return View();
        }


        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(User user)
        {
            //var usr = _dbContext.User.SingleOrDefault(u => u.Username == user.Username && Authentication.Hash(user.Password) == user.Password);

            var userInDb = _dbContext.User.SingleOrDefault(u => u.Username == user.Username);
            if (userInDb == null)
            {
                ModelState.AddModelError("", "Username does not exist");
                return View();
            }
            if(userInDb.Password == Authentication.Hash(user.Password))
            {
                Session["Id"] = userInDb.Id.ToString();
                Session["Username"] = userInDb.Username.ToString();
                Session["Role"] = userInDb.Role;
                return RedirectToAction("LoggedIn");
            }

            ModelState.AddModelError("", "Incorrect Login credentials. Try Again!!");
            
            return View();
        }
       

        public ActionResult LoggedIn()
        {
            if (Session["Id"] != null)
            {
                return   View();
            }
            else
            {
              return  RedirectToAction("Login");
            }
            
        }

        public ActionResult Signout()
        {
            Session.Clear();
            // return View("Login");
            return RedirectToAction("Login");
            
        }
    }
}