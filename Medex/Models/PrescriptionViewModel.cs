using System.Collections.Generic;

namespace Medex
{
    public class PrescriptionViewModel
    {
        public string Name { get; set; }
        public List<MedicineViewModel> Medicines { get; set; }
    }
}
