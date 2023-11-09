using B.API.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace B.API.Enitities
{
	public class NhanVien
	{
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdNhanVien { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]  
        public string LoginName { get; set; }

        [Required]
        public string Password { get; set; }

        public StatusSanPham? Active {  get; set; }

        public virtual ICollection<HoaDon>? HoaDons {  get; set; } 
    }
}
