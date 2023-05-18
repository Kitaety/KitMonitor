using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KitMonitor.Server.Models.Database.Entities
{
    public class Company
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        [Required]
        [MaxLength(255)]
        public string Name { get; set; } = null!;

        public IEnumerable<MonitorSystem> MonitorSystems { get; set; } = new List<MonitorSystem>();
    }
}
