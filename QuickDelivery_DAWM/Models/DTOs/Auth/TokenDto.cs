// Models/DTOs/Auth/TokenDto.cs
using QuickDelivery_DAWM.Models.DTOs.Users;
using QuickDelivery_DAWM.Models.Enums;

namespace QuickDelivery_DAWM.Models.DTOs.Auth
{
    public class TokenDto
    {
        public string AccessToken { get; set; } = string.Empty;
        public string TokenType { get; set; } = "Bearer";
        public DateTime ExpiresAt { get; set; }
        public UserDto User { get; set; } = null!;
    }
}

