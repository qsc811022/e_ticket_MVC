using Microsoft.EntityFrameworkCore;

namespace e_ticket.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {


        }

    }
}
