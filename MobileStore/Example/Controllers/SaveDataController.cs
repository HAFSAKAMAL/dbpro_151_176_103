using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Example.Models;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace Example.Controllers
{
    public class SaveDataController : Controller
    {
        public static int id;
        // DB18Entities db = new DB18Entities();
        // ApplicationDbContext db = new ApplicationDbContext();
        // GET: SaveData


        public ActionResult Index()
        {
            //  List<Manufacturer> m_list = db.Manufacturers.ToList();

            ViewBag.saveresult = "";
            return View();
        }

        public ActionResult AddImage()
        {
            Image b = new Image();
            return View(b);
        }

        [HttpPost]
        public ActionResult AddImage(Image model, HttpPostedFileBase image1, HttpPostedFileBase image2, HttpPostedFileBase image3)
        {
            model.ModelID = id;
            var db = new DB18Entities1();
      

            if (image1 != null)
            {
                model.Front = new byte[image1.ContentLength];
                image1.InputStream.Read(model.Front, 0, image1.ContentLength);

            }
            if (image2 != null)
            {
                model.Back = new byte[image2.ContentLength];
                image2.InputStream.Read(model.Back, 0, image2.ContentLength);

            }
            if (image3 != null)
            {
                model.Side = new byte[image3.ContentLength];
                image3.InputStream.Read(model.Side, 0, image3.ContentLength);

            }



            db.Images.Add(model);
            db.SaveChanges();
            return View(model);
        }




        [HttpGet]
        public ActionResult Insert_News()
        {
            return View();
                
        }

        [HttpPost]
        public ActionResult Insert_News(News_Add n)
        {
            using (DB18Entities1 db = new DB18Entities1())
            {
                News nw = new News();
                nw.Details = n.Details;
                db.News.Add(nw);
                db.SaveChanges();

                ViewBag.saveresult = "saved";
                ModelState.Clear();
            }
                return View(new News_Add());

        }

        [HttpGet]
        public ActionResult Insert_info()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Insert_info(Mobile_info m)
        {
            using (DB18Entities1 db = new DB18Entities1())
            {
                Manufacturer mn = new Manufacturer();
                mn.Name = m.Name;
                mn.Country = m.Country;
                db.Manufacturers.Add(mn);
                db.SaveChanges();

                Series s = new Series();
                s.Name = m.S_Name;
                s.ManufacturerID = mn.ManufacturerID;
                db.Series.Add(s);
                db.SaveChanges();

                Model md = new Model();
                md.Name = m.M_Name;
                md.SeriesID = s.SeriesID;
                md.Launch_Date = m.Launch_Date;
                md.Price = m.Price;
                db.Models.Add(md);
                db.SaveChanges();

                id = md.ModelID;
                Feature f = new Feature();
                f.ModelID = md.ModelID;
                f.Network = m.Network;
                f.Front_Cam = m.Front_Cam;
                f.Back_Cam = m.Back_Cam;
                f.Sim = m.Sim;
                f.Ram = m.Ram;
                f.Operating_System = m.Operating_System;
                f.Screen_Size = m.Screen_Size;
                f.Frequency = m.Frequency;
                f.Bettery = m.Bettery;
                f.Color = m.Color;
                db.Features.Add(f);
                db.SaveChanges();


                ViewBag.saveresult = "saved";
                ModelState.Clear();

            }
            return View(new Mobile_info());
            }

        

        }
}
 