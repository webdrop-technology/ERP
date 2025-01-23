using WD.Tailoring.Core.Entities.Authentication;

namespace WD.Tailoring.Core.Interfaces
{
    public interface ITokenService
    {
        /// <summary>
        /// Generate token for user
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        string CreateToken(AppUser user);
    }
}