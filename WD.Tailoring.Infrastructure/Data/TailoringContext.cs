using Microsoft.EntityFrameworkCore;
using WD.Tailoring.Core.Entities.Authentication;

namespace WD.Tailoring.Infrastructure.Data
{
    public class TailoringContext : DbContext
    {
        public TailoringContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<AppUser> Users { get; set; }
    }

    /// <summary>
    /// Primary Constructor
    /// </summary>
    // public class TailoringContext(DbContextOptions options) : DbContext(options){}
}
