using Microsoft.AspNetCore.Mvc;
using NetApi.Entities;

namespace NetApi.Services
{
    public interface IUserService
    {
        public Task<ActionResult<IEnumerable<User>>?> GetUsers();
    }
}
