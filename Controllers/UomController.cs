using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using surplus.Models;
using uom.Models;

namespace surplus.Controllers
{
    public class UomController : Controller
    {
        private readonly SurplusContext _context;

        public UomController(SurplusContext context)
        {
            _context = context;
        }

        // GET: Uom
        public async Task<IActionResult> Index()
        {
            return View(await _context.masteruom.ToListAsync());
        }

        // GET: Uom/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var uom = await _context.masteruom
                .FirstOrDefaultAsync(m => m.Id == id);
            if (uom == null)
            {
                return NotFound();
            }

            return View(uom);
        }

        // GET: Uom/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Uom/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nama_uom")] Uom uom)
        {
            if (ModelState.IsValid)
            {
                _context.Add(uom);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(uom);
        }

        // GET: Uom/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var uom = await _context.masteruom.FindAsync(id);
            if (uom == null)
            {
                return NotFound();
            }
            return View(uom);
        }

        // POST: Uom/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nama_uom")] Uom uom)
        {
            if (id != uom.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(uom);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UomExists(uom.Id))
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
            return View(uom);
        }

        // GET: Uom/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var uom = await _context.masteruom
                .FirstOrDefaultAsync(m => m.Id == id);
            if (uom == null)
            {
                return NotFound();
            }

            return View(uom);
        }

        // POST: Uom/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var uom = await _context.masteruom.FindAsync(id);
            _context.masteruom.Remove(uom);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UomExists(int id)
        {
            return _context.masteruom.Any(e => e.Id == id);
        }
    }
}
