using Microsoft.AspNetCore.Mvc;
using NetApi.Entities;

namespace NetApi.Services
{
    public interface IUserService
    {
        public Task<IEnumerable<User>?> GetUsers();
    }
}
