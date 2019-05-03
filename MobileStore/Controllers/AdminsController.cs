using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Example.Models;

namespace Example.Controllers
{
    public class AdminsController : Controller
    {
        private DB18Entities1 db = new DB18Entities1();

        // GET: Admins
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult LogIn()
        {
            return View(); //(db.Admins.ToList());
        }

        [HttpPost]
        public ActionResult Authorize(Example.Models.Admin user)
        {
            using (DB18Entities1 db = new DB18Entities1())
            {
                var UserInput = db.Admins.Where(b => b.Email == user.Email && b.Password == user.Password).FirstOrDefault();
                if (UserInput == null)
                {
                    user.LoginErrorMessage = "Username or Password Doesn't Exist";
                    return View("Index", user);

                }
                else
                {
                    //  session is a state that is used to store and retrieve values of a user.
                    //  Session["AdminId"] = UserInput.AdminID;
                    Session["Email"] = UserInput.Email.ToString();
                    Session["Password"] = UserInput.Password.ToString();
                    return RedirectToAction("Insert_info", "SaveData");

                }
            }
        }

        public ActionResult Logout()
        {
            int userid = (int)Session["AdminId"];
            Session.Abandon();
            return RedirectToAction("LogIn", "Admins");
        }

    }
}
