using Microsoft.EntityFrameworkCore;

namespace _13300_Robert_Sternal.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<TravelsModel> Travels { get; set; }
    }
}
