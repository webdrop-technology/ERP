namespace WD.Tailoring.Core.Entities.Authentication
{
    public class AppUser : BaseEntity
    {
        public required string UserName { get; set; }
        public required byte[] PasswordHash { get; set; }
        public required byte[] PasswordSalt { get; set; }
    }
}