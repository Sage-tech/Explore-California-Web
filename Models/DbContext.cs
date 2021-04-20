using Microsoft.EntityFrameworkCore;

namespace Explore_California_Web.Models
{
    public class DbContext
    {
        private DbContextOptions<BlogDataContext> options;

        public DbContext(DbContextOptions<BlogDataContext> options)
        {
            this.options = options;
        }
    }
}