using Medex.Database;
using System.Collections.Generic;
using System.Linq;

namespace Medex.Core
{

    public class DoctorManager : IDoctorManager
    {
        private readonly IDoctorRepository mDoctorRepository;
        private readonly IPrescriptionRepository mPrescriptionRepository;
        private readonly IMedicineRepository mMedicineRepository;
        private readonly DtoMapper mDtoMapper;

        public DoctorManager(IDoctorRepository doctorRepository,
                             IPrescriptionRepository prescriptionRepository,
                             IMedicineRepository medicineRepository,
                             DtoMapper doctorsMapper)
        {
            mDoctorRepository = doctorRepository;
            mPrescriptionRepository = prescriptionRepository;
            mMedicineRepository = medicineRepository;
            mDtoMapper = doctorsMapper;
        }

        public List<DoctorDto> GetAllDoctors(string filterString)
        {
            var doctorEntities = mDoctorRepository.GetAllDoctors()
                                                  .ToList();

            if (!string.IsNullOrEmpty(filterString))
            {
                doctorEntities = doctorEntities
                    .Where(x => x.FirstName.Contains(filterString) || x.LastName.Contains(filterString))
                    .ToList();
            }

            return mDtoMapper.Map(doctorEntities);
        }

        public List<PrescriptionDto> GetAllPrescriptionsForADoctor(int doctorId, string filterString)
        {
            var prescriptionEntities = mPrescriptionRepository.GetAllPrescriptions()
                                                              .Where(x => x.DoctorId == doctorId)
                                                              .ToList();

            if (!string.IsNullOrEmpty(filterString))
            {
                prescriptionEntities = prescriptionEntities
                    .Where(x => x.Name.Contains(filterString))
                    .ToList();
            }

            return mDtoMapper.Map(prescriptionEntities);
        }

        public List<MedicineDto> GetAllMedicineForAPrescription(int prescriptionId, string filterString)
        {
            var medicineEntities = mMedicineRepository.GetAllMedicines()
                .Where(x => x.PrescriptionId == prescriptionId)
                .ToList();

            if (!string.IsNullOrEmpty(filterString))
            {
                medicineEntities = medicineEntities
                    .Where(x => x.ActiveSubstance.Contains(filterString) ||
                                x.Name.Contains(filterString) ||
                                x.CompanyName.Contains(filterString))
                    .ToList();
            }

            return mDtoMapper.Map(medicineEntities);
        }

        public bool AddNewMedicine(MedicineDto medicine, int prescriptionId)
        {
            var entity = mDtoMapper.Map(medicine);

            entity.PrescriptionId = prescriptionId;

            return mMedicineRepository.AddNew(entity);
        }

        public bool AddNewPrescription(PrescriptionDto prescription, int doctorId)
        {
            var entity = mDtoMapper.Map(prescription);

            entity.DoctorId = doctorId;

            return mPrescriptionRepository.AddNew(entity);
        }

        public bool AddNewDoctor(DoctorDto doctor)
        {
            var entity = mDtoMapper.Map(doctor);

            return mDoctorRepository.AddNew(entity);
        }


        public bool DeleteMedicine(MedicineDto medicine)
        {
            var entity = mDtoMapper.Map(medicine);

            return mMedicineRepository.Delete(entity);
        }

        public bool DeletePrescription(PrescriptionDto prescription)
        {
            var entity = mDtoMapper.Map(prescription);

            return mPrescriptionRepository.Delete(entity);
        }

        public bool DeleteDoctor(DoctorDto doctor)
        {
            var entity = mDtoMapper.Map(doctor);

            return mDoctorRepository.Delete(entity);
        }

    }
}
