using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MicrochipRegistry.Models
{
    [Table("Animals")]
    public class Animal
    {
        [Key]
        public int AnimalId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Species { get; set; }

        [StringLength(50)]
        public string Breed { get; set; }

        public DateTime? DateOfBirth { get; set; }

        // Foreign key to Microchip (nullable if the animal has no chip yet)
        [ForeignKey(nameof(Microchip))]
        public int? MicrochipId { get; set; }

        public virtual Microchip Microchip { get; set; }
    }
}
