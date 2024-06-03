using Application.DTO.Auth;
using AutoMapper;
using Domain.Entities;

namespace Infrastructure.Mappers
{
    /// <summary>
    /// This class is used to map objects.
    /// </summary>
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            UserMapper();
        }

        private void UserMapper()
        {
            CreateMap<User, UserDTO>().ReverseMap();
        }
    }
}