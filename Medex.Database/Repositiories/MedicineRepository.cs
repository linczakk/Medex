using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Medex.Database
{
    public class MedicineRepository : BaseRepository<Medicine>, IMedicineRepository
    {

        protected override DbSet<Medicine> DbSet => mDbContext.Medicines;

        public MedicineRepository(MedexAppDbContext dbContext) : base(dbContext)
        {

        }
    
        public IEnumerable<Medicine> GetAllMedicines()
        {
            return DbSet.Select(x => x);
        }

    }
}
