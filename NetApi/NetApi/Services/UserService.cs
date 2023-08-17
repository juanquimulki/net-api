using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NetApi.Entities;

namespace NetApi.Services
{
    public class UserService : IUserService
    {
        private readonly NetapiContext _context;
        public UserService(NetapiContext context) {  _context = context; }

        public async Task<IEnumerable<User>?> GetUsers()
        {
            if (_context.Users == null)
            {
                return null;
            }
            return await _context.Users.ToListAsync();
        }
    }
}
