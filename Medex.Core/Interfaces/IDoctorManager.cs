using System.Collections.Generic;

namespace Medex.Core
{
    public interface IDoctorManager
    {
        bool AddNewDoctor(DoctorDto doctor);
        bool AddNewMedicine(MedicineDto medicine, int prescriptionId);
        bool AddNewPrescription(PrescriptionDto prescription, int doctorId);
        bool DeleteDoctor(DoctorDto doctor);
        bool DeleteMedicine(MedicineDto medicine);
        bool DeletePrescription(PrescriptionDto prescription);
        List<DoctorDto> GetAllDoctors(string filterString);
        List<MedicineDto> GetAllMedicineForAPrescription(int prescriptionId, string filterString);
        List<PrescriptionDto> GetAllPrescriptionsForADoctor(int doctorId, string filterString);
    }
}
