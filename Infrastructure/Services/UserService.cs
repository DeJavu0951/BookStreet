using Application.DTO.Auth;
using Application.DTO.Response;
using Application.Repositories;
using Application.Services;
using AutoMapper;
using Infrastructure.Context;
using RMS.Application.Services;

namespace Infrastructure.Services
{
    public class UserService : IUserService
    {
        private IUserRepository _userRepository;
        private readonly IJwtService _jwtService;
        private readonly IMapper _mapper;
        public UserService(IJwtService jwtService, IMapper mapper, IUserRepository userRepository)
        {
            _jwtService = jwtService;
            _mapper = mapper;
            _userRepository = userRepository;
        }

        public ServiceResponse Login(LoginDTO req)
        {
            ServiceResponse serviceResponse = new();
            var user = _userRepository.Login(req);
            if (user == null)
            {
                return serviceResponse.OnError("Username or password is incorrect");
            }
            var userDTO = _mapper.Map<UserDTO>(user);
            var token = _jwtService.GenerateUserToken(userDTO);
            return serviceResponse.Onsuccess(token);
        }
    }
}
