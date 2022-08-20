using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Autobahn.Entities.Migrations
{
    public partial class entityreferencebase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RefRecordStatusCreatorEntity_Organization_OrganizationId",
                table: "RefRecordStatusCreatorEntity");

            migrationBuilder.AlterColumn<Guid>(
                name: "OrganizationId",
                table: "RefRecordStatusCreatorEntity",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "TEXT");

            migrationBuilder.AddForeignKey(
                name: "FK_RefRecordStatusCreatorEntity_Organization_OrganizationId",
                table: "RefRecordStatusCreatorEntity",
                column: "OrganizationId",
                principalTable: "Organization",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RefRecordStatusCreatorEntity_Organization_OrganizationId",
                table: "RefRecordStatusCreatorEntity");

            migrationBuilder.AlterColumn<Guid>(
                name: "OrganizationId",
                table: "RefRecordStatusCreatorEntity",
                type: "TEXT",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_RefRecordStatusCreatorEntity_Organization_OrganizationId",
                table: "RefRecordStatusCreatorEntity",
                column: "OrganizationId",
                principalTable: "Organization",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
