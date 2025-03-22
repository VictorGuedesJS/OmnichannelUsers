using System.ComponentModel.DataAnnotations;

namespace OmnichannelApi.Model
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [EmailAddress]
        public string? Email { get; set; }
        [Required]
        public string? PasswordHash { get; set; }

        [Phone]
        public string? PhoneNumber { get; set; }

        public string? Address { get; set; }

        public string? Cep { get; set; }

        [Required]
        public PreferredChannel PreferredChannel { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public bool IsActive { get; set; } = true;

    }

    public enum PreferredChannel
    {
        Email,
        SMS,
        WhatsApp,
        ChatOnline,
        SocialMedia
    }
}
