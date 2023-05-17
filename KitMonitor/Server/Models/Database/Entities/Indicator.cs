using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KitMonitor.Server.Models.Database.Entities
{
    public class Indicator
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public long IdMonitorSystem { get; set; }
        [Required]
        public IndicatorTypeEnum Type { get; set; }

        [ForeignKey("IdMonitorSystem")]
        public MonitorSystem MonitorSystem { get; set; } = null!;
        public IEnumerable<IndicatorLog> Log { get; set; } = new List<IndicatorLog>();
    }

    public enum IndicatorTypeEnum
    {
        Temperature,
        Ph,
        Tds,
        WaterFlow
    }
}
