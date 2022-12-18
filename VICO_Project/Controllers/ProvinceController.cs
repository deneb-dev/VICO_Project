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
    public class ProvinceController : Controller
    {
        ProvinceRepository ProvinceRepository;

        public ProvinceController(ProvinceRepository ProvinceRepository)
        {
            this.ProvinceRepository = ProvinceRepository;
        }

        
        public IActionResult Index()
        {
            var role = HttpContext.Session.GetString("Role");
            if (role.Equals("Admin"))
            {
                var data = ProvinceRepository.Get();
                return View(data);
            }
            else
            if (role.Equals("Staff"))
            {
                var data = ProvinceRepository.Get();
                return View(data);
            }
            return RedirectToAction("Unauthorized", "ErrorPage");
        }



        //    



        // GET BY ID
        // GET
        public IActionResult Details(int id, Province province)
        {
            //var data = myContext.Provinces.Find(id);
            var data = ProvinceRepository.Get(id, province);
            return View(data);

        }

        // CREATE
        // GET
        public IActionResult Create()
        {
            return View();

        }
        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Province province)
        {
            if (ModelState.IsValid)
            {
                //var data = myContext
                var result = ProvinceRepository.Post(province);
                if (result > 0)
                    return RedirectToAction("Index");
            }
            return View();

        }

        // Edit
        // GET
        //[Authorize(Roles = "Staff")]
        public IActionResult Update(int id)
        {
            return View();

        }

        //POST
        //[Authorize(Roles = "Staff")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(int id, Province province)
        {
            if (ModelState.IsValid)
            {

                var result = ProvinceRepository.Put(id, province);
                if (result > 0)
                    return RedirectToAction("Index");
            }
            return View();
            }

        // Hapus
        // GET
        //[Authorize(Roles = "Staff")]
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
