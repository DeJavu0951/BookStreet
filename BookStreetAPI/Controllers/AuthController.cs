using Application.DTO.Auth;
using Application.DTO.Response;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RMS.Application.Services;

namespace BookStreetAPI.Controllers
{
    [AllowAnonymous]
    public class AuthController : BaseAPIController
    {
        private IUserService _userService;
        public AuthController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        public ServiceResponse Login(LoginDTO req)
        {
            return _userService.Login(req);
        }
    }
}
