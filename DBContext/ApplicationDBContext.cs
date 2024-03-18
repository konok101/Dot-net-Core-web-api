using Microsoft.EntityFrameworkCore;
using repositoryPatternRecap.Model;

namespace repositoryPatternRecap.DBContext
{
    public class ApplicationDBContext: DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) { }

        public DbSet <Studentm> Students { get; set; }

       
    }
}
