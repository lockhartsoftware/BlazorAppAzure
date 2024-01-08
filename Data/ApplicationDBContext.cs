using Microsoft.EntityFrameworkCore;

namespace BlazorAppAzure.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        { }

        public DbSet<Robot> Robot {  get; set; } = default!;
    }
}