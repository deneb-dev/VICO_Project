using Jint.Runtime.Debugger;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VICO_Project.Context;
using VICO_Project.Models;
using VICO_Project.Repositories.Data;
using System.Linq;
using Microsoft.AspNetCore.Authorization;

namespace VICO_Project.Controllers
{
    public class StaffController : Controller
    {
        CutiRepository CutiRepository;

        public StaffController(CutiRepository CutiRepository)
        {
            this.CutiRepository = CutiRepository;
        }


        public IActionResult Index()
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
