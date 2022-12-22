using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;


namespace VICO_Project.Controllers
{
    public class myAction : Controller
    {
        public ActionResult Index()
        {
            return View();
;        }
    }
}
