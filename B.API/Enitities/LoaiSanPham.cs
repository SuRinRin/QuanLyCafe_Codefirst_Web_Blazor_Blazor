using B.API.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace B.API.Enitities
{
	public class LoaiSanPham
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdLoaiSanPham { get; set; }
		[Required]
		public string TenLoaiSanPham {  set; get; }
		public StatusSanPham? TrangThai {  get; set; }
		public int? UserId {  get; set; }
		public virtual ICollection<SanPham>? sanPhams { get; set; }

    }
}
