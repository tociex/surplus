using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using pengambilan.Models;
using surplus.Models;
using materialsurplus.Models;

namespace surplus.Controllers
{
    public class PengambilanController : Controller
    {
        private readonly SurplusContext _context;

        public PengambilanController(SurplusContext context)
        {
            _context = context;
        }

        // GET: Pengambilan
        public async Task<IActionResult> Index()
        {
            return View(await _context.materialpengambilan.ToListAsync());
        }
        
        // material surplus
        public async Task<IActionResult> Surplus()
        {    

            ViewBag.Materialssurplus = _context.materialsurplus.ToList();
            return View(await _context.materialpengambilan.ToListAsync());
        }

        // GET: Pengambilan/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pengambilan = await _context.materialpengambilan
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pengambilan == null)
            {
                return NotFound();
            }

            return View(pengambilan);
        }

        // GET: Pengambilan/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Pengambilan/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Tanggal,Material_no,Qty,Nama_pengambil,Area,Keterangan")] Pengambilan pengambilan)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pengambilan);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pengambilan);
        }

        // GET: Pengambilan/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pengambilan = await _context.materialpengambilan.FindAsync(id);
            if (pengambilan == null)
            {
                return NotFound();
            }
            return View(pengambilan);
        }

        // POST: Pengambilan/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Tanggal,Material_no,Qty,Nama_pengambil,Area,Keterangan")] Pengambilan pengambilan)
        {
            if (id != pengambilan.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pengambilan);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PengambilanExists(pengambilan.Id))
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
            return View(pengambilan);
        }

        // GET: Pengambilan/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pengambilan = await _context.materialpengambilan
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pengambilan == null)
            {
                return NotFound();
            }

            return View(pengambilan);
        }

        // POST: Pengambilan/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pengambilan = await _context.materialpengambilan.FindAsync(id);
            _context.materialpengambilan.Remove(pengambilan);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PengambilanExists(int id)
        {
            return _context.materialpengambilan.Any(e => e.Id == id);
        }
    }
}
