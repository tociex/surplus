using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using luasan.Models;
using surplus.Models;

namespace surplus.Controllers
{
    public class LuasanController : Controller
    {
        private readonly SurplusContext _context;

        public LuasanController(SurplusContext context)
        {
            _context = context;
        }

        // GET: Luasan
        public async Task<IActionResult> Index()
        {
            return View(await _context.masterluasan.ToListAsync());
        }

        // GET: Luasan/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var luasan = await _context.masterluasan
                .FirstOrDefaultAsync(m => m.Id == id);
            if (luasan == null)
            {
                return NotFound();
            }

            return View(luasan);
        }

        // GET: Luasan/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Luasan/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Lokasi,Kapasitas")] Luasan luasan)
        {
            if (ModelState.IsValid)
            {
                _context.Add(luasan);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(luasan);
        }

        // GET: Luasan/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var luasan = await _context.masterluasan.FindAsync(id);
            if (luasan == null)
            {
                return NotFound();
            }
            return View(luasan);
        }

        // POST: Luasan/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Lokasi,Kapasitas")] Luasan luasan)
        {
            if (id != luasan.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(luasan);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LuasanExists(luasan.Id))
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
            return View(luasan);
        }

        // GET: Luasan/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var luasan = await _context.masterluasan
                .FirstOrDefaultAsync(m => m.Id == id);
            if (luasan == null)
            {
                return NotFound();
            }

            return View(luasan);
        }

        // POST: Luasan/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var luasan = await _context.masterluasan.FindAsync(id);
            _context.masterluasan.Remove(luasan);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LuasanExists(int id)
        {
            return _context.masterluasan.Any(e => e.Id == id);
        }
    }
}
