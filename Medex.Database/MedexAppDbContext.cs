using Microsoft.EntityFrameworkCore;

namespace Medex.Database
{
    public class MedexAppDbContext : DbContext
    {
        public DbSet<Doctor> Doctors { get; set; }

        public DbSet<Prescription> Prescriptions { get; set; }

        public DbSet<Medicine> Medicines { get; set; }

        public MedexAppDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}
