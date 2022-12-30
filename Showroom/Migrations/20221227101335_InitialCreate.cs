using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Showroom.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Car",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    exteriorcolor = table.Column<string>(name: "exterior_color", type: "nvarchar(max)", nullable: true),
                    workproductivity = table.Column<string>(name: "work_productivity", type: "nvarchar(max)", nullable: true),
                    cylindernumber = table.Column<float>(name: "cylinder_number", type: "real", nullable: true),
                    year = table.Column<DateTime>(type: "datetime2", nullable: false),
                    length = table.Column<float>(type: "real", nullable: false),
                    width = table.Column<float>(type: "real", nullable: false),
                    height = table.Column<float>(type: "real", nullable: false),
                    weight = table.Column<float>(type: "real", nullable: false),
                    maximumweight = table.Column<string>(name: "maximum_weight", type: "nvarchar(max)", nullable: true),
                    topspeed = table.Column<float>(name: "top_speed", type: "real", nullable: false),
                    interiorcolor = table.Column<string>(name: "interior_color", type: "nvarchar(max)", nullable: true),
                    numberofseat = table.Column<int>(name: "number_of_seat", type: "int", nullable: false),
                    price = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Car", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Car_store",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    carid = table.Column<int>(name: "car_id", type: "int", nullable: false),
                    storeid = table.Column<int>(name: "store_id", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Car_store", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    productID = table.Column<int>(type: "int", nullable: false),
                    carname = table.Column<string>(name: "car_name", type: "nvarchar(max)", nullable: true),
                    category = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    colletions = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CarCar_store",
                columns: table => new
                {
                    CarstoresId = table.Column<int>(name: "Car_storesId", type: "int", nullable: false),
                    CarsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarCar_store", x => new { x.CarstoresId, x.CarsId });
                    table.ForeignKey(
                        name: "FK_CarCar_store_Car_CarsId",
                        column: x => x.CarsId,
                        principalTable: "Car",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CarCar_store_Car_store_Car_storesId",
                        column: x => x.CarstoresId,
                        principalTable: "Car_store",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CarCategory",
                columns: table => new
                {
                    CarsId = table.Column<int>(type: "int", nullable: false),
                    CategorysId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarCategory", x => new { x.CarsId, x.CategorysId });
                    table.ForeignKey(
                        name: "FK_CarCategory_Car_CarsId",
                        column: x => x.CarsId,
                        principalTable: "Car",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CarCategory_Category_CategorysId",
                        column: x => x.CategorysId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CarCar_store_CarsId",
                table: "CarCar_store",
                column: "CarsId");

            migrationBuilder.CreateIndex(
                name: "IX_CarCategory_CategorysId",
                table: "CarCategory",
                column: "CategorysId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarCar_store");

            migrationBuilder.DropTable(
                name: "CarCategory");

            migrationBuilder.DropTable(
                name: "Car_store");

            migrationBuilder.DropTable(
                name: "Car");

            migrationBuilder.DropTable(
                name: "Category");
        }
    }
}
