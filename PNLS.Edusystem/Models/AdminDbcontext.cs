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
<<<<<<< HEAD
        
=======
        public DbSet<Docter>doctertable { get; set; }
>>>>>>> 24503d62ca4c307ea39894e3c1b1ef5b1cb4efb2
    }

}
    

