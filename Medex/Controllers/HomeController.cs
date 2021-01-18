using Medex.Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Medex.Controllers
{
    public class HomeController : Controller
    {

        private readonly IDoctorManager mDoctorManager;
        private readonly ViewModelMapper mViewModelMapper;

        public HomeController(IDoctorManager doctorManager, ViewModelMapper viewModelMapper)
        {
            mDoctorManager = doctorManager;
            mViewModelMapper = viewModelMapper;
        }

        public IActionResult Index(string filterString)
        {
            var doctorDtos = mDoctorManager.GetAllDoctors(filterString);
            var doctorViewModels = mViewModelMapper.Map(doctorDtos);

            return View(doctorViewModels);

        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(DoctorViewModel doctorVm)
        {

            var dto = mViewModelMapper.Map(doctorVm);

            mDoctorManager.AddNewDoctor(dto);

            return RedirectToAction("Index");
        }

        public IActionResult View(int doctorId)
        {
            return RedirectToAction("Index", "Prescription", new { doctorId = doctorId } );
        }

        public IActionResult Delete(int doctorId)
        {
            mDoctorManager.DeleteDoctor(new DoctorDto { Id = doctorId });

            var doctorDtos = mDoctorManager.GetAllDoctors(null);

            var doctorViewModels = mViewModelMapper.Map(doctorDtos);

            return View("Index", doctorViewModels);
        }


    }
}
