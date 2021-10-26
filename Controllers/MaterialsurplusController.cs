using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using materialsurplus.Models;
using surplus.Models;
using Microsoft.AspNetCore.Http;
using System.IO; 
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;  
using pengambilan.Models;
using System.Data.SqlClient;



namespace surplus.Controllers
{
    public class MaterialsurplusController : Controller
    {
        private readonly SurplusContext _context;
        private readonly IWebHostEnvironment webHostEnvironment;
        public MaterialsurplusController(SurplusContext context , IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            webHostEnvironment = hostEnvironment;
        }

        // GET: Materialsurpluss
        public async Task<IActionResult> Index()
        {

      
        // return View(await _context.materialsurplus.Select(a => new {a.Id, a.Material_no, a.Qty, Qty = a.pengambilan.Sum() }).OrderByDescending(materialsurplus => materialsurplus.Id).ToListAsync());

          

        // var totalPostTask = _context.materialpengambilan.SumAsync(c => c.Qty);
        return View(await _context.materialsurplus.OrderByDescending(materialsurplus => materialsurplus.Id).ToListAsync());
       
        //  return View(await _context.materialsurplus.OrderByDescending(materialsurplus => materialsurplus.Id).Select(x => new _context.materialpengambilan { 
                            //  Prod = x, 
                            //  Count = _context.materialpengambilan
                            //            .Where(z => z.Material_no == x.Material_no)
                            //            .Sum(z => z.Qty) }).ToString().ToListAsync());
       
        // return View( await  _context.materialsurplus.(
        //      join pengambilan e on materialsurplus.material_no equals e.material_no
        //      select e => new PriceSum {
        //      {  
        //          PriceSum = e.qty.Sum()
        //      }).ToListAsync());
        //
                // var ap = await (from p in _context.materialsurplus
                //       join e in _context.materialpengambilan on p.Material_no equals e.Material_no
                //       select new Materialsurplus
                //                 {  
                //                     Id = p.Id,
                //                     Tgl_input = p.Tgl_input,
                //                     Source_material = p.Source_material,
                //                     Material_no = p.Material_no,
                //                     Old_material = p.Old_material,
                //                     Short_desc = p.Short_desc,
                //                     Description = p.Description,
                //                     Qty = p.Qty,
                //                     Nilai= p.Nilai,
                //                     Uom=p.Uom,
                //                     Posisi=p.Posisi,
                //                     Luas=p.Luas,
                //                     Sloc=p.Sloc,
                //                     Sbin=p.Sbin,
                //                     File_foto=p.File_foto
                //                 }).ToListAsync();
                //  return View(ap);
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
        public async Task<IActionResult> Create([Bind("Id,Tgl_input,Source_material,Material_no,Old_material,Short_desc,Description,Qty,Nilai,Uom,Posisi,Luas,Sloc,Sbin,File_foto")] Materialsurplus materialsurplus,IFormFile File_foto)
        {

         
            if (ModelState.IsValid)
            {

            string uniqueFileName = null;  //to contain the filename
            if (File_foto!= null)  //handle iformfile
            {
                string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "images");
                uniqueFileName =File_foto.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    File_foto.CopyTo(fileStream);
                }
            }
                materialsurplus.File_foto = uniqueFileName;


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
        public async Task<IActionResult> Edit(int id, [Bind("Id,Tgl_input,Source_material,Material_no,Old_material,Short_desc,Description,Qty,Nilai,Uom,Posisi,Luas,Sloc,Sbin,File_foto")] Materialsurplus materialsurplus,IFormFile File_foto)
        {
            if (id != materialsurplus.Id)
            {
                return NotFound();
            }


            if (ModelState.IsValid)
            {
                try
                {
                    string uniqueFileName = null;  //to contain the filename
                        if (File_foto!= null)  //handle iformfile
                        {
                            string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "images");
                            uniqueFileName =File_foto.FileName;
                            string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                            using (var fileStream = new FileStream(filePath, FileMode.Create))
                            {
                                File_foto.CopyTo(fileStream);
                            }
                        }
                     materialsurplus.File_foto = uniqueFileName;
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
