using Application.DTO.Auth;
using Application.DTO.Response;
using Domain.Entities;

namespace Application.Repositories
{
    public interface IUserRepository
    {
        public User? Login(LoginDTO req);
    }
}
