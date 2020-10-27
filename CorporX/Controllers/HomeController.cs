
using CorporX.Data;
using CorporX.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Linq;

namespace CorporX.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly CorporDbContext _context;

        public HomeController(ILogger<HomeController> logger, CorporDbContext context)
        {
            _context = context;
            _logger = logger;
        }

        public IActionResult Index()
        {
            HomeViewModel model = new HomeViewModel
            {
                Mpartner = _context.MostPartners.FirstOrDefault(),
                Promos = _context.Promos.Take(3).ToList(),
                BusinesSolution = _context.BusinesSolutions.FirstOrDefault(),
                BusinesSolutionItem = _context.BusinesSolutionItems.ToList(),
                Services = _context.Services.ToList(),
                Download = _context.Downloads.FirstOrDefault(),
                ButtonDownloads = _context.ButtonDownloads.ToList(),
                Projects = _context.Projects.ToList(),
                News = _context.News.Take(3).ToList(),
                Clients = _context.Clients.Take(3).ToList(),
                Members = _context.Members.Take(3).Include(m => m.MemberLinks).ToList(),
                MemberLinks=_context.MemberLinks.Include(m=>m.Members).ToList()
            };
            return View(model);
        }

    }
}
