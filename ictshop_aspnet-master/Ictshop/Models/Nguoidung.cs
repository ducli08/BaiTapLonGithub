namespace Ictshop.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Nguoidung")]
    public partial class Nguoidung
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Nguoidung()
        {
            Donhang = new HashSet<Donhang>();
        }

        [Key]
        public int MaNguoiDung { get; set; }

        [StringLength(50)]
        [DisplayName("Họ Tên")]
        public string Hoten { get; set; }

        //[StringLength(50)]
        [DisplayName("Email")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}",
        ErrorMessage = "Email is not valid.")]

        public string Email { get; set; }

        
        [DisplayName("Điện Thoại")]
        
        public string Dienthoai { get; set; }

        [StringLength(50)]
        [DisplayName("Mật Khẩu")]
        public string Matkhau { get; set; }

        public int? IDQuyen { get; set; }

        [StringLength(100)]
        [DisplayName("Địa chỉ")]
        public string Diachi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Donhang> Donhang { get; set; }

        
        public virtual PhanQuyen PhanQuyen { get; set; }
    }
}
