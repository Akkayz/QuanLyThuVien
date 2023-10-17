namespace QuanLyThuVien.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("YEUCAU")]
    public partial class YEUCAU
    {
        [Key]
        public int MaYC { get; set; }

        [StringLength(50)]
        public string TenSach { get; set; }

        [StringLength(50)]
        public string TacGia { get; set; }

        [StringLength(10)]
        public string MaDG { get; set; }

        public virtual DOCGIA DOCGIA { get; set; }
    }
}
