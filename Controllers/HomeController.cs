using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc.Rendering;
using materialsurplus.Models;
using surplus.Models;
using Microsoft.AspNetCore.Http;
using System.IO; 
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;  
using pengambilan.Models;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;


namespace surplus.Controllers
{
    public class HomeController : Controller
    {
         
        private readonly SurplusContext _context;
        private readonly IWebHostEnvironment webHostEnvironment;
        public  HomeController(SurplusContext context , IWebHostEnvironment hostEnvironment)
        {   
            
            _context = context;
            webHostEnvironment = hostEnvironment;
        }

        public async Task<IActionResult> Index()
        {
            ViewBag.Materials  = _context.materialpengambilan.ToList(); 
            return View(await _context.materialsurplus.ToListAsync());
        }

        public IActionResult Scan()
        {
            return View();
        }

         public IActionResult Resize()
        {
            return View();
        }


        public IActionResult Privacy()
        {
            return View();
        }

     //   [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        // public IActionResult Error()
        // {
        //     return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        // }
    }
}
