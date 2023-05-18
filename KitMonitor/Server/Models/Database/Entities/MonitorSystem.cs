using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KitMonitor.Server.Models.Database.Entities;

public class MonitorSystem
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
	public Company Company { get; set; } = null!;
}

public enum MonitorStatus
{
	Disconnected,
	Connected,
	Error
}