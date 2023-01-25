using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace praktikatest2.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Agreement",
                columns: table => new
                {
                    agreementid = table.Column<int>(name: "agreement_id", type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    codeAgreement = table.Column<int>(type: "integer", nullable: false),
                    numberAgreement = table.Column<int>(type: "integer", nullable: false),
                    dateAgreement = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    dateSrokAgreement = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    dateEndAgreement = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    nameAgreement = table.Column<string>(type: "text", nullable: true),
                    countryAgreement = table.Column<string>(type: "text", nullable: true),
                    areaAgreement = table.Column<string>(type: "text", nullable: true),
                    typeAgreement = table.Column<string>(type: "text", nullable: true),
                    relationshipsAgreement = table.Column<string>(type: "text", nullable: true),
                    statusMMZAgreement = table.Column<string>(type: "text", nullable: true),
                    statusAgreement = table.Column<string>(type: "text", nullable: true),
                    sumAgreement = table.Column<int>(type: "integer", nullable: false),
                    countsAgreement = table.Column<int>(type: "integer", nullable: false),
                    sumTransAgreement = table.Column<int>(type: "integer", nullable: false),
                    nameProduct = table.Column<string>(type: "text", nullable: true),
                    typePayement = table.Column<int>(type: "integer", nullable: false),
                    dayDatePayement = table.Column<int>(type: "integer", nullable: false),
                    dayAgreement = table.Column<int>(type: "integer", nullable: false),
                    dayDateOfShipment = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agreement", x => x.agreementid);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    userid = table.Column<int>(name: "user_id", type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Age = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.userid);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Agreement");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
