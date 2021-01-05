using Medex.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Medex.Controllers
{
    public class HomeController : Controller
    {
        public List<DoctorViewModel> Doctors => new List<DoctorViewModel>
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

        public HomeController()
        {
        }

        public IActionResult Index()
        {
            return View(Doctors);
        }

        public IActionResult View(int indexOfDoctor)
        {
            return RedirectToAction("Index", "Prescription", Doctors[indexOfDoctor]);
        }

        public IActionResult Delete(int indexOfDoctor)
        {
            return View(Doctors);
        }


    }
}
