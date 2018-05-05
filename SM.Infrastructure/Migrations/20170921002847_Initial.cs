using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SM.Infrastructure.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AdrAdms",
                columns: table => new
                {
                    AdrAdmId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    id_admi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    inne = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    kierownik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    kontakt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    miasto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nazwa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pna = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ulica = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    uwagi = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdrAdms", x => x.AdrAdmId);
                });

            migrationBuilder.CreateTable(
                name: "AdrBuds",
                columns: table => new
                {
                    AdrBudId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    id_adm = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    id_budy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    id_osie = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    id_ulic = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    kod_n = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    miasto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nr_budowla = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nr_komp_ol = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    numery = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    osiedle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pna = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ulica = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdrBuds", x => x.AdrBudId);
                });

            migrationBuilder.CreateTable(
                name: "AdrKlas",
                columns: table => new
                {
                    AdrKlaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    id_budy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    id_klat = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdrKlas", x => x.AdrKlaId);
                });

            migrationBuilder.CreateTable(
                name: "AdrLoks",
                columns: table => new
                {
                    AdrLokId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    id_budy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    id_klat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    id_loka = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdrLoks", x => x.AdrLokId);
                });

            migrationBuilder.CreateTable(
                name: "AdrOsis",
                columns: table => new
                {
                    AdrOsiId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    id_adm = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    id_osie = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    kod_n = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    miasto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nazwa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nr_dz = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdrOsis", x => x.AdrOsiId);
                });

            migrationBuilder.CreateTable(
                name: "AdrUlis",
                columns: table => new
                {
                    AdrUliId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    id_adm = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    id_osie = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    id_ulic = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    miasto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nazwa = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdrUlis", x => x.AdrUliId);
                });

            migrationBuilder.CreateTable(
                name: "B07_zglos",
                columns: table => new
                {
                    B07_zgloId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    blok = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    czas_zglos = table.Column<DateTime>(type: "datetime2", nullable: true),
                    czyj_koszt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    data_insp = table.Column<DateTime>(type: "datetime2", nullable: true),
                    data_oper = table.Column<DateTime>(type: "datetime2", nullable: true),
                    data_tere = table.Column<DateTime>(type: "datetime2", nullable: true),
                    data_wykon = table.Column<DateTime>(type: "datetime2", nullable: true),
                    data_zglos = table.Column<DateTime>(type: "datetime2", nullable: true),
                    data_zlec = table.Column<DateTime>(type: "datetime2", nullable: true),
                    godz_wykon = table.Column<DateTime>(type: "datetime2", nullable: true),
                    id_admin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    id_adres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    id_branz = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    id_oper = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    inspektor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    lp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    naleznosc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nazwisko = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nr_prac = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nr_rw = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nr_zlec = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nr_zw = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    numer_zglo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    numer_zlec = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    opis_wykon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    rodzaj_ust = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    uwagi1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    uwagi_wyko = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    uwagi_zlec = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    wykon_zewn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    wykonawca = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_B07_zglos", x => x.B07_zgloId);
                });

            migrationBuilder.CreateTable(
                name: "B07_zlecs",
                columns: table => new
                {
                    B07_zlecId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    blok = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    data_oper = table.Column<DateTime>(type: "datetime2", nullable: true),
                    data_zlec = table.Column<DateTime>(type: "datetime2", nullable: true),
                    id_admin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    id_oper = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    il_godz1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    il_godz2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    il_godz3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    il_godz4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    il_godz5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nr_magaz = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nr_prac = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nr_prac1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nr_prac2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nr_prac3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nr_prac4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nr_prac5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nr_rw = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nr_zglo1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nr_zglo2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nr_zglo3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nr_zglo4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nr_zglo5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nr_zlec = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nr_zw = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    numer_zlec = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    uwagi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    uwagi1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    wykonawcy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_B07_zlecs", x => x.B07_zlecId);
                });

            migrationBuilder.CreateTable(
                name: "Branzas",
                columns: table => new
                {
                    BranzaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    nazwa_bran = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nr_branzy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branzas", x => x.BranzaId);
                });

            migrationBuilder.CreateTable(
                name: "Osobas",
                columns: table => new
                {
                    OsobaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    imie = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nazwisko = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nr_admin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nr_osoby = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    typ = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Osobas", x => x.OsobaId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdrAdms");

            migrationBuilder.DropTable(
                name: "AdrBuds");

            migrationBuilder.DropTable(
                name: "AdrKlas");

            migrationBuilder.DropTable(
                name: "AdrLoks");

            migrationBuilder.DropTable(
                name: "AdrOsis");

            migrationBuilder.DropTable(
                name: "AdrUlis");

            migrationBuilder.DropTable(
                name: "B07_zglos");

            migrationBuilder.DropTable(
                name: "B07_zlecs");

            migrationBuilder.DropTable(
                name: "Branzas");

            migrationBuilder.DropTable(
                name: "Osobas");
        }
    }
}
