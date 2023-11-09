using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace B.API.Enitities
{
	public class PhaChe
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int IdPhaChe { get; set; }
		public string? CongThuc {  get; set; }

		[ForeignKey("SanPham")]
		public int IdSanPham { get; set; }
		public SanPham SanPham { get; set; }

		[ForeignKey("NguyenLieu")]

		public int IdNguyenLieu { get; set; }
		public NguyenLieu NguyenLieu { get; set; }
	}
}
