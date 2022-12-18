using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VICO_Project.Controllers
{
    public class ErrorPageController : Controller
    {
        public IActionResult Unauthorized()
        {
            return View();
        }
    }
}
