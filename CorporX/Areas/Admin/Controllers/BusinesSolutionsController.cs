using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CorporX.Data;
using CorporX.Models;
using CorporX.Helpers;
using System.IO;

namespace CorporX.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BusinesSolutionsController : Controller
    {
        private readonly CorporDbContext _context;
        private readonly IFileManager _fileManager;

        public BusinesSolutionsController(CorporDbContext context, IFileManager fileManager)
        {
            _context = context;
            _fileManager = fileManager;
        }

        // GET: Admin/BusinesSolutions
        public async Task<IActionResult> Index()
        {
            return View(await _context.BusinesSolutions.ToListAsync());
        }

        // GET: Admin/BusinesSolutions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var businesSolution = await _context.BusinesSolutions
                .FirstOrDefaultAsync(m => m.Id == id);
            if (businesSolution == null)
            {
                return NotFound();
            }

            return View(businesSolution);
        }

        // GET: Admin/BusinesSolutions/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/BusinesSolutions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Text,Upload")] BusinesSolution businesSolution)
        {
            if (businesSolution.Upload == null)
            {
                ModelState.AddModelError("Upload", "Sekil Mecburidir");
            }
            if (ModelState.IsValid)
            {
                var fileName = _fileManager.Upload(businesSolution.Upload);
                businesSolution.Photo = fileName;
                _context.Add(businesSolution);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(businesSolution);
        }

        // GET: Admin/BusinesSolutions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var businesSolution = await _context.BusinesSolutions.FindAsync(id);
            if (businesSolution == null)
            {
                return NotFound();
            }
            return View(businesSolution);
        }

        // POST: Admin/BusinesSolutions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Text,Photo,Upload")] BusinesSolution businesSolution)
        {
            if (id != businesSolution.Id)
            {
                return NotFound();
            }
            if (businesSolution.Upload == null)
            {
                ModelState.AddModelError("Upload", "Şəkil məcburidir");
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var oldFile = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads", businesSolution.Photo);
                    _fileManager.Delete(oldFile);
                    var fileName = _fileManager.Upload(businesSolution.Upload);
                    businesSolution.Photo = fileName;

                    _context.Update(businesSolution);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BusinesSolutionExists(businesSolution.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(businesSolution);
        }

        // GET: Admin/BusinesSolutions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var businesSolution = await _context.BusinesSolutions
                .FirstOrDefaultAsync(m => m.Id == id);
            if (businesSolution == null)
            {
                return NotFound();
            }

            return View(businesSolution);
        }

        // POST: Admin/BusinesSolutions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var businesSolution = await _context.BusinesSolutions.FindAsync(id);
            try
            {
                _fileManager.Delete(businesSolution.Photo);
            }
            catch (FileNotFoundException)
            {
                _context.BusinesSolutions.Remove(businesSolution);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            _context.BusinesSolutions.Remove(businesSolution);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BusinesSolutionExists(int id)
        {
            return _context.BusinesSolutions.Any(e => e.Id == id);
        }
    }
}
