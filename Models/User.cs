using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MicrochipRegistry.Models
{
    public enum UserRole
    {
        SystemAdmin,
        RegistryAdmin,
        ClinicStaff
        // ... other roles if needed
    }

    [Table("Users")]
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        [StringLength(50)]
        public string Username { get; set; }

        [Required]
        public string PasswordHash { get; set; }

        [Required]
        public UserRole Role { get; set; }
    }
}
