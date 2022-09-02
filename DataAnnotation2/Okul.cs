using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAnnotation2
{
    public class Okul
    {
        
        public int OkulID { get; set; }
        public string OkulAdi { get; set; }
        public int SinifSayisi { get; set; }
        public Mudur Mudur { get; set; } //1 e 1 de şart

        //bir e çok
        public List<Ogretmen> Ogretmenler { get; set; }
    }
}
