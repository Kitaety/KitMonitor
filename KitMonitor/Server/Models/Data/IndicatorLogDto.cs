using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace KitMonitor.Server.Models.Data
{
	public class IndicatorLogDto
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public long Id { get; set; }
		[Required]
		public long IndicatorId { get; set; }
		[Required]
		public DateTime TimeStamp { get; set; }
		[Required]
		[Column(TypeName = "decimal(15,4)")]
		public decimal Value { get; set; }

		[ForeignKey("IndicatorId")]
		public IndicatorDto Indicator { get; set; } = null!;
	}
}
