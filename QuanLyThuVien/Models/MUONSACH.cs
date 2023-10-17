namespace QuanLyThuVien.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MUONSACH")]
    public partial class MUONSACH
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string MaDG { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string MaSach { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime NgayMuon { get; set; }

        public DateTime? NgayDenHanTra { get; set; }

        [StringLength(50)]
        public string TinhTrang { get; set; }

        public virtual DOCGIA DOCGIA { get; set; }

        public virtual SACH SACH { get; set; }
    }
}
