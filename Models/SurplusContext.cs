using Microsoft.EntityFrameworkCore;
using tipe.Models;
using uom.Models;
using subtipe.Models;
using material.Models;
using materialsurplus.Models;
namespace surplus.Models{
    public class SurplusContext:DbContext
    {
         public SurplusContext(DbContextOptions<SurplusContext> options):base(options){

         }

         public DbSet<Tipe> mastertipe{get; set;}

         public DbSet<Uom> masteruom{get; set;}

         public DbSet<Subtipe> mastersubtipe{get; set;}


         public DbSet<Material> mastermaterial{get; set;}


         public DbSet<Materialsurplus> materialsurplus{get; set;}


        
        
    }
    

}