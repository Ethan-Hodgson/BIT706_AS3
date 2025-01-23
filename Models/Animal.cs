using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NationalMicrochipRegistry.Models
{
    [Table("Animals")]
    public class Animal
    {
        [Key]
        public int AnimalId { get; set; }

        [Required]
        public required string Name { get; set; }

        [Required]
        public required string Breed { get; set; }

        [Required]
        public required string Species { get; set; }

        public int? MicrochipId { get; set; }

        [ForeignKey("MicrochipId")]
        public Microchip? Microchip { get; set; }
    }
}
