using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace B.API.Enitities
{
	public class NguyenLieu
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int IdNguyeLieu { get; set; }
		[Required]
		public string TenNguyenLieu { get; set; }

		public float? Gia {  get; set; }
		public DateTime? NgayNhap { get; set; }

		public DateTime? NgayHetHan {  get; set; }

		public int? SoLuong { get; set; }

		public virtual ICollection<PhaChe>? PhaChes { get; set; }
	}
}
