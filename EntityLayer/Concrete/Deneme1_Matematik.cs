using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Deneme1_Matematik
    {
        [Key]
        public int MatematikSoruID { get; set; }
        public string Soru { get; set; }
        public string A { get; set; }
        public string B { get; set; }
        public string C { get; set; }
        public string D { get; set; }
        public string E { get; set; }
        public string DogruCevap { get; set; }

        public int DenemeID { get; set; }
        public virtual Deneme1 Deneme1 { get; set; }
    }
}
