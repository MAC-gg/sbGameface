using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using sbGameface.Models;

namespace sbGameface.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<sbGameface.Models.Game> Game { get; set; } = default!;

        public DbSet<sbGameface.Models.GameQ> GameQ { get; set; } = default!;

        public DbSet<sbGameface.Models.GameStat> GameStat { get; set; } = default!;
    }
}