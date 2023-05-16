using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KitMonitor.Server.Models.Data
{
	public class CompanyDto
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public long Id { get; set; }
		[Required] 
		public string Name { get; set; } = null!;

		public IEnumerable<MonitorDto> Monitors { get; set; } = new List<MonitorDto>();
	}
}
