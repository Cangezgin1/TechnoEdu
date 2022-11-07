using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-HD6BB26\\SQLEXPRESS;database=Aci_Kurs;integrated security=true");
        }

        public DbSet<Ogrenciler> ogrencilers { get; set; }

        public DbSet<Ogretmenler> ogretmenlers { get; set; }

        public DbSet<Deneme1> deneme1s { get; set; }

        public DbSet<Deneme1_Türkçe> deneme1_Türkçes { get; set; }

        public DbSet<Deneme1_SosyalBilgiler> deneme1_SosyalBilgilers { get; set; }

        public DbSet<Deneme1_Matematik> deneme1_Matematiks { get; set; }

        public DbSet<Deneme1_Fen> deneme1_Fens { get; set; }

    }
}
