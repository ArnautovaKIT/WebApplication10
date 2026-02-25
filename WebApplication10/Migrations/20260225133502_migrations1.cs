using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace WebApplication10.Migrations
{
    /// <inheritdoc />
    public partial class migrations1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "cotrydnikis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    data = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    pasport = table.Column<int>(type: "integer", nullable: false),
                    recvisitu = table.Column<int>(type: "integer", nullable: false),
                    family = table.Column<string>(type: "text", nullable: false),
                    helth = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cotrydnikis", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "materialtypeimports",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    typematerial = table.Column<string>(type: "text", nullable: false),
                    brak = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_materialtypeimports", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "partnetus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    type = table.Column<string>(type: "text", nullable: false),
                    inn = table.Column<int>(type: "integer", nullable: false),
                    phont = table.Column<int>(type: "integer", nullable: false),
                    email = table.Column<string>(type: "text", nullable: false),
                    locaciaproduct = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_partnetus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orderss",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    partnetuId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orderss", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orderss_partnetus_partnetuId",
                        column: x => x.partnetuId,
                        principalTable: "partnetus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Password = table.Column<string>(type: "text", nullable: false),
                    RoleId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "producttypeimports",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    tipproducts = table.Column<string>(type: "text", nullable: false),
                    coofizent = table.Column<int>(type: "integer", nullable: false),
                    OrdersId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_producttypeimports", x => x.Id);
                    table.ForeignKey(
                        name: "FK_producttypeimports_Orderss_OrdersId",
                        column: x => x.OrdersId,
                        principalTable: "Orderss",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "productmaterialsimports",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    produczua = table.Column<string>(type: "text", nullable: false),
                    material = table.Column<string>(type: "text", nullable: false),
                    quantitymaterials = table.Column<int>(type: "integer", nullable: false),
                    ProducttypeimportId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productmaterialsimports", x => x.Id);
                    table.ForeignKey(
                        name: "FK_productmaterialsimports_producttypeimports_Producttypeimpor~",
                        column: x => x.ProducttypeimportId,
                        principalTable: "producttypeimports",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "materialsimports",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    price = table.Column<int>(type: "integer", nullable: false),
                    quantity = table.Column<int>(type: "integer", nullable: false),
                    min = table.Column<int>(type: "integer", nullable: false),
                    package = table.Column<int>(type: "integer", nullable: false),
                    MaterId = table.Column<int>(type: "integer", nullable: false),
                    MaterialtypeimportId = table.Column<int>(type: "integer", nullable: false),
                    ProductmaterialsimportId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_materialsimports", x => x.Id);
                    table.ForeignKey(
                        name: "FK_materialsimports_materialtypeimports_MaterialtypeimportId",
                        column: x => x.MaterialtypeimportId,
                        principalTable: "materialtypeimports",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_materialsimports_productmaterialsimports_Productmaterialsim~",
                        column: x => x.ProductmaterialsimportId,
                        principalTable: "productmaterialsimports",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "productsimport",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    typeproduct = table.Column<string>(type: "text", nullable: false),
                    name = table.Column<string>(type: "text", nullable: false),
                    articul = table.Column<int>(type: "integer", nullable: false),
                    prise = table.Column<int>(type: "integer", nullable: false),
                    width = table.Column<int>(type: "integer", nullable: false),
                    ProductmaterialsimportId = table.Column<int>(type: "integer", nullable: false),
                    cotrydnikiId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productsimport", x => x.Id);
                    table.ForeignKey(
                        name: "FK_productsimport_cotrydnikis_cotrydnikiId",
                        column: x => x.cotrydnikiId,
                        principalTable: "cotrydnikis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_productsimport_productmaterialsimports_Productmaterialsimpo~",
                        column: x => x.ProductmaterialsimportId,
                        principalTable: "productmaterialsimports",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_materialsimports_MaterialtypeimportId",
                table: "materialsimports",
                column: "MaterialtypeimportId");

            migrationBuilder.CreateIndex(
                name: "IX_materialsimports_ProductmaterialsimportId",
                table: "materialsimports",
                column: "ProductmaterialsimportId");

            migrationBuilder.CreateIndex(
                name: "IX_Orderss_partnetuId",
                table: "Orderss",
                column: "partnetuId");

            migrationBuilder.CreateIndex(
                name: "IX_productmaterialsimports_ProducttypeimportId",
                table: "productmaterialsimports",
                column: "ProducttypeimportId");

            migrationBuilder.CreateIndex(
                name: "IX_productsimport_cotrydnikiId",
                table: "productsimport",
                column: "cotrydnikiId");

            migrationBuilder.CreateIndex(
                name: "IX_productsimport_ProductmaterialsimportId",
                table: "productsimport",
                column: "ProductmaterialsimportId");

            migrationBuilder.CreateIndex(
                name: "IX_producttypeimports_OrdersId",
                table: "producttypeimports",
                column: "OrdersId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "materialsimports");

            migrationBuilder.DropTable(
                name: "productsimport");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "materialtypeimports");

            migrationBuilder.DropTable(
                name: "cotrydnikis");

            migrationBuilder.DropTable(
                name: "productmaterialsimports");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "producttypeimports");

            migrationBuilder.DropTable(
                name: "Orderss");

            migrationBuilder.DropTable(
                name: "partnetus");
        }
    }
}
