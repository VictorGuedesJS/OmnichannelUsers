using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OmnichannelFront.Models
{
    public class User
    {
        public int Id { get; set; }
        public string? Email { get; set; }
        public string? PasswordHash { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Address { get; set; }
        public string? Cep { get; set; }
        public PreferredChannel PreferredChannel { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsActive { get; set; }
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