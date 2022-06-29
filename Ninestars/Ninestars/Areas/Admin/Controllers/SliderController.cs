using Business.Services;
using DAL.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Threading.Tasks;

namespace Ninestars.Areas.Admin.Controllers
{
    [Area("admin")]
    public class SliderController : Controller
    {
        private readonly ISliderService _sliderService;
        private readonly IWebHostEnvironment _env;

        public SliderController(ISliderService sliderService, 
                                IWebHostEnvironment env)
        {
            _sliderService = sliderService;
            _env = env;
        }

        // GET: SliderController
        public async Task<IActionResult> Index()
        {
            var data = await _sliderService.GetAll();
            return View(data);
        }

        // GET: SliderController/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var data = await _sliderService.Get(id);
            return View(data);
        }

        // GET: SliderController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SliderController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Slider slider)
        {
            if (slider.ImageFile is null)
            {
                ModelState.AddModelError("ImageFile", "cannot be null");
                return View();
            }

            decimal size = (decimal)slider.ImageFile.Length / 1024 / 1024;
            if (size > 3)
            {
                ModelState.AddModelError("ImageFile", "cannot be more than 3mb");
                return View();
            }

            if (!slider.ImageFile.ContentType.Contains("image/"))
            {
                ModelState.AddModelError("ImageFile", "must be image");
                return View();
            }

            var fileName = slider.ImageFile.FileName;

            if (fileName.Length > 64)
            {
                fileName = fileName.Substring(fileName.Length - 64, 64);
            }

            var newFileName = Guid.NewGuid().ToString() + fileName;
            var path = Path.Combine(_env.WebRootPath, "assets", "uploads", "images", newFileName);
            using (FileStream stream = new FileStream(path, FileMode.Create))
            {
                await slider.ImageFile.CopyToAsync(stream);
            }

            slider.ImageUrl = newFileName;
            slider.CreatedDate = DateTime.Now;
            await _sliderService.Create(slider);
            return RedirectToAction("Index");
        }

        // GET: SliderController/Edit/5
        public async Task<IActionResult> Update(int id)
        {
            var data = await _sliderService.Get(id);
            return View(data);
        }

        // POST: SliderController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update( Slider slider)
        {
            if (slider.ImageFile is null)
            {
                ModelState.AddModelError("ImageFile", "cannot be null");
                return View();
            }

            decimal size = (decimal)slider.ImageFile.Length / 1024 / 1024;
            if (size > 3)
            {
                ModelState.AddModelError("ImageFile", "cannot be more than 3mb");
                return View();
            }

            if (!slider.ImageFile.ContentType.Contains("image/"))
            {
                ModelState.AddModelError("ImageFile", "must be image");
                return View();
            }

            var fileName = slider.ImageFile.FileName;

            if (fileName.Length > 64)
            {
                fileName = fileName.Substring(fileName.Length - 64, 64);
            }

            var newFileName = Guid.NewGuid().ToString() + fileName;
            var path = Path.Combine(_env.WebRootPath, "assets", "uploads", "images", newFileName);
            using (FileStream stream = new FileStream(path, FileMode.Create))
            {
                await slider.ImageFile.CopyToAsync(stream);
            }

            var data = await _sliderService.Get(slider.Id);


            slider.ImageUrl = newFileName;
            slider.UpdatedDate = DateTime.Now;
            await _sliderService.Update(data);
            return RedirectToAction("Index", "slider");         
        }

        // GET: SliderController/Delete/5
        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var slider = await _sliderService.Get(id);
            return View(slider);
        }

        // POST: SliderController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id, Slider slider)
        {
             await _sliderService.Delete(slider.Id);

            return RedirectToAction("Index", "Slider");
        }
    }
}
