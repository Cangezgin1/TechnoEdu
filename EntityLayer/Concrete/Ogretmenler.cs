using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Ogretmenler
    {
        [Key]
        public int OgretmenID { get; set; }
        [StringLength(50)]
        public string AdSoyad { get; set; }
        [StringLength(25)]
        public string Brans { get; set; }
        [StringLength(15)]
        public string TelefonNo { get; set; }
        [StringLength(25)]
        public string KullanıcıAdı { get; set; }
        [StringLength(25)]
        public string Sifre { get; set; }
    }
}
