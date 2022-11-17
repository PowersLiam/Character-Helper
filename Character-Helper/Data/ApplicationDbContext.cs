using Character_Helper.Models;
using Microsoft.EntityFrameworkCore;

namespace Character_Helper.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<CharacterViewModel> Characters { get; set; }
        public DbSet<PlayerViewModel> Players { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
    }
}
