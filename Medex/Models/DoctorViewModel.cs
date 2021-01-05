using System.Collections.Generic;

namespace Medex
{
    public class DoctorViewModel
    {
        public string Name { get; set; }
        public List<PrescriptionViewModel> Prescriptions { get; set; }
    }
}
