using Microsoft.EntityFrameworkCore;

namespace BackendDeveloperTest.Contexts
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {

        }
    }
}
 