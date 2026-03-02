using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication10.Migrations
{
    /// <inheritdoc />
    public partial class migrations2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_productsimport_cotrydnikis_cotrydnikiId",
                table: "productsimport");

            migrationBuilder.DropForeignKey(
                name: "FK_productsimport_productmaterialsimports_Productmaterialsimpo~",
                table: "productsimport");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Users",
                newName: "PasswordHash");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Users",
                newName: "Login");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Roles",
                newName: "NameRole");

            migrationBuilder.AlterColumn<int>(
                name: "width",
                table: "productsimport",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<string>(
                name: "typeproduct",
                table: "productsimport",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<int>(
                name: "prise",
                table: "productsimport",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "productsimport",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<int>(
                name: "cotrydnikiId",
                table: "productsimport",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "ProductmaterialsimportId",
                table: "productsimport",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<int>(
                name: "ProductsimportId",
                table: "Orderss",
                type: "integer",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "materialsimports",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.CreateIndex(
                name: "IX_Orderss_ProductsimportId",
                table: "Orderss",
                column: "ProductsimportId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orderss_productsimport_ProductsimportId",
                table: "Orderss",
                column: "ProductsimportId",
                principalTable: "productsimport",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_productsimport_cotrydnikis_cotrydnikiId",
                table: "productsimport",
                column: "cotrydnikiId",
                principalTable: "cotrydnikis",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_productsimport_productmaterialsimports_Productmaterialsimpo~",
                table: "productsimport",
                column: "ProductmaterialsimportId",
                principalTable: "productmaterialsimports",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orderss_productsimport_ProductsimportId",
                table: "Orderss");

            migrationBuilder.DropForeignKey(
                name: "FK_productsimport_cotrydnikis_cotrydnikiId",
                table: "productsimport");

            migrationBuilder.DropForeignKey(
                name: "FK_productsimport_productmaterialsimports_Productmaterialsimpo~",
                table: "productsimport");

            migrationBuilder.DropIndex(
                name: "IX_Orderss_ProductsimportId",
                table: "Orderss");

            migrationBuilder.DropColumn(
                name: "ProductsimportId",
                table: "Orderss");

            migrationBuilder.RenameColumn(
                name: "PasswordHash",
                table: "Users",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "Login",
                table: "Users",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "NameRole",
                table: "Roles",
                newName: "Name");

            migrationBuilder.AlterColumn<int>(
                name: "width",
                table: "productsimport",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "typeproduct",
                table: "productsimport",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "prise",
                table: "productsimport",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "productsimport",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "cotrydnikiId",
                table: "productsimport",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProductmaterialsimportId",
                table: "productsimport",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "materialsimports",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_productsimport_cotrydnikis_cotrydnikiId",
                table: "productsimport",
                column: "cotrydnikiId",
                principalTable: "cotrydnikis",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_productsimport_productmaterialsimports_Productmaterialsimpo~",
                table: "productsimport",
                column: "ProductmaterialsimportId",
                principalTable: "productmaterialsimports",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
