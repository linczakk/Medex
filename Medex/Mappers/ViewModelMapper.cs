using AutoMapper;
using Medex.Core;
using Medex.Database;
using System.Collections.Generic;

namespace Medex
{
    public class ViewModelMapper
    {
        private IMapper mMapper;

        public ViewModelMapper()
        {
            mMapper = new MapperConfiguration(config =>
            {
                config.CreateMap<MedicineDto, MedicineViewModel>()
                    .ReverseMap();
                config.CreateMap<PrescriptionDto, PrescriptionViewModel>()
                    .ReverseMap();
                config.CreateMap<DoctorDto, DoctorViewModel>()
                    .ReverseMap();
            }).CreateMapper();
        }


        #region Medicine Maps
        public MedicineViewModel Map(MedicineDto medicine) 
            => mMapper.Map<MedicineViewModel>(medicine);

        public List<MedicineViewModel> Map(List<MedicineDto> medicine)
            => mMapper.Map<List<MedicineViewModel>>(medicine);

        public MedicineDto Map(MedicineViewModel medicine)
            => mMapper.Map<MedicineDto>(medicine);

        public List<MedicineDto> Map(List<MedicineViewModel> medicine)
            => mMapper.Map<List<MedicineDto>>(medicine);

        #endregion

        #region Prescription Maps

        public PrescriptionViewModel Map(PrescriptionDto prescription)
            => mMapper.Map<PrescriptionViewModel>(prescription);

        public List<PrescriptionViewModel> Map(List<PrescriptionDto> prescription)
            => mMapper.Map<List<PrescriptionViewModel>>(prescription);

        public PrescriptionDto Map(PrescriptionViewModel prescription)
            => mMapper.Map<PrescriptionDto>(prescription);

        public List<PrescriptionDto> Map(List<PrescriptionViewModel> prescription)
            => mMapper.Map<List<PrescriptionDto>>(prescription);

        #endregion

        #region Doctor Maps

        public DoctorViewModel Map(DoctorDto doctor)
           => mMapper.Map<DoctorViewModel>(doctor);

        public List<DoctorViewModel> Map(List<DoctorDto> doctor)
            => mMapper.Map<List<DoctorViewModel>>(doctor);

        public DoctorDto Map(DoctorViewModel doctor)
            => mMapper.Map<DoctorDto>(doctor);

        public List<DoctorDto> Map(List<DoctorViewModel> doctor)
            => mMapper.Map<List<DoctorDto>>(doctor);

        #endregion
    }
}
