using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace B.API.Enitities
{
	public class MemberShipRank
	{
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdRank { get; set; }

        public int? PointsNeed { get; set; }

        public float? Discount { get; set; }

        public string? RankName { get; set; }

        public virtual ICollection<Customer> Customers { get; set; }

    }
}
