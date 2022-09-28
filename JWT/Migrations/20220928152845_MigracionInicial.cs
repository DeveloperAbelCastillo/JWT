using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JWT.Migrations
{
    public partial class MigracionInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pais",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Nombre = table.Column<string>(maxLength: 50, nullable: false),
                    Habitantes = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pais", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Pais",
                columns: new[] { "Id", "Habitantes", "Nombre" },
                values: new object[,]
                {
                    { new Guid("7861dfd8-2b03-4d77-a163-f51dd23c9958"), 46000000, "España" },
                    { new Guid("cb3f4c9c-b869-47c6-ae27-d9e39383c9b7"), 83000000, "Alemania" },
                    { new Guid("2edba698-8a13-492b-920d-31a55638519b"), 65000000, "Francia" },
                    { new Guid("4db28417-c3c7-4fa9-8775-58f124096f89"), 61000000, "Italia" },
                    { new Guid("3525f2d8-5dc5-4fff-b053-dba08a0e7095"), 96000000, "Mexico" },
                    { new Guid("08dd1c95-f61d-41a1-9cd4-25505d4213eb"), 63000000, "EUA" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pais");
        }
    }
}
