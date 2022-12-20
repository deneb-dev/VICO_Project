using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VICO_Project.Models;
using VICO_Project.Repositories.Data;

namespace VICO_Project.Controllers
{
    public class AdminController : Controller
    {
        ProvinceRepository ProvinceRepository;

        public AdminController(ProvinceRepository ProvinceRepository)
        {
            this.ProvinceRepository = ProvinceRepository;
        }


        public IActionResult Index(int id)
        {     
            var data = ProvinceRepository.Get();
            return View(data);
            return RedirectToAction("Unauthorized", "ErrorPage");
        }

        //GET BY ID
        public IActionResult Details(int id, Province province)
        {
            var data = ProvinceRepository.Get(id, province);
            return View(data);
        }

        // CREATE 
        // GET
        //[Authorize("")]
        public IActionResult Create()
        {
            return View();
        }
        // POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Province province)
        {
            if (ModelState.IsValid)
            {

                var result = ProvinceRepository.Post(province);
                if (result > 0)
                    return RedirectToAction("Index");
            }
            return View();
        }

        // UPDATE
        // GET
        [HttpGet]
        public ActionResult Update()
        {

            return View();
        }
        // POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Update(int id, Province province)
        {
            if (ModelState.IsValid)
            {
                var result = ProvinceRepository.Put(id, province);
                if (result > 0)
                    return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Delete(Province province)
        {
            if (ModelState.IsValid)
            {
                //myContext.Provinces.Remove(province);
                var result = ProvinceRepository.Delete(province);
                if (result > 0)
                    return RedirectToAction("Index");
            }
            return View();

        }
    }
}
