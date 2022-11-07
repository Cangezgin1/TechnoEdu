using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Deneme1
    {
        [Key]
        public int DenemeID { get; set; }
        public DateTime DenemeTarih { get; set; }
        public string DenemeTür { get; set; }

        public ICollection<Deneme1_Türkçe> deneme1_Türkçes { get; set; }
        public ICollection<Deneme1_SosyalBilgiler> deneme1_SosyalBilgilers { get; set; }
        public ICollection<Deneme1_Matematik> deneme1_Matematiks { get; set; }
        public ICollection<Deneme1_Fen> deneme1_Fens { get; set; }

    }
}
