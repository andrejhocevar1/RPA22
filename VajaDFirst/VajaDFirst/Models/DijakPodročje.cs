//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VajaDFirst.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DijakPodročje
    {
        public int DijID { get; set; }
        public int PodID { get; set; }
        public string DijPodTest { get; set; }
    
        public virtual Dijak Dijak { get; set; }
        public virtual Področja Področja { get; set; }
    }
}
