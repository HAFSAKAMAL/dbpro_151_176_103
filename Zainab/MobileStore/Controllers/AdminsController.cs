using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MobileStore;

namespace MobileStore.Controllers
{
    public class AdminsController : Controller
    {
        private DB18Entities db = new DB18Entities();

        // GET: Admins
        public ActionResult Index()
        {
            return View(); //(db.Admins.ToList());
        }

        // GET: Admins/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Admin admin = db.Admins.Find(id);
            if (admin == null)
            {
                return HttpNotFound();
            }
            return View(admin);
        }

        // GET: Admins/Create
        public ActionResult LogIn()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Authorize(MobileStore.Models.Admin user)
        {
            using (DB18Entities db = new DB18Entities())
            {
                Admin UserInput = db.Admins.Where(b => b.Email == user.Email && b.Password == user.Password).FirstOrDefault();
                if (UserInput == null)
                {
                    user.LoginErrorMessage = "Username or Password Doesn't Exist";
                    return View("Index", user);
                    
                }
                else
                {
                    Session["AdminId"] = UserInput.AdminID;
                    // Session["Email"] = UserInput.Email.ToString();
                    // Session["Password"] = UserInput.Password.ToString();
                    return RedirectToAction("LogIn", "Admins");

                }

                

            }

            return View("Index");
        }

        public ActionResult Add_Details()
        {
            return View();
        }

        public ActionResult Mobile_info()
        {
            return View();
        }

        public ActionResult Manufacturer_info()
        {
            return View();
        }
       

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
