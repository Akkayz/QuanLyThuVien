namespace QuanLyThuVien.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SACH")]
    public partial class SACH
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SACH()
        {
            MUONSACHes = new HashSet<MUONSACH>();
        }

        [Key]
        [StringLength(10)]
        public string MaSach { get; set; }

        public int MaDS { get; set; }

        public int MaCN { get; set; }

        [StringLength(50)]
        public string TrangThai { get; set; }

        public virtual CHINHANH CHINHANH { get; set; }

        public virtual DAUSACH DAUSACH { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MUONSACH> MUONSACHes { get; set; }
    }
}
