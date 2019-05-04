using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Example.Models;
using System.IO;
using System.Web.Services.Description;
using CrystalDecisions.CrystalReports.Engine;
using System.Data.Entity.Infrastructure;

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


        public ActionResult report()
        {
            ReportDocument rd = new ReportDocument();
            rd.Load(Path.Combine(Server.MapPath("~/Report"), "CrystalReport.rpt"));
            rd.SetDataSource(db.Features.ToList());
            Response.Buffer = false;
            Response.ClearContent();
            Response.ClearHeaders();
            try
            {
                Stream str = rd.ExportToStream(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat);
                str.Seek(0, SeekOrigin.Begin);
                return File(str, "application/pdf", "Feature_list.pdf");

            }
            catch
            {
                throw;

            }


        }

        public ActionResult latestmobile()
        {
            ReportDocument rd = new ReportDocument();
            rd.Load(Path.Combine(Server.MapPath("~/Report"), "latestMobile.rpt"));
            rd.SetDataSource(db.latest_Mobile().ToList());
            Response.Buffer = false;
            Response.ClearContent();
            Response.ClearHeaders();
            try
            {
                Stream str = rd.ExportToStream(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat);
                str.Seek(0, SeekOrigin.Begin);
                return File(str, "application/pdf", "Latest_Mobiles.pdf");

            }
            catch
            {
                throw;

            }

        }

        public ActionResult Logout()
        {
            int userid = (int)Session["AdminId"];
            Session.Abandon();
            return RedirectToAction("LogIn", "Admins");
        }

        public ActionResult Details(int? id)
        {
            var f = db.Features.SingleOrDefault(c => c.ModelID == id);
            return View(f);
        }

    }
}
