using System.ComponentModel.DataAnnotations;

namespace WD.Tailoring.Core.DTOs
{
    public class RegisterDto
    {
        [MaxLength(50)]
        public required string Username { get; set; }
        [MinLength(6)]
        public required string Password { get; set; }
    }
}