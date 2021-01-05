using Microsoft.AspNetCore.Mvc;

namespace Medex.Controllers
{
    public class MedicineController : Controller
    {

        public MedicineController()
        {
        }

        public IActionResult Index(PrescriptionViewModel prescriptionVm)
        {
            return View(prescriptionVm);
        }

        public IActionResult Delete(int indexOfMedicine)
        {
            return View();
        }

    }
}
