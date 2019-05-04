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

        public ActionResult Nokia()
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
        }

        public ActionResult Samsung()
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
        }

        public ActionResult QMobile()
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
        }

        public ActionResult Huawei()
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
        }

        public ActionResult Blackberry()
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
        }

        public ActionResult Apple()
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
        }

        public ActionResult Lenovo()
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
        }

        public ActionResult Oppo()
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
        }

        public ActionResult Honor()
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
        }

        public ActionResult Vivo()
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
        }

        public ActionResult Xiaomi()
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
        }




        public ActionResult Price_Check()
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
        }

        public ActionResult Price_Check1()
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
        }

        public ActionResult Price_Check2()
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
        }

        public ActionResult Price_Check3()
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
        }

        public ActionResult Price_Check4()
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
        }

        public ActionResult Price_Check5()
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
        }

    }
    }