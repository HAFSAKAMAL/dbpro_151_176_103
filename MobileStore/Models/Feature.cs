//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Example.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Feature
    {
        public int FeatureID { get; set; }
        public string Network { get; set; }
        public string Front_Cam { get; set; }
        public string Back_Cam { get; set; }
        public string Sim { get; set; }
        public string Ram { get; set; }
        public string Operating_System { get; set; }
        public string Screen_Size { get; set; }
        public string Frequency { get; set; }
        public string Bettery { get; set; }
        public string Color { get; set; }
        public int ModelID { get; set; }
    
        public virtual Model Model { get; set; }
    }
}
