using System.Collections.Generic;

namespace Medex.Database
{ 
    public interface IDoctorRepository : IRepository<Doctor>
    {
        IEnumerable<Doctor> GetAllDoctors();

    }
}
