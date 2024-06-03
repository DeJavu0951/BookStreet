using Application.DTO.Auth;
using Application.DTO.Response;

namespace RMS.Application.Services
{
    public interface IUserService
    {
        public ServiceResponse Login(LoginDTO req);
    }
}
