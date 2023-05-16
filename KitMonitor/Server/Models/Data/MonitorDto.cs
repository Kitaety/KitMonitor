using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace KitMonitor.Server.Models.Data
{
	public class MonitorDto
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public long Id { get; set; }
		[Required]
		public string Name { get; set; } = null!;
		public MonitorStatus Status { get; set; }
		[Required]
		public long CompanyId { get; set; }

		[ForeignKey("CompanyId")]
		public CompanyDto Company { get; set; } = null!;
	}

	public enum MonitorStatus
	{
		Disconnected,
		Connected,
		Error
	}
}
