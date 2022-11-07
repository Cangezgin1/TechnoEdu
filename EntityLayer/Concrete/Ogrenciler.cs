using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Ogrenciler
    {
        [Key]
        public int OgrenciID { get; set; }
        [StringLength(50)]
        public string AdSoyad { get; set; }
        [StringLength(25)]
        public string Sınıfı { get; set; }
        [StringLength(25)]
        public int Numarası { get; set; }
        [StringLength(25)]
        public string KullanıcıAdı { get; set; }
        [StringLength(25)]
        public string Sifre { get; set; }
    }
}
