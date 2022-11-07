using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "deneme1s",
                columns: table => new
                {
                    DenemeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DenemeTarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DenemeTür = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_deneme1s", x => x.DenemeID);
                });

            migrationBuilder.CreateTable(
                name: "ogrencilers",
                columns: table => new
                {
                    OgrenciID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdSoyad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Sınıfı = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    Numarası = table.Column<int>(type: "int", maxLength: 25, nullable: false),
                    KullanıcıAdı = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    Sifre = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ogrencilers", x => x.OgrenciID);
                });

            migrationBuilder.CreateTable(
                name: "ogretmenlers",
                columns: table => new
                {
                    OgretmenID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdSoyad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Brans = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    TelefonNo = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    KullanıcıAdı = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    Sifre = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ogretmenlers", x => x.OgretmenID);
                });

            migrationBuilder.CreateTable(
                name: "deneme1_Fens",
                columns: table => new
                {
                    FenSoruID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Soru = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    A = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    B = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    C = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    D = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    E = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DogruCevap = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DenemeID = table.Column<int>(type: "int", nullable: false),
                    Deneme1DenemeID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_deneme1_Fens", x => x.FenSoruID);
                    table.ForeignKey(
                        name: "FK_deneme1_Fens_deneme1s_Deneme1DenemeID",
                        column: x => x.Deneme1DenemeID,
                        principalTable: "deneme1s",
                        principalColumn: "DenemeID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "deneme1_Matematiks",
                columns: table => new
                {
                    MatematikSoruID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Soru = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    A = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    B = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    C = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    D = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    E = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DogruCevap = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DenemeID = table.Column<int>(type: "int", nullable: false),
                    Deneme1DenemeID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_deneme1_Matematiks", x => x.MatematikSoruID);
                    table.ForeignKey(
                        name: "FK_deneme1_Matematiks_deneme1s_Deneme1DenemeID",
                        column: x => x.Deneme1DenemeID,
                        principalTable: "deneme1s",
                        principalColumn: "DenemeID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "deneme1_SosyalBilgilers",
                columns: table => new
                {
                    SosyalSoruID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Soru = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    A = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    B = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    C = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    D = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    E = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DogruCevap = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DenemeID = table.Column<int>(type: "int", nullable: false),
                    Deneme1DenemeID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_deneme1_SosyalBilgilers", x => x.SosyalSoruID);
                    table.ForeignKey(
                        name: "FK_deneme1_SosyalBilgilers_deneme1s_Deneme1DenemeID",
                        column: x => x.Deneme1DenemeID,
                        principalTable: "deneme1s",
                        principalColumn: "DenemeID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "deneme1_Türkçes",
                columns: table => new
                {
                    TürkçeSoruID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Soru = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    A = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    B = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    C = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    D = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    E = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DogruCevap = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DenemeID = table.Column<int>(type: "int", nullable: false),
                    Deneme1DenemeID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_deneme1_Türkçes", x => x.TürkçeSoruID);
                    table.ForeignKey(
                        name: "FK_deneme1_Türkçes_deneme1s_Deneme1DenemeID",
                        column: x => x.Deneme1DenemeID,
                        principalTable: "deneme1s",
                        principalColumn: "DenemeID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_deneme1_Fens_Deneme1DenemeID",
                table: "deneme1_Fens",
                column: "Deneme1DenemeID");

            migrationBuilder.CreateIndex(
                name: "IX_deneme1_Matematiks_Deneme1DenemeID",
                table: "deneme1_Matematiks",
                column: "Deneme1DenemeID");

            migrationBuilder.CreateIndex(
                name: "IX_deneme1_SosyalBilgilers_Deneme1DenemeID",
                table: "deneme1_SosyalBilgilers",
                column: "Deneme1DenemeID");

            migrationBuilder.CreateIndex(
                name: "IX_deneme1_Türkçes_Deneme1DenemeID",
                table: "deneme1_Türkçes",
                column: "Deneme1DenemeID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "deneme1_Fens");

            migrationBuilder.DropTable(
                name: "deneme1_Matematiks");

            migrationBuilder.DropTable(
                name: "deneme1_SosyalBilgilers");

            migrationBuilder.DropTable(
                name: "deneme1_Türkçes");

            migrationBuilder.DropTable(
                name: "ogrencilers");

            migrationBuilder.DropTable(
                name: "ogretmenlers");

            migrationBuilder.DropTable(
                name: "deneme1s");
        }
    }
}
