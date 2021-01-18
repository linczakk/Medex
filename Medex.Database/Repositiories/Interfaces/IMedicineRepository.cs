using System.Collections.Generic;

namespace Medex.Database
{
    public interface IMedicineRepository : IRepository<Medicine>
    {
        IEnumerable<Medicine> GetAllMedicines();
    }
}
