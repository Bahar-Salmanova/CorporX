using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CorporX.Controllers
{
    public class ServicesDetailsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
