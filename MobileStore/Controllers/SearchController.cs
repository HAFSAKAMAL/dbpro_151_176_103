using Example.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Example.Controllers
{
    public class SearchController : Controller
    {
        DB18Entities1 db = new DB18Entities1();
        // GET: Search
        public ActionResult Index(string searching)
        {
            var products = from s in db.Models
                           select s;
            if (!string.IsNullOrEmpty(searching))
            {
                products = products.Where(s => s.Name.Contains(searching));
            }

            return View(products.ToList());
        }


    }
}
