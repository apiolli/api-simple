using Microsoft.EntityFrameworkCore;

namespace api_simple.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

    }
}
