using B.API.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace B.API.Enitities
{
	public class HoaDon
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int IDHoaDon { get; set; }

		public DateTime NgayBan { get; set; }

		public StatusTrangThai TrangThai { get; set; }

		[ForeignKey("NhanVien")]
		public int IdNhanVien {  get; set; }
		public virtual NhanVien? NhanVien { get; set; }

		[ForeignKey("Customer")]
		public int CustomerId { get; set; }

		public virtual Customer? Customer { get; set; }
		public virtual Voucher? Voucher { get; set; }

		public virtual ICollection<HoaDonChiTiet> HoaDonChiTiets { get; set; }
		public virtual ICollection<DichVuPhatSinh> DichVuPhatSinhs { get; set; }

	}
}
