using Application.DTO.Auth;

namespace Application.DTOs.Auth
{
    public class UserLoginResponse
    {
        public int? UserId { get; set; }
        public string? Token { get; set; }
        public string? Role { get; set; }
        public DateTime Expires { get; set; }
        public UserDTO? User { get; set; }
    }
}
