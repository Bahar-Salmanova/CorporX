using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CorporX.Data;
using CorporX.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CorporX.Controllers
{
    public class FaqController : Controller
    {
        private readonly CorporDbContext _context;
        public FaqController(CorporDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            FaqPageNewModel model = new FaqPageNewModel
            {
                Breadcrumb = _context.Breadcrumbs.FirstOrDefault(),
                AnswerQuestions = _context.AnswerQuestions.Take(3).ToList(),
                AskedQuestions = _context.AskedQuestions.Take(6).ToList()


            };
            return View(model);
        }
    }
}
