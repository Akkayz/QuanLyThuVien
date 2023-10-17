namespace QuanLyThuVien.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DAUSACH")]
    public partial class DAUSACH
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DAUSACH()
        {
            BINHLUANs = new HashSet<BINHLUAN>();
            SACHes = new HashSet<SACH>();
        }

        [Key]
        public int MaDS { get; set; }

        [StringLength(50)]
        public string TenDS { get; set; }

        [StringLength(50)]
        public string Mota { get; set; }

        public int? SoLuong { get; set; }

        [StringLength(50)]
        public string TacGia { get; set; }

        [StringLength(50)]
        public string NXB { get; set; }

        public int? NamXB { get; set; }

        public int? MaCN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BINHLUAN> BINHLUANs { get; set; }

        public virtual CHUYENNGANH CHUYENNGANH { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SACH> SACHes { get; set; }
    }
}
