using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Medex.Controllers
{
    public class PrescriptionController : Controller
    {
        private DoctorViewModel DoctorVM { get; set; }

        public PrescriptionController()
        {
        }

        public IActionResult Index(DoctorViewModel doctorVm)
        {
            DoctorVM = doctorVm;

            return View(doctorVm);
        }

        public IActionResult View(int indexOfPrescription)
        { 
            return RedirectToAction( "Index", "Medicine", DoctorVM.Prescriptions.ElementAt(indexOfPrescription));
        }

        public IActionResult Delete(int indexOfPrescription)
        {
            return View();
        }
    }
}
