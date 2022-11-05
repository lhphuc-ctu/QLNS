﻿//------------------------------------------------------------------------------
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
    using System.ComponentModel.DataAnnotations;

    public partial class NHAN_VIEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NHAN_VIEN()
        {
            this.DON_NHAP_HANG = new HashSet<DON_NHAP_HANG>();
            this.HOA_DON = new HashSet<HOA_DON>();
            this.TAI_KHOAN = new HashSet<TAI_KHOAN>();
        }
        [Display(Name = "Mã nhân viên")]
        [Required(ErrorMessage = "Không được để trống!")]
        [MaxLength(20, ErrorMessage = "Mã nhân viên tối đa 20 kí tự!")]
        public string MA_NV { get; set; }
        [Display(Name = "Tên nhân viên")]
        [Required(ErrorMessage = "Không được để trống!")]
        public string TEN_NV { get; set; }
        [Display(Name = "Năm sinh")]
        public Nullable<System.DateTime> NAM_SINH { get; set; }
        [Display(Name = "Nơi sống")]
        [Required(ErrorMessage = "Không được để trống!")]
        public string NOI_SONG { get; set; }
        [Display(Name = "Số điện thoại")]
        [Required(ErrorMessage = "Không được để trống!")]
        [MaxLength(10, ErrorMessage = "Số điện thoại tối đa 10 kí tự!")]
        [Range(0, int.MaxValue, ErrorMessage = "Hãy nhập số điện thoại hợp lệ!")]
        public string SDT { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DON_NHAP_HANG> DON_NHAP_HANG { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOA_DON> HOA_DON { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TAI_KHOAN> TAI_KHOAN { get; set; }
    }
}
