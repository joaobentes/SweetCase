using Microsoft.EntityFrameworkCore;

namespace SS_Case.Models
{
    public class ApplicationDbContext: DbContext
    {
        public DbSet<Client> Clients { get; set; }
        
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options) {}
    }
}

