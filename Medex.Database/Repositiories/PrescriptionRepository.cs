using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Medex.Database
{
    public class PrescriptionRepository : BaseRepository<Prescription>, IPrescriptionRepository
    {

        protected override DbSet<Prescription> DbSet => mDbContext.Prescriptions;


        public PrescriptionRepository(MedexAppDbContext dbContext) : base(dbContext)
        {

        }

        public IEnumerable<Prescription> GetAllPrescriptions()
        {
            return DbSet./*Include(x => x.Medicines).*/Select(x => x);
        }

    }
}
