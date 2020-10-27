using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CorporX.Data;
using CorporX.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CorporX.Controllers
{
    public class ProjectDetailsController : Controller
    {
        private readonly CorporDbContext _context;

        public ProjectDetailsController(CorporDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {

            ProjectDetailsViewModel model = new ProjectDetailsViewModel
            {
                Breadcrumb = _context.Breadcrumbs.FirstOrDefault(),
                ProjectDescription=_context.ProjectDescriptions.FirstOrDefault(),
                ProjectDescriptionItem=_context.ProjectDescriptionItems.Take(4).ToList(),
                

            };
            return View(model);
        }
    }
}
