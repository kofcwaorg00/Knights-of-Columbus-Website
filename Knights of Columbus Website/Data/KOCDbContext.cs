using Knights_of_Columbus_Website.Models;
using Microsoft.EntityFrameworkCore;

namespace Knights_of_Columbus_Website.Data
{
    public class KOCDbContext : DbContext
    {
        public KOCDbContext(DbContextOptions<KOCDbContext> ops): base(ops)
        {

        }
        public DbSet<Knights> SignUp => Set<Knights>();
  
    }
}
