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
    
    public partial class Review
    {
        public int ReviewID { get; set; }
        public string Email { get; set; }
        public double Rating { get; set; }
        public System.DateTime Date { get; set; }
        public string Opinion { get; set; }
        public int ModelID { get; set; }
    
        public virtual Model Model { get; set; }
    }
}
