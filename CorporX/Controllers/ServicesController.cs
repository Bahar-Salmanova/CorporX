using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CorporX.Data;
using CorporX.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CorporX.Controllers
{
    public class ServicesController : Controller
    {
        private readonly CorporDbContext _context;

        public ServicesController(CorporDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            ServicesViewModel model = new ServicesViewModel
            {
                Breadcrumb = _context.Breadcrumbs.FirstOrDefault(),
                Promos = _context.Promos.Take(3).ToList(),
                Services = _context.Services.ToList(),
                Partners = _context.Partners.ToList()



            };



            return View(model);
        }
    }
}
