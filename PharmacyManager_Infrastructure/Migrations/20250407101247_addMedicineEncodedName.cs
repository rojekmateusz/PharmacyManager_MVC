using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PharmacyManager_Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addMedicineEncodedName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EncodedName",
                table: "Medicines",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EncodedName",
                table: "Medicines");
        }
    }
}
