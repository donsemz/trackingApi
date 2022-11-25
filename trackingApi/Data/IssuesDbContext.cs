using Microsoft.EntityFrameworkCore;
using trackingApi.Models;

namespace trackingApi.Data
{

    public class IssuesDbContext : DbContext
    {
        public IssuesDbContext(DbContextOptions<IssuesDbContext> options):base(options)
        {

        }
        public DbSet<Issue> Issues { get; set; }
    }
}
