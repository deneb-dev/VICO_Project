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
        CutiRepository CutiRepository;

        public AdminController(CutiRepository CutiRepository)
        {
            this.CutiRepository = CutiRepository;
        }


        public IActionResult Index(int id)
        {

            var data = CutiRepository.Get();
            return View(data); 
            return RedirectToAction("Unauthorized", "ErrorPageController");
        }




        //GET BY ID
        public IActionResult Details(int id, Cuti cuti)
        {
            var data = CutiRepository.Get(id, cuti);
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
        public IActionResult Create(Cuti cuti)
        {
            if (ModelState.IsValid)
            {

                var result = CutiRepository.Post(cuti);
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
        public ActionResult Update(int id, Cuti cuti)
        {
            if (ModelState.IsValid)
            {
                var result = CutiRepository.Put(id, cuti);
                if (result > 0)
                    return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Delete(Cuti cuti)
        {
            if (ModelState.IsValid)
            {
                //myContext.Provinces.Remove(cuti);
                var result = CutiRepository.Delete(cuti);
                if (result > 0)
                    return RedirectToAction("Index");
            }
            return View();

        }
    }
}
