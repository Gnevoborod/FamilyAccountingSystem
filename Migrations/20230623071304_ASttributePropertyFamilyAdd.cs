using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FamilyAccountingSystem.Migrations
{
    /// <inheritdoc />
    public partial class ASttributePropertyFamilyAdd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_attribute_property_property_id",
                table: "attribute");

            migrationBuilder.DropIndex(
                name: "IX_attribute_property_id",
                table: "attribute");

            migrationBuilder.DropColumn(
                name: "property_id",
                table: "attribute");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "property_id",
                table: "attribute",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_attribute_property_id",
                table: "attribute",
                column: "property_id");

            migrationBuilder.AddForeignKey(
                name: "FK_attribute_property_property_id",
                table: "attribute",
                column: "property_id",
                principalTable: "property",
                principalColumn: "property_id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
