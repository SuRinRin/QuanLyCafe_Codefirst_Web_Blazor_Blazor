using B.API.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace B.API.Enitities
{
	public class SanPham
	{
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdSanPham { get; set; }
        [Required]
        public string TenSanPham { get; set; }

        public float? Gia { get; set; } //

        public StatusSanPham? TrangThai { get; set; } //

        public float? Thue { get; set; }

        [NotMapped]
        public IFormFile? HinhAnh { get; set; }

        public virtual LoaiSanPham? LoaiSanPham { get; set; }

        public virtual ICollection<Sale>? Sales { get; set; }
        public virtual ICollection<PhaChe>? PhaChes { get; set; }

        public virtual ICollection<HoaDonChiTiet>? HoaDonChiTiets { get; set; }

    }
}
