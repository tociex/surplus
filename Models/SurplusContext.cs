using Microsoft.EntityFrameworkCore;
using tipe.Models;
using uom.Models;
using subtipe.Models;
namespace surplus.Models{
    public class SurplusContext:DbContext
    {
         public SurplusContext(DbContextOptions<SurplusContext> options):base(options){

         }

         public DbSet<Tipe> mastertipe{get; set;}

         public DbSet<Uom> masteruom{get; set;}

         public DbSet<Subtipe> mastersubtipe{get; set;}

        
    }

}