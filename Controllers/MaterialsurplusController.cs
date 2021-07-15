using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using materialsurplus.Models;
using surplus.Models;

namespace surplus.Controllers
{
    public class MaterialsurplusController : Controller
    {
        private readonly SurplusContext _context;

        public MaterialsurplusController(SurplusContext context)
        {
            _context = context;
        }

        // GET: Materialsurplus
        public async Task<IActionResult> Index()
        {
            return View(await _context.materialsurplus.ToListAsync());
        }

        // GET: Materialsurplus/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var materialsurplus = await _context.materialsurplus
                .FirstOrDefaultAsync(m => m.Id == id);
            if (materialsurplus == null)
            {
                return NotFound();
            }

            return View(materialsurplus);
        }

        // GET: Materialsurplus/Create
        public IActionResult Create()
        {
            ViewBag.Departments = _context.masteruom.ToList();
            ViewBag.Materials = _context.mastermaterial.ToList();
            ViewBag.Tipes = _context.mastertipe.ToList();
            ViewBag.Subtipes = _context.mastersubtipe.ToList();
            return View();
        }

        // POST: Materialsurplus/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Tgl_input,Source_material,Material_no,Old_material,Short_desc,Description,Qty,Nilai,Uom,Posisi,Luas,Sloc,Sbin,File_foto")] Materialsurplus materialsurplus)
        {
            if (ModelState.IsValid)
            {
                _context.Add(materialsurplus);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(materialsurplus);
        }

        // GET: Materialsurplus/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var materialsurplus = await _context.materialsurplus.FindAsync(id);
            if (materialsurplus == null)
            {
                return NotFound();
            }

            ViewBag.Departments = _context.masteruom.ToList();
            ViewBag.Materials = _context.mastermaterial.ToList();
            ViewBag.Tipes = _context.mastertipe.ToList();
            ViewBag.Subtipes = _context.mastersubtipe.ToList();
            return View(materialsurplus);
        }

        // POST: Materialsurplus/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Tgl_input,Source_material,Material_no,Old_material,Short_desc,Description,Qty,Nilai,Uom,Posisi,Luas,Sloc,Sbin,File_foto")] Materialsurplus materialsurplus)
        {
            if (id != materialsurplus.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(materialsurplus);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MaterialsurplusExists(materialsurplus.Id))
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
            return View(materialsurplus);
        }

        // GET: Materialsurplus/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var materialsurplus = await _context.materialsurplus
                .FirstOrDefaultAsync(m => m.Id == id);
            if (materialsurplus == null)
            {
                return NotFound();
            }

            return View(materialsurplus);
        }

        // POST: Materialsurplus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var materialsurplus = await _context.materialsurplus.FindAsync(id);
            _context.materialsurplus.Remove(materialsurplus);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MaterialsurplusExists(int id)
        {
            return _context.materialsurplus.Any(e => e.Id == id);
        }
    }
}
