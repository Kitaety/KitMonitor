using KitMonitor.Server.Models.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace KitMonitor.Server.Models.Database;

public class DatabaseContext : DbContext
{
	public DbSet<Company> Companies { get; set; } = null!;
	public DbSet<MonitorSystem> MonitorSystems { get; set; } = null!;
	public DbSet<Indicator> Indicators { get; set; } = null!;
	public DbSet<IndicatorLog> IndicatorLogs { get; set; } = null!;

	public DatabaseContext(DbContextOptions<DatabaseContext> options)
		: base(options)
	{ }
}
