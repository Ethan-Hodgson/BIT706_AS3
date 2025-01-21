using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MicrochipRegistry.Models
{
    [Table("Clinics")]
    public class Clinic
    {
        [Key]
        public int ClinicId { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(200)]
        public string Address { get; set; }

        [StringLength(20)]
        public string ContactNumber { get; set; }

        // One-to-many relationship: one clinic can have multiple microchips
        public virtual ICollection<Microchip> Microchips { get; set; }
            = new List<Microchip>();
    }
}
