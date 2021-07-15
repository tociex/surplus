using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using subtipe.Models;
using surplus.Models;

namespace surplus.Controllers
{
    public class SubtipeController : Controller
    {
        private readonly SurplusContext _context;

        public SubtipeController(SurplusContext context)
        {
            _context = context;
        }

        // GET: Subtipe
        public async Task<IActionResult> Index()
        {
            return View(await _context.mastersubtipe.ToListAsync());
        }

        // GET: Subtipe/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var subtipe = await _context.mastersubtipe
                .FirstOrDefaultAsync(m => m.Id == id);
            if (subtipe == null)
            {
                return NotFound();
            }

            return View(subtipe);
        }

        // GET: Subtipe/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Subtipe/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Id_tipe,Kode_subtipe,Sub_tipe")] Subtipe subtipe)
        {
            if (ModelState.IsValid)
            {
                _context.Add(subtipe);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(subtipe);
        }

        // GET: Subtipe/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var subtipe = await _context.mastersubtipe.FindAsync(id);
            if (subtipe == null)
            {
                return NotFound();
            }
            return View(subtipe);
        }

        // POST: Subtipe/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Id_tipe,Kode_subtipe,Sub_tipe")] Subtipe subtipe)
        {
            if (id != subtipe.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(subtipe);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SubtipeExists(subtipe.Id))
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
            return View(subtipe);
        }

        // GET: Subtipe/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var subtipe = await _context.mastersubtipe
                .FirstOrDefaultAsync(m => m.Id == id);
            if (subtipe == null)
            {
                return NotFound();
            }

            return View(subtipe);
        }

        // POST: Subtipe/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var subtipe = await _context.mastersubtipe.FindAsync(id);
            _context.mastersubtipe.Remove(subtipe);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SubtipeExists(int id)
        {
            return _context.mastersubtipe.Any(e => e.Id == id);
        }
    }
}
