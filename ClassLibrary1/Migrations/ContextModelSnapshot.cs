// <auto-generated />
using System;
using DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccessLayer.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EntityLayer.Concrete.Deneme1", b =>
                {
                    b.Property<int>("DenemeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DenemeTarih")
                        .HasColumnType("datetime2");

                    b.Property<string>("DenemeTür")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DenemeID");

                    b.ToTable("deneme1s");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Deneme1_Fen", b =>
                {
                    b.Property<int>("FenSoruID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("A")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("B")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("C")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("D")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Deneme1DenemeID")
                        .HasColumnType("int");

                    b.Property<int>("DenemeID")
                        .HasColumnType("int");

                    b.Property<string>("DogruCevap")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("E")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Soru")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FenSoruID");

                    b.HasIndex("Deneme1DenemeID");

                    b.ToTable("deneme1_Fens");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Deneme1_Matematik", b =>
                {
                    b.Property<int>("MatematikSoruID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("A")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("B")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("C")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("D")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Deneme1DenemeID")
                        .HasColumnType("int");

                    b.Property<int>("DenemeID")
                        .HasColumnType("int");

                    b.Property<string>("DogruCevap")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("E")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Soru")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MatematikSoruID");

                    b.HasIndex("Deneme1DenemeID");

                    b.ToTable("deneme1_Matematiks");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Deneme1_SosyalBilgiler", b =>
                {
                    b.Property<int>("SosyalSoruID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("A")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("B")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("C")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("D")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Deneme1DenemeID")
                        .HasColumnType("int");

                    b.Property<int>("DenemeID")
                        .HasColumnType("int");

                    b.Property<string>("DogruCevap")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("E")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Soru")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SosyalSoruID");

                    b.HasIndex("Deneme1DenemeID");

                    b.ToTable("deneme1_SosyalBilgilers");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Deneme1_Türkçe", b =>
                {
                    b.Property<int>("TürkçeSoruID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("A")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("B")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("C")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("D")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Deneme1DenemeID")
                        .HasColumnType("int");

                    b.Property<int>("DenemeID")
                        .HasColumnType("int");

                    b.Property<string>("DogruCevap")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("E")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Soru")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TürkçeSoruID");

                    b.HasIndex("Deneme1DenemeID");

                    b.ToTable("deneme1_Türkçes");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Ogrenciler", b =>
                {
                    b.Property<int>("OgrenciID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AdSoyad")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("KullanıcıAdı")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Numarası")
                        .HasMaxLength(25)
                        .HasColumnType("int");

                    b.Property<string>("Sifre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sınıfı")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("OgrenciID");

                    b.ToTable("ogrencilers");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Ogretmenler", b =>
                {
                    b.Property<int>("OgretmenID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AdSoyad")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Brans")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("KullanıcıAdı")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("Sifre")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("TelefonNo")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("OgretmenID");

                    b.ToTable("ogretmenlers");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Deneme1_Fen", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Deneme1", "Deneme1")
                        .WithMany("deneme1_Fens")
                        .HasForeignKey("Deneme1DenemeID");

                    b.Navigation("Deneme1");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Deneme1_Matematik", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Deneme1", "Deneme1")
                        .WithMany("deneme1_Matematiks")
                        .HasForeignKey("Deneme1DenemeID");

                    b.Navigation("Deneme1");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Deneme1_SosyalBilgiler", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Deneme1", "Deneme1")
                        .WithMany("deneme1_SosyalBilgilers")
                        .HasForeignKey("Deneme1DenemeID");

                    b.Navigation("Deneme1");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Deneme1_Türkçe", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Deneme1", "Deneme1")
                        .WithMany("deneme1_Türkçes")
                        .HasForeignKey("Deneme1DenemeID");

                    b.Navigation("Deneme1");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Deneme1", b =>
                {
                    b.Navigation("deneme1_Fens");

                    b.Navigation("deneme1_Matematiks");

                    b.Navigation("deneme1_SosyalBilgilers");

                    b.Navigation("deneme1_Türkçes");
                });
#pragma warning restore 612, 618
        }
    }
}
