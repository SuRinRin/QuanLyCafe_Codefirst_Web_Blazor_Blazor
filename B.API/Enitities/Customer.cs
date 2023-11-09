using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

namespace B.API.Enitities
{
	public class Customer
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int IdCustomer { get; set; }

		[Required]
		public string Name { get; set; }

		public string? SDT { get; set; }

		public string? Email { get; set; }

		public string? DiaChi { get; set; }

		public int? RankId { get; set; }
		public virtual MemberShipRank? MemberShipRank { get; set; }

		public virtual ICollection<HoaDon>? HoaDon { get; set; }
		public int? Point {  get; set; }

	}
}
