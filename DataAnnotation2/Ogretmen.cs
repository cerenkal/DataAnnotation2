using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAnnotation2
{
   public class Ogretmen
    {
        public int OgretmenID { get; set; }
        public string OgretmenAdi { get; set; }
        public string OgretmenSoyadi { get; set; }
        public int Yas { get; set; }


        //bire çok bağlantının bir kısmı
        public int OkulID { get; set; }
        public Okul Okul { get; set; }

        //çoka çok bağlantı
        public List<Sinif> Siniflar { get; set; }
    }
}
