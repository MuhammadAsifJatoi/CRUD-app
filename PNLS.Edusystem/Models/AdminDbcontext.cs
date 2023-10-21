using Microsoft.EntityFrameworkCore;

namespace PNLS.Edusystem.Models
{
    public class AdminDbcontext:DbContext
    {
        public AdminDbcontext(DbContextOptions options):base(options)
        {
            
        }
        public DbSet<AdMin> adMinsTable { get; set; }
        public DbSet<StudentsRecod> studentsTable { get; set; }
        

    }

}
    

