using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KitMonitor.Server.Models.Database.Entities
{
    public class IndicatorLog
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
        public Indicator Indicator { get; set; } = null!;
    }
}
