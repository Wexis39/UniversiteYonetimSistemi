using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UniversiteYonetimSistemi.DAL.Migrations
{
    /// <inheritdoc />
    public partial class firstMig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Fakulteler",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FakulteAdi = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fakulteler", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Kullanicilar",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    KullaniciAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sifre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rol = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kullanicilar", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Bolumler",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BolumAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FakulteID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bolumler", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Bolumler_Fakulteler_FakulteID",
                        column: x => x.FakulteID,
                        principalTable: "Fakulteler",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Dersler",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DersAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kredi = table.Column<int>(type: "int", nullable: false),
                    BolumID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dersler", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Dersler_Bolumler_BolumID",
                        column: x => x.BolumID,
                        principalTable: "Bolumler",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ogrenciler",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Soyad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TCNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DogumTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Eposta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BolumID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ogrenciler", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Ogrenciler_Bolumler_BolumID",
                        column: x => x.BolumID,
                        principalTable: "Bolumler",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OgretimGorevlileri",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Soyad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Eposta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BolumID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OgretimGorevlileri", x => x.ID);
                    table.ForeignKey(
                        name: "FK_OgretimGorevlileri_Bolumler_BolumID",
                        column: x => x.BolumID,
                        principalTable: "Bolumler",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OgrenciDersKayitlari",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Not = table.Column<float>(type: "real", nullable: false),
                    DersID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OgrenciID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OgrenciDersKayitlari", x => x.ID);
                    table.ForeignKey(
                        name: "FK_OgrenciDersKayitlari_Dersler_DersID",
                        column: x => x.DersID,
                        principalTable: "Dersler",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_OgrenciDersKayitlari_Ogrenciler_OgrenciID",
                        column: x => x.OgrenciID,
                        principalTable: "Ogrenciler",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "DersAtamalari",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DersID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OgretimGorevlisiID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OgretimGorevlisiID1 = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DersAtamalari", x => x.ID);
                    table.ForeignKey(
                        name: "FK_DersAtamalari_Dersler_DersID",
                        column: x => x.DersID,
                        principalTable: "Dersler",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DersAtamalari_OgretimGorevlileri_OgretimGorevlisiID",
                        column: x => x.OgretimGorevlisiID,
                        principalTable: "OgretimGorevlileri",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_DersAtamalari_OgretimGorevlileri_OgretimGorevlisiID1",
                        column: x => x.OgretimGorevlisiID1,
                        principalTable: "OgretimGorevlileri",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bolumler_FakulteID",
                table: "Bolumler",
                column: "FakulteID");

            migrationBuilder.CreateIndex(
                name: "IX_DersAtamalari_DersID",
                table: "DersAtamalari",
                column: "DersID");

            migrationBuilder.CreateIndex(
                name: "IX_DersAtamalari_OgretimGorevlisiID",
                table: "DersAtamalari",
                column: "OgretimGorevlisiID");

            migrationBuilder.CreateIndex(
                name: "IX_DersAtamalari_OgretimGorevlisiID1",
                table: "DersAtamalari",
                column: "OgretimGorevlisiID1");

            migrationBuilder.CreateIndex(
                name: "IX_Dersler_BolumID",
                table: "Dersler",
                column: "BolumID");

            migrationBuilder.CreateIndex(
                name: "IX_OgrenciDersKayitlari_DersID",
                table: "OgrenciDersKayitlari",
                column: "DersID");

            migrationBuilder.CreateIndex(
                name: "IX_OgrenciDersKayitlari_OgrenciID",
                table: "OgrenciDersKayitlari",
                column: "OgrenciID");

            migrationBuilder.CreateIndex(
                name: "IX_Ogrenciler_BolumID",
                table: "Ogrenciler",
                column: "BolumID");

            migrationBuilder.CreateIndex(
                name: "IX_OgretimGorevlileri_BolumID",
                table: "OgretimGorevlileri",
                column: "BolumID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DersAtamalari");

            migrationBuilder.DropTable(
                name: "Kullanicilar");

            migrationBuilder.DropTable(
                name: "OgrenciDersKayitlari");

            migrationBuilder.DropTable(
                name: "OgretimGorevlileri");

            migrationBuilder.DropTable(
                name: "Dersler");

            migrationBuilder.DropTable(
                name: "Ogrenciler");

            migrationBuilder.DropTable(
                name: "Bolumler");

            migrationBuilder.DropTable(
                name: "Fakulteler");
        }
    }
}
