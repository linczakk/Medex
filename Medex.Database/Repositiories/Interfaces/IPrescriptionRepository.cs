using System.Collections.Generic;

namespace Medex.Database
{
    public interface IPrescriptionRepository : IRepository<Prescription>
    {
        IEnumerable<Prescription> GetAllPrescriptions();
    }
}
