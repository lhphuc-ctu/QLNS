//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLNS
{
    using System;
    using System.Collections.Generic;
    
    public partial class DON_NHAP_HANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DON_NHAP_HANG()
        {
            this.SACHes = new HashSet<SACH>();
            this.NHA_CUNG_CAP = new HashSet<NHA_CUNG_CAP>();
        }
    
        public string MA_DON_NHAP { get; set; }
        public string MA_NV { get; set; }
        public Nullable<System.DateTime> NGAY_NHAP { get; set; }
    
        public virtual NHAN_VIEN NHAN_VIEN { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SACH> SACHes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NHA_CUNG_CAP> NHA_CUNG_CAP { get; set; }
    }
}
