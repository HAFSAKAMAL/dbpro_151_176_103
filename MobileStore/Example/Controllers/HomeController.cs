using Example.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Configuration;

namespace MobileStore.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.saveresult = "";
            return View();
        }

        public ActionResult RetriveImage()
        {
            DB18Entities1 db = new DB18Entities1();
            var item = (from d in db.Images
                        select d).ToList();
            return View(item);
        }


        public ActionResult News_(Display_news dr)
        {
            string mainConn = @"Data Source= (local); Initial Catalog= DB18; Integrated Security= True;";
            SqlConnection conn = new SqlConnection(mainConn);
            string s1 = "select * from [dbo].[News]";
            SqlCommand sqlcom = new SqlCommand(s1);
            sqlcom.Connection = conn;
            conn.Open();
            SqlDataReader sdr = sqlcom.ExecuteReader();
            List<Display_news> objmodel = new List<Display_news>();
            if(sdr.HasRows)
            {
                while(sdr.Read())
                {
                    var details = new Display_news();
                    details.Details = sdr["Details"].ToString();
                    objmodel.Add(details);
                }
                dr.News_Details = objmodel;
                conn.Close();
            }
              


            return View("News_", dr);

        }

        [HttpGet]
        public ActionResult Contact()
        {
           
            return View();
        }

        [HttpPost]
        public ActionResult Contact(Feedback_Model f)
        {
            using (DB18Entities1 db = new DB18Entities1())
            {
                FeedBack fb = new FeedBack();
                fb.Name = f.Name;
                fb.Email = f.Email;
                fb.Message = f.Message;
                db.FeedBacks.Add(fb);
                db.SaveChanges();


                ViewBag.saveresult = "saved";
                ModelState.Clear();

            }

                return View(new Feedback_Model());
        }

        public ActionResult Outlet()
        {
            return View();
        }

        public ActionResult Reviews()
        {
            return View();
        }

    }
}