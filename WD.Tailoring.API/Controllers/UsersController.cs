using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WD.Tailoring.Core.Entities.Authentication;
using WD.Tailoring.Infrastructure.Data;

namespace WD.Tailoring.API.Controllers
{
    [Authorize]
    public class UsersController(TailoringContext _context) : BaseApiController
    {
        [AllowAnonymous]
        [HttpGet("")] //api/users
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
        {
            var users = await _context.Users.ToListAsync();
            return users;
        }

        [HttpGet("{id:int}")] //api/users/1
        public async Task<ActionResult<AppUser>> GetUser(int id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user == null) { return NotFound(); }
            return user;
        }
    }
}