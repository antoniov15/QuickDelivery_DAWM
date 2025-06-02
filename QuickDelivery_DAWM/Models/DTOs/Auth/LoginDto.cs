// Models/DTOs/Auth/LoginDto.cs
using QuickDelivery_DAWM.Models.DTOs.Users;
using QuickDelivery_DAWM.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace QuickDelivery_DAWM.Models.DTOs.Auth
{
    public class LoginDto
    {
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email format")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Password is required")]
        [MinLength(6, ErrorMessage = "Password must be at least 6 characters")]
        public string Password { get; set; } = string.Empty;
    }
}