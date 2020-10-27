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
    public class MostPartnersController : Controller
    {
        private readonly CorporDbContext _context;
        private readonly IFileManager _fileManager;

        public MostPartnersController(CorporDbContext context,IFileManager fileManager )
        {
            _context = context;
            _fileManager = fileManager;
        }

        // GET: Admin/MostPartners
        public async Task<IActionResult> Index()
        {
            return View(await _context.MostPartners.ToListAsync());
        }

        // GET: Admin/MostPartners/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mostPartner = await _context.MostPartners
                .FirstOrDefaultAsync(m => m.Id == id);
            if (mostPartner == null)
            {
                return NotFound();
            }

            return View(mostPartner);
        }

        // GET: Admin/MostPartners/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/MostPartners/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,About,Title,Desc,Button,Upload")] MostPartner mostPartner)
        {
            if(mostPartner.Upload == null)
            {
                ModelState.AddModelError("Upload", "Sekil Mecburidir");
            }
            if (ModelState.IsValid)
            {
                var fileName = _fileManager.Upload(mostPartner.Upload);
                mostPartner.Photo = fileName;
                _context.Add(mostPartner);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(mostPartner);
        }

        // GET: Admin/MostPartners/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mostPartner = await _context.MostPartners.FindAsync(id);
            if (mostPartner == null)
            {
                return NotFound();
            }
            return View(mostPartner);
        }

        // POST: Admin/MostPartners/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,About,Title,Desc,Button,Photo,Upload")] MostPartner mostPartner)
        {
            if (id != mostPartner.Id)
            {
                return NotFound();
            }

            if (mostPartner.Upload == null)
            {
                ModelState.AddModelError("Upload", "Şəkil məcburidir");
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var oldFile = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads", mostPartner.Photo);
                    _fileManager.Delete(oldFile);
                    var fileName = _fileManager.Upload(mostPartner.Upload);
                    mostPartner.Photo = fileName;

                    _context.Update(mostPartner);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MostPartnerExists(mostPartner.Id))
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
            return View(mostPartner);
        }

        // GET: Admin/MostPartners/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mostPartner = await _context.MostPartners
                .FirstOrDefaultAsync(m => m.Id == id);
            if (mostPartner == null)
            {
                return NotFound();
            }

            return View(mostPartner);
        }

        // POST: Admin/MostPartners/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var mostPartner = await _context.MostPartners.FindAsync(id);
            try
            {
                _fileManager.Delete(mostPartner.Photo);
            }
            catch (FileNotFoundException)
            {
                _context.MostPartners.Remove(mostPartner);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            _context.MostPartners.Remove(mostPartner);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MostPartnerExists(int id)
        {
            return _context.MostPartners.Any(e => e.Id == id);
        }
    }
}
