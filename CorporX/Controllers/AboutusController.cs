using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CorporX.Data;
using CorporX.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CorporX.Controllers
{
    public class AboutusController : Controller
    {
        private readonly CorporDbContext _context;
       public AboutusController(CorporDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {

            AboutViewModel model = new AboutViewModel
            {
                Breadcrumb=_context.Breadcrumbs.FirstOrDefault(),
                Promos = _context.Promos.Take(3).ToList(),
                Mission=_context.Missions.FirstOrDefault(),
                DeliverService=_context.DeliverServices.Take(4).ToList(),
                Members = _context.Members.Take(3).Include(m => m.MemberLinks).ToList(),
                MemberLinks = _context.MemberLinks.Include(m => m.Members).ToList(),
                Clients = _context.Clients.Take(3).ToList(),
                Partners=_context.Partners.ToList()



            };
            return View(model);
        }
    }
}
