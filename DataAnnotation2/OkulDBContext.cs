using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAnnotation2
{
   public class OkulDBContext:DbContext
    {
        public OkulDBContext(): base("Server=CERENKALPC;Database=DataAnnotation2DB;Uid=sa;Pwd=123")
        {

        }
        public DbSet<Okul> Okullar { get; set; }
        public DbSet<Mudur> Mudurler { get; set; }
        public DbSet<Ogretmen> Ogretmenler { get; set; }
        public DbSet<Sinif> Siniflar { get; set; }
    }
}
