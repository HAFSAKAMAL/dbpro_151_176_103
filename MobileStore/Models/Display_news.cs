using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Example.Models
{
    public class Display_news
    {
        public string Details { get; set; }

        public List<Display_news> News_Details { get; set; }
    }
}