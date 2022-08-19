using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Autobahn.Entities.Migrations
{
    public partial class codeindex : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "RefRecordStatusType",
                type: "TEXT",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "RefRecordStatusCreatorEntity",
                type: "TEXT",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_RefRecordStatusType_Code",
                table: "RefRecordStatusType",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RefRecordStatusCreatorEntity_Code",
                table: "RefRecordStatusCreatorEntity",
                column: "Code",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_RefRecordStatusType_Code",
                table: "RefRecordStatusType");

            migrationBuilder.DropIndex(
                name: "IX_RefRecordStatusCreatorEntity_Code",
                table: "RefRecordStatusCreatorEntity");

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "RefRecordStatusType",
                type: "TEXT",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "RefRecordStatusCreatorEntity",
                type: "TEXT",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 50);
        }
    }
}
