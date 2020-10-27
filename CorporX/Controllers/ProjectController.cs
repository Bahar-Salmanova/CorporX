using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CorporX.Data;
using CorporX.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CorporX.Controllers
{
    public class ProjectController : Controller
    {
        private readonly CorporDbContext _context;
        public ProjectController(CorporDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            ProjectViewModel model = new ProjectViewModel
            {
                Breadcrumb = _context.Breadcrumbs.FirstOrDefault(),
                Clients = _context.Clients.Take(3).ToList(),
                Partners = _context.Partners.ToList(),
                Projects=_context.Projects.ToList(),
                Packages=_context.Packages.Take(3).ToList()


            }; 
            return View(model);
        }
    }
}
