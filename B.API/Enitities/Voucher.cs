using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace B.API.Enitities
{
	public class Voucher
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]

		public int IdVoucher { get; set; }
		
		public float? GiamTien { get; set; }

		public DateTime? DateStart { get; set; }

		public DateTime? DateEnd { get; set; }

		public int? SoLuong { get; set; }

		public string? Code { get; set; }

		public string? DieuKienApDung { get; set; }

		public virtual ICollection<HoaDon>? HoaDons { get; set; }
	}
}
