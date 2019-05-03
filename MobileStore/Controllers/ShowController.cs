using Example.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Example.Controllers
{
    public class ShowController : Controller
    {
        // GET: Show
        public ActionResult Index()
        {
            using (DB18Entities1 db = new DB18Entities1())
            {
                List<Manufacturer> man = db.Manufacturers.ToList();
                List<Series> ser = db.Series.ToList();
                List<Model> mod = db.Models.ToList();
                List<Feature> fea = db.Features.ToList();
                List<Image> img = db.Images.ToList();
                var m_recored = from m in man
                                join s in ser on m.ManufacturerID equals s.ManufacturerID into table1
                                from s in table1.ToList()
                                join md in mod on s.SeriesID equals md.SeriesID into table2
                                from md in table2.ToList()
                                join f in fea on md.ModelID equals f.ModelID into table3
                                from f in table3.ToList()
                                join i in img on md.ModelID equals i.ModelID into table4
                                from i in table4.ToList()
                                select new SaveViewModel
                                {
                                    model = md,
                                    manufacturer = m,
                                    series = s,
                                    features = f,
                                    image = i,

                                };
                return View(m_recored);
            }


            /* List<Series> SeriesList = db.Series.ToList();
             SaveViewModel SaveVM = new SaveViewModel();

             List<SaveViewModel> SVMList = SeriesList.Select(x => new SaveViewModel
             {

                 SeriesID = x.SeriesID,
                 Name = x.Name,
                 ManufacturerID = x.ManufacturerID,
                 Manufacturer_Name = x.Manufacturer.Name
             }).ToList();

             return View(SVMList);
         }

     */
        }
    }
}