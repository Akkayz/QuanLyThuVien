namespace QuanLyThuVien.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BINHLUAN")]
    public partial class BINHLUAN
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string MaDG { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaSach { get; set; }

        [StringLength(50)]
        public string NoiDung { get; set; }

        public int? Rating { get; set; }

        public virtual DOCGIA DOCGIA { get; set; }

        public virtual DAUSACH DAUSACH { get; set; }
    }
}
