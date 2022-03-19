using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace kutuphane24.Migrations
{
    public partial class KutuphaneDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TblKasa",
                columns: table => new
                {
                    KasaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ay = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Tutar = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblKasa", x => x.KasaID);
                });

            migrationBuilder.CreateTable(
                name: "TblKategori",
                columns: table => new
                {
                    KategoriID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KategoriAd = table.Column<string>(type: "nchar(20)", fixedLength: true, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblKategori", x => x.KategoriID);
                });

            migrationBuilder.CreateTable(
                name: "TblPersonel",
                columns: table => new
                {
                    PersonelID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Personel = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblPersonel", x => x.PersonelID);
                });

            migrationBuilder.CreateTable(
                name: "TblUye",
                columns: table => new
                {
                    UyeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AD = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Soyad = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Mail = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    KullaniciAdi = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Sifre = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Fotograf = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Telefon = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Okul = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblUye", x => x.UyeID);
                });

            migrationBuilder.CreateTable(
                name: "TblYazar",
                columns: table => new
                {
                    YazarID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    Soyad = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    Detay = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblYazar", x => x.YazarID);
                });

            migrationBuilder.CreateTable(
                name: "TblKitap",
                columns: table => new
                {
                    KitapID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Kategori = table.Column<int>(type: "int", nullable: true),
                    Yazar = table.Column<int>(type: "int", nullable: true),
                    BasimYil = table.Column<string>(type: "char(4)", unicode: false, fixedLength: true, maxLength: 4, nullable: true),
                    YayinEvi = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Sayfa = table.Column<string>(type: "varchar(4)", unicode: false, maxLength: 4, nullable: true),
                    Durum = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((1))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblKitap", x => x.KitapID);
                    table.ForeignKey(
                        name: "FK_TblKitap_TblKategori",
                        column: x => x.Kategori,
                        principalTable: "TblKategori",
                        principalColumn: "KategoriID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblKitap_TblYazar",
                        column: x => x.Yazar,
                        principalTable: "TblYazar",
                        principalColumn: "YazarID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TblHareket",
                columns: table => new
                {
                    HareketID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Kitap = table.Column<int>(type: "int", nullable: true),
                    Uye = table.Column<int>(type: "int", nullable: true),
                    Personel = table.Column<int>(type: "int", nullable: true),
                    AlısTarih = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    İadeTarih = table.Column<DateTime>(type: "smalldatetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblHareket", x => x.HareketID);
                    table.ForeignKey(
                        name: "FK_TblHareket_TblKitap",
                        column: x => x.Kitap,
                        principalTable: "TblKitap",
                        principalColumn: "KitapID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblHareket_TblUye",
                        column: x => x.Uye,
                        principalTable: "TblUye",
                        principalColumn: "UyeID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TblCezalar",
                columns: table => new
                {
                    CezaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Uye = table.Column<int>(type: "int", nullable: true),
                    Başlangıç = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    Bitiş = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    Para = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Hareket = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblCezalar", x => x.CezaID);
                    table.ForeignKey(
                        name: "FK_TblCezalar_TblHareket",
                        column: x => x.Hareket,
                        principalTable: "TblHareket",
                        principalColumn: "HareketID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblCezalar_TblUye",
                        column: x => x.Uye,
                        principalTable: "TblUye",
                        principalColumn: "UyeID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TblCezalar_Hareket",
                table: "TblCezalar",
                column: "Hareket");

            migrationBuilder.CreateIndex(
                name: "IX_TblCezalar_Uye",
                table: "TblCezalar",
                column: "Uye");

            migrationBuilder.CreateIndex(
                name: "IX_TblHareket_Kitap",
                table: "TblHareket",
                column: "Kitap");

            migrationBuilder.CreateIndex(
                name: "IX_TblHareket_Uye",
                table: "TblHareket",
                column: "Uye");

            migrationBuilder.CreateIndex(
                name: "IX_TblKitap_Kategori",
                table: "TblKitap",
                column: "Kategori");

            migrationBuilder.CreateIndex(
                name: "IX_TblKitap_Yazar",
                table: "TblKitap",
                column: "Yazar");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TblCezalar");

            migrationBuilder.DropTable(
                name: "TblKasa");

            migrationBuilder.DropTable(
                name: "TblPersonel");

            migrationBuilder.DropTable(
                name: "TblHareket");

            migrationBuilder.DropTable(
                name: "TblKitap");

            migrationBuilder.DropTable(
                name: "TblUye");

            migrationBuilder.DropTable(
                name: "TblKategori");

            migrationBuilder.DropTable(
                name: "TblYazar");
        }
    }
}
