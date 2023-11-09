using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace B.API.Enitities
{
	public class DichVuPhatSinh
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int IdDichVu { get; set; }

		public string? ChiTiet { get; set; }

		public float? SoTien {  get; set; }

		public virtual HoaDon? HoaDon { get; set; }
	}
}
