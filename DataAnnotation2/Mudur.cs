using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAnnotation2
{
   public class Mudur
    {
        [Key,ForeignKey("Okul")]
        public int MudurID { get; set; }
        public string Adi { get; set; }
        public string MezunOlduguOkul { get; set; }

        public Okul Okul { get; set; } //1 e bir de şart
    }
}
