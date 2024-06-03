
using Application.DTO.Auth;
using Application.DTOs.Auth;

namespace Application.Services
{
    /// <summary>
    /// 
    /// </summary>
    public interface IJwtService
    {
        public UserLoginResponse GenerateUserToken(UserDTO user);
    }
}
