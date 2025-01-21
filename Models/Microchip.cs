using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MicrochipRegistry.Models
{
    [Table("Microchips")]
    public class Microchip
    {
        [Key]
        public int MicrochipId { get; set; }

        [Required]
        [StringLength(50)]
        public string Code { get; set; }

        [Required]
        public DateTime RegistrationDate { get; set; } = DateTime.UtcNow;

        public bool IsActive { get; set; } = true;

        // Foreign key to Clinic
        [ForeignKey(nameof(Clinic))]
        public int ClinicId { get; set; }

        public virtual Clinic Clinic { get; set; }

        // One-to-one or zero-to-one relationship: an animal can have exactly one Microchip
        public virtual Animal Animal { get; set; }
    }
}
