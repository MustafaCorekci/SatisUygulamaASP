//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SatisUygulamaASP.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblUrun
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblUrun()
        {
            this.tblSatis = new HashSet<tblSati>();
        }
    
        public int UrunID { get; set; }
        public string UrunAd { get; set; }
        public string UrunMarka { get; set; }
        public Nullable<byte> UrunKategori { get; set; }
        public Nullable<decimal> UrunFiyat { get; set; }
        public Nullable<short> UrunStok { get; set; }
        public Nullable<bool> Durum { get; set; }
    
        public virtual tblKategori tblKategori { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblSati> tblSatis { get; set; }
    }
}
