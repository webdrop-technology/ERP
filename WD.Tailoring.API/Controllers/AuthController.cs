using System.Security.Cryptography;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WD.Tailoring.Core.DTOs;
using WD.Tailoring.Core.Entities.Authentication;
using WD.Tailoring.Infrastructure.Data;
using WD.Tailoring.Core.Interfaces;

namespace WD.Tailoring.API.Controllers
{
    public class AuthController(TailoringContext context, ITokenService tokenService) : BaseApiController
    {
        [HttpPost("login")]
        public async Task<ActionResult<UserDto>> Login(LoginDto login)
        {
            var user = await context.Users.FirstOrDefaultAsync(x => x.UserName.ToLower() == login.Username.ToLower());
            if (user == null)
            {
                return Unauthorized("Invalid Username");
            }
            using var hmac = new HMACSHA512(user.PasswordSalt);
            var computeHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(login.Password));
            for (int i = 0; i < computeHash.Length; i++)
            {
                if (computeHash[i] != user.PasswordHash[i])
                {
                    return Unauthorized("Invalid Password");
                }
            }

            return new UserDto
            {
                Username = user.UserName,
                Token = tokenService.CreateToken(user),
            };

        }



        [HttpPost("register")] //account/register
        public async Task<ActionResult<UserDto>> Register(RegisterDto register)
        {
            if (await IsUserExists(register.Username))
            {
                return BadRequest("Username is taken.");
            }
            using var hmac = new HMACSHA512();
            var user = new AppUser
            {
                UserName = register.Username.ToLower(),
                PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(register.Password)),
                PasswordSalt = hmac.Key

            };
            context.Users.Add(user);
            await context.SaveChangesAsync();

            return new UserDto
            {
                Username = user.UserName,
                Token = tokenService.CreateToken(user),
                
            };
        }

        private async Task<bool> IsUserExists(string username)
        {
            return await context.Users.AnyAsync(x => x.UserName.ToLower() == username.ToLower());  //abc!=
        }
    }
}