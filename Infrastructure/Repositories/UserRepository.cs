using Application.DTO.Auth;
using Application.Repositories;
using Domain.Entities;
using Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class UserRepository : BaseRepository, IUserRepository
    {
        public UserRepository(BookStreetContext context) : base(context)
        {
        }
        public User? Login(LoginDTO req)
        {
            return _context.Users.FirstOrDefault(user => user.Username.ToLower() == req.Username.ToLower() && user.Password == req.Password);
        }
    }
}
