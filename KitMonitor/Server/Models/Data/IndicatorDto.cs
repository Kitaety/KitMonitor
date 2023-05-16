using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace KitMonitor.Server.Models.Data
{
	public class IndicatorDto
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public long Id { get; set; }
		[Required]
		public IndicatorTypeEnum Type { get; set; }

		public IEnumerable<IndicatorLogDto> Log { get; set; } = new List<IndicatorLogDto>();
	}

	public enum IndicatorTypeEnum
	{
		Temperature,
		Ph,
		Tds,
		WaterFlow
	}
}
