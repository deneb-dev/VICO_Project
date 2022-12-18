using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VICO_Project.Repositories.Data;
using VICO_Project.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VICO_Project.Controllers
{
    public class AccountController : Controller
    {
        AccountRepository accountRepository;

        public AccountController(AccountRepository accountRepository)
        {
            this.accountRepository = accountRepository;
        }
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }
        //
        public IActionResult AdminLayout()
        {
            return View();
        }
        public IActionResult Kontak()
        {
            return View();
        }
        public IActionResult Cuti()
        {
            return View();
        }
        public IActionResult News()
        {
            return View();
        }

        //

        public IActionResult Forgot()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        public IActionResult Update()
        {
            return View();
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult Update(int id, Update update)
        //{
            

        //    var data = accountRepository.Update(id, update);
        //    if (data > 0)
        //    {
        //        return RedirectToAction("Login", "Account");
        //    }
        //    return View();
        //}

        [HttpPost]
        public IActionResult Register(Register register)
        {
            var data = accountRepository.Register(register);
            if (data > 0)
            {
                return RedirectToAction("Login", "Account");
            }
            return View();
        }

        [HttpPost]
        //[ValidateAntiForgeryToken]
        public IActionResult Login(Login login)
        {
            if (ModelState.IsValid)
            {
                //statement mengambil data dari database sesuai dengan email dan password
                //return Id employee, FullName, Email, Role -> Masukkan ke ViewModels
                var data = accountRepository.Login(login);

                if (data != null)
                {
                    //inisialisasi nilai pada session
                    HttpContext.Session.SetString("Role", data.Role);
                    HttpContext.Session.SetInt32("Id", data.Id);
                    return RedirectToAction("Index", "Home");
                    
                }
                return RedirectToAction("Unauthorized", "ErrorPage");
            }
            return View();
        }






        //[HttpPost]

        //public IActionResult Forgot(Forgot forgot)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        //statement mengambil data dari database  email dan password
        //        //return Id employee, FullName, Email, Role -> Masukkan ke ViewModels
        //        var data = accountRepository.Forgot(forgot);

        //        if (data != null)
        //        {
        //            //inisialisasi nilai pada session
        //            HttpContext.Session.SetString("Role", data.Role);
        //            return RedirectToAction("Index", "Province");
        //        }
        //        return RedirectToAction("Unauthorized", "ErrorPage");
        //    }
        //    return View();
        //}
    }
}  
