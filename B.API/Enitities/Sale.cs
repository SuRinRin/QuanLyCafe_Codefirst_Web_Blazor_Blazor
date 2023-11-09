using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace B.API.Enitities
{
	public class Sale
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int IdSale { get; set; }

		public float? PhanTram {  get; set; }

		public int? SoLuong { get; set; }

		public DateTime? NgayBatDau { get; set; }

		public DateTime? NgayKetThuc { get; set; }

		[ForeignKey("SanPham")]
		public int IdSanPham { set; get; }
		public virtual SanPham? SanPham { get; set; }
	}
}
