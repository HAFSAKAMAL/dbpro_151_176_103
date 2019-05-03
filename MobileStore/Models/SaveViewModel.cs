using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Example.Models
{
    public class SaveViewModel
    {
     
        public Model model { get; set; }
        public Manufacturer manufacturer { get; set; }
        public Series series { get; set; }
        public Feature features { get; set; }
        public Image image { get; set; }
    }
}