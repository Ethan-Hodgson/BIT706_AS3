using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NationalMicrochipRegistry.Models
{
    [Table("Microchips")]
    public class Microchip
    {
        [Key]
        public int MicrochipId { get; set; }

        [Required]
        public required string Code { get; set; }

        [Required]
        public int ClinicId { get; set; }

        [ForeignKey("ClinicId")]
        public Clinic Clinic { get; set; } = null!; 

        public DateTime RegistrationDate { get; set; }

        public bool IsActive { get; set; }

        public Animal? Animal { get; set; }
    }
}
