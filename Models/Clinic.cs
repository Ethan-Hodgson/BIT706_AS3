using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NationalMicrochipRegistry.Models
{
    [Table("Clinics")]
    public class Clinic
    {
        [Key]
        public int ClinicId { get; set; }

        [Required]
        public required string Name { get; set; }

        [Required]
        public required string Address { get; set; }

        [Required]
        public required string ContactNumber { get; set; }
    }
}
