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
    
    public partial class IzvedbaDijak
    {
        public int Izvedba { get; set; }
        public int Dijak { get; set; }
        public string brezVeze { get; set; }
    
        public virtual Dijak Dijak1 { get; set; }
        public virtual Izvedba Izvedba1 { get; set; }
    }
}
