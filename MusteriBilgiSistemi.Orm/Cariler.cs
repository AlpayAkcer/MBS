//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MusteriBilgiSistemi.Orm
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cariler
    {
        public int CariId { get; set; }
        public Nullable<int> MusteriId { get; set; }
        public Nullable<decimal> Tutar { get; set; }
        public Nullable<System.DateTime> AlinanTarih { get; set; }
        public Nullable<bool> Onay { get; set; }
    
        public virtual Musteriler Musteriler { get; set; }
    }
}
