﻿using Jint.Runtime.Debugger;
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
        ProvinceRepository ProvinceRepository;

        public StaffController(ProvinceRepository ProvinceRepository)
        {
            this.ProvinceRepository = ProvinceRepository;
        }


        public IActionResult Index()
        {
            var role = HttpContext.Session.GetString("Role");
            if (role.Equals("Staff"))
            {
                var data = ProvinceRepository.Get();
                return View(data);
            }


            return RedirectToAction("Unauthorized", "ErrorPage");
        }

        //public IActionResult KeluhanSatu()
        //{
        //    var data = KeluhanRepository.Get();
        //    return View(data);
        //}

        //GET BY ID
        public IActionResult Details(int id, Province province)
        {
            var data = ProvinceRepository.Get(id, province);
            return View(data);
        }

        // CREATE 
        // GET
        //[Authorize("Mhs")]
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