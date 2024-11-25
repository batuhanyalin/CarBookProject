using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarBookProject.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Authors_AuthorId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Cars_CarId",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_AuthorId",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_CarId",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "AuthorId",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "CarId",
                table: "Comments");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AuthorId",
                table: "Comments",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CarId",
                table: "Comments",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Comments_AuthorId",
                table: "Comments",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_CarId",
                table: "Comments",
                column: "CarId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Authors_AuthorId",
                table: "Comments",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "AuthorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Cars_CarId",
                table: "Comments",
                column: "CarId",
                principalTable: "Cars",
                principalColumn: "CarId");
        }
    }
}
