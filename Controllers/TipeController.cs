using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using surplus.Models;
using tipe.Models;

namespace surplus.Controllers
{
    public class TipeController : Controller
    {
        private readonly SurplusContext _context;

        public TipeController(SurplusContext context)
        {
            _context = context;
        }

        // GET: Tipe
        public async Task<IActionResult> Index()
        {
            return View(await _context.mastertipe.ToListAsync());
        }

        // GET: Tipe/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipe = await _context.mastertipe
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tipe == null)
            {
                return NotFound();
            }

            return View(tipe);
        }

        // GET: Tipe/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Tipe/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Kode_tipe,Nama_tipe")] Tipe tipe)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tipe);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tipe);
        }

        // GET: Tipe/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipe = await _context.mastertipe.FindAsync(id);
            if (tipe == null)
            {
                return NotFound();
            }
            return View(tipe);
        }

        // POST: Tipe/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Kode_tipe,Nama_tipe")] Tipe tipe)
        {
            if (id != tipe.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tipe);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TipeExists(tipe.Id))
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
            return View(tipe);
        }

        // GET: Tipe/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipe = await _context.mastertipe
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tipe == null)
            {
                return NotFound();
            }

            return View(tipe);
        }

        // POST: Tipe/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tipe = await _context.mastertipe.FindAsync(id);
            _context.mastertipe.Remove(tipe);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TipeExists(int id)
        {
            return _context.mastertipe.Any(e => e.Id == id);
        }
    }
}
