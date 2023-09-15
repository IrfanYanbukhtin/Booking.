using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BOOking.DAL.Migrations
{
    public partial class ShekiHotelTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GabalaHotel_Explores_ExploreId",
                table: "GabalaHotel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GabalaHotel",
                table: "GabalaHotel");

            migrationBuilder.RenameTable(
                name: "GabalaHotel",
                newName: "GabalaHotels");

            migrationBuilder.RenameIndex(
                name: "IX_GabalaHotel_ExploreId",
                table: "GabalaHotels",
                newName: "IX_GabalaHotels_ExploreId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GabalaHotels",
                table: "GabalaHotels",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "ShekiHotels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShortDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LongDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl_2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl_3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl_4 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Reviews = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rate = table.Column<double>(type: "float", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Available = table.Column<bool>(type: "bit", nullable: false),
                    ExploreId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShekiHotels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShekiHotels_Explores_ExploreId",
                        column: x => x.ExploreId,
                        principalTable: "Explores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ShekiHotels_ExploreId",
                table: "ShekiHotels",
                column: "ExploreId");

            migrationBuilder.AddForeignKey(
                name: "FK_GabalaHotels_Explores_ExploreId",
                table: "GabalaHotels",
                column: "ExploreId",
                principalTable: "Explores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GabalaHotels_Explores_ExploreId",
                table: "GabalaHotels");

            migrationBuilder.DropTable(
                name: "ShekiHotels");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GabalaHotels",
                table: "GabalaHotels");

            migrationBuilder.RenameTable(
                name: "GabalaHotels",
                newName: "GabalaHotel");

            migrationBuilder.RenameIndex(
                name: "IX_GabalaHotels_ExploreId",
                table: "GabalaHotel",
                newName: "IX_GabalaHotel_ExploreId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GabalaHotel",
                table: "GabalaHotel",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GabalaHotel_Explores_ExploreId",
                table: "GabalaHotel",
                column: "ExploreId",
                principalTable: "Explores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
