using KitMonitor.Server.Models.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace KitMonitor.Server.Models
{
	public class DatabaseContext: DbContext
	{
		public DbSet<CompanyDto> Companies { get; set; } = null!;
		public DbSet<MonitorDto> Monitors { get; set; } = null!;
		public DbSet<IndicatorDto> Indicators { get; set; } = null!;
		public DbSet<IndicatorLogDto> IndicatorLogs { get; set; } = null!;

		public DatabaseContext(DbContextOptions<DatabaseContext> options)
		:base(options)
		{}
	}
}
