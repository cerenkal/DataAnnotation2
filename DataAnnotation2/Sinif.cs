using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAnnotation2
{
   public class Sinif
    {
        public int SinifID { get; set; }
        public int SiraSayisi { get; set; }

        //çoka çok bağlantı
        public List<Ogretmen> Ogretmenler { get; set; }
    }
}
