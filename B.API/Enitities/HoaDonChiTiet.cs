using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace B.API.Enitities
{
	public class HoaDonChiTiet
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int IDHoaDonChiTiet { get; set; }

		public DateTime? NgayXuatDon { get; set; }

		public float? TongGiaTriHoaDon { get; set; }

		public int? SoLuong { get; set; }

		public float? GiaBan { get; set; }

		[ForeignKey("Customer")]

		public int IdCustomer { get; set; }
		public virtual Customer Customer { get; set; }
		[ForeignKey("SanPham")]

		public int IdSanPham { get; set; }
		public virtual ICollection<SanPham> SanPham  { get; set; }
		[ForeignKey("Voucher")]

		public int IdVoucher { get; set; }
		public virtual Voucher Voucher { get; set; }

		public virtual HoaDon? HoaDon { get; set; }
	}
}
