using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Example.Models
{
    public class Mobile_info
    {
        [Display (Name= "Manufacturer Name")]
        public string Name { get; set; }
        [Display (Name = "Country")]
        public string Country { get; set; }

        [Display (Name ="Mobile Series")]
        public string S_Name { get; set; }

        [Display(Name = "Mobile Model")]
        public string M_Name { get; set; }
        [Display(Name = "Launch Date")]
        public System.DateTime Launch_Date { get; set; }
        [Display(Name = "Mobile Price")]
        public double Price { get; set; }

        [Display(Name = "Mobile Network")]
        public string Network { get; set; }
        [Display(Name = "Front Camera")]
        public string Front_Cam { get; set; }
        [Display(Name = "Back Camera")]
        public string Back_Cam { get; set; }
        [Display(Name = "Sim")]
        public string Sim { get; set; }
        [Display(Name = "RAM")]
        public string Ram { get; set; }
        [Display(Name = "Operating System")]
        public string Operating_System { get; set; }
        [Display(Name = "Screen Size")]
        public string Screen_Size { get; set; }
        [Display(Name = "Frequency")]
        public string Frequency { get; set; }
        [Display(Name = "Battery")]
        public string Bettery { get; set; }
        [Display(Name = "Color")]
        public string Color { get; set; }


    }
}