using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Medex
{
    public static class TestDatabasePleaseDelete
    {
        public static List<DoctorViewModel> Doctors { get; set; }
        = new List<DoctorViewModel>
        {
            new DoctorViewModel
            {
                Name = "Patryk",
                Prescriptions = new List<PrescriptionViewModel>
                {
                    new PrescriptionViewModel
                    {
                        Name = "Recepta 1",
                        Medicines = new List<MedicineViewModel>
                        {
                            new MedicineViewModel
                            {
                                Name = "Magnez"
                            },
                            new MedicineViewModel
                            {
                                Name = "Marsjanki"
                            }
                        }
                    },
                    new PrescriptionViewModel
                    {
                        Name = "Recepta 2",
                        Medicines = new List<MedicineViewModel>
                        {
                            new MedicineViewModel
                            {
                                Name = "Strepsils"
                            },
                            new MedicineViewModel
                            {
                                Name = "WD40"
                            }
                        }
                    }
                }
            },
            new DoctorViewModel
            {
                Name = "Kazimierz",
                Prescriptions = new List<PrescriptionViewModel>
                {
                    new PrescriptionViewModel
                    {
                        Name = "Recepta 1",
                        Medicines = new List<MedicineViewModel>
                        {
                            new MedicineViewModel
                            {
                                Name = "Magnez"
                            },
                            new MedicineViewModel
                            {
                                Name = "Marsjanki"
                            }
                        }
                    },
                    new PrescriptionViewModel
                    {
                        Name = "Recepta 2",
                        Medicines = new List<MedicineViewModel>
                        {
                            new MedicineViewModel
                            {
                                Name = "Strepsils"
                            },
                            new MedicineViewModel
                            {
                                Name = "WD40"
                            }
                        }
                    }
                }
            },
            new DoctorViewModel
            {
                Name = "Zbigniew",
                Prescriptions = new List<PrescriptionViewModel>
                {
                    new PrescriptionViewModel
                    {
                        Name = "Recepta 1",
                        Medicines = new List<MedicineViewModel>
                        {
                            new MedicineViewModel
                            {
                                Name = "Magnez"
                            },
                            new MedicineViewModel
                            {
                                Name = "Marsjanki"
                            }
                        }
                    },
                    new PrescriptionViewModel
                    {
                        Name = "Recepta 2",
                        Medicines = new List<MedicineViewModel>
                        {
                            new MedicineViewModel
                            {
                                Name = "Strepsils"
                            },
                            new MedicineViewModel
                            {
                                Name = "WD40"
                            }
                        }
                    }
                }
            }
        };
    }
}
