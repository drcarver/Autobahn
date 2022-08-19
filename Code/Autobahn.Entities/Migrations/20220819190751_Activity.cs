using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Autobahn.Entities.Migrations
{
    public partial class Activity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Activity",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    OrganizationId = table.Column<Guid>(type: "TEXT", nullable: false),
                    ActivityDescription = table.Column<string>(type: "TEXT", maxLength: 300, nullable: true),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "TEXT", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "TEXT", nullable: false),
                    RecordStartDateTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    RecordEndDateTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    RecordStatusId = table.Column<Guid>(type: "TEXT", nullable: true),
                    DataCollectionId = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DataCollection",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    DataCollectionAcademicSchoolYear = table.Column<string>(type: "TEXT", maxLength: 4, nullable: true),
                    DataCollectionCloseDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    DataCollectionDescription = table.Column<string>(type: "TEXT", nullable: true),
                    DataCollectionName = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    DataCollectionSchoolYear = table.Column<string>(type: "TEXT", maxLength: 4, nullable: true),
                    SourceSystemDataCollectionIdentifier = table.Column<string>(type: "TEXT", maxLength: 36, nullable: true),
                    SourceSystemName = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    DataCollectionOpenDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    RefDataCollectionStatusId = table.Column<Guid>(type: "TEXT", nullable: true),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "TEXT", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "TEXT", nullable: false),
                    RecordStartDateTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    RecordEndDateTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    RecordStatusId = table.Column<Guid>(type: "TEXT", nullable: true),
                    DataCollectionId = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataCollection", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DataCollection_DataCollection_DataCollectionId",
                        column: x => x.DataCollectionId,
                        principalTable: "DataCollection",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Organization",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "TEXT", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "TEXT", nullable: false),
                    RecordStartDateTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    RecordEndDateTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    RecordStatusId = table.Column<Guid>(type: "TEXT", nullable: true),
                    DataCollectionId = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organization", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Organization_DataCollection_DataCollectionId",
                        column: x => x.DataCollectionId,
                        principalTable: "DataCollection",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RecordStatus",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    RecordStatusCreatorOrganizationId = table.Column<Guid>(type: "TEXT", nullable: true),
                    RecordStatusCreatorPersonId = table.Column<Guid>(type: "TEXT", nullable: true),
                    RecordStatusDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    RefRecordStatusTypeId = table.Column<Guid>(type: "TEXT", nullable: true),
                    RefRecordStatusCreatorEntityId = table.Column<Guid>(type: "TEXT", nullable: true),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "TEXT", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "TEXT", nullable: false),
                    RecordStartDateTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    RecordEndDateTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    RecordStatusId = table.Column<Guid>(type: "TEXT", nullable: true),
                    DataCollectionId = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecordStatus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RecordStatus_DataCollection_DataCollectionId",
                        column: x => x.DataCollectionId,
                        principalTable: "DataCollection",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RecordStatus_RecordStatus_RecordStatusId",
                        column: x => x.RecordStatusId,
                        principalTable: "RecordStatus",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RefRecordStatusCreatorEntity",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    OrganizationId = table.Column<Guid>(type: "TEXT", nullable: false),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "TEXT", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "TEXT", nullable: false),
                    RecordStartDateTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    RecordEndDateTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    RecordStatusId = table.Column<Guid>(type: "TEXT", nullable: true),
                    DataCollectionId = table.Column<Guid>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", maxLength: 150, nullable: false),
                    Code = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    Definition = table.Column<string>(type: "TEXT", maxLength: 4000, nullable: true),
                    RefJurisdictionId = table.Column<Guid>(type: "TEXT", nullable: true),
                    SortOrder = table.Column<decimal>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefRecordStatusCreatorEntity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RefRecordStatusCreatorEntity_DataCollection_DataCollectionId",
                        column: x => x.DataCollectionId,
                        principalTable: "DataCollection",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RefRecordStatusCreatorEntity_Organization_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "Organization",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RefRecordStatusCreatorEntity_RecordStatus_RecordStatusId",
                        column: x => x.RecordStatusId,
                        principalTable: "RecordStatus",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RefRecordStatusType",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    OrganizationId = table.Column<Guid>(type: "TEXT", nullable: true),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "TEXT", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "TEXT", nullable: false),
                    RecordStartDateTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    RecordEndDateTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    RecordStatusId = table.Column<Guid>(type: "TEXT", nullable: true),
                    DataCollectionId = table.Column<Guid>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", maxLength: 150, nullable: false),
                    Code = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    Definition = table.Column<string>(type: "TEXT", maxLength: 4000, nullable: true),
                    RefJurisdictionId = table.Column<Guid>(type: "TEXT", nullable: true),
                    SortOrder = table.Column<decimal>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefRecordStatusType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RefRecordStatusType_DataCollection_DataCollectionId",
                        column: x => x.DataCollectionId,
                        principalTable: "DataCollection",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RefRecordStatusType_Organization_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "Organization",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RefRecordStatusType_RecordStatus_RecordStatusId",
                        column: x => x.RecordStatusId,
                        principalTable: "RecordStatus",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Activity_DataCollectionId",
                table: "Activity",
                column: "DataCollectionId");

            migrationBuilder.CreateIndex(
                name: "IX_Activity_OrganizationId",
                table: "Activity",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_Activity_RecordStatusId",
                table: "Activity",
                column: "RecordStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_DataCollection_DataCollectionId",
                table: "DataCollection",
                column: "DataCollectionId");

            migrationBuilder.CreateIndex(
                name: "IX_DataCollection_RecordStatusId",
                table: "DataCollection",
                column: "RecordStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Organization_DataCollectionId",
                table: "Organization",
                column: "DataCollectionId");

            migrationBuilder.CreateIndex(
                name: "IX_Organization_RecordStatusId",
                table: "Organization",
                column: "RecordStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_RecordStatus_DataCollectionId",
                table: "RecordStatus",
                column: "DataCollectionId");

            migrationBuilder.CreateIndex(
                name: "IX_RecordStatus_RecordStatusId",
                table: "RecordStatus",
                column: "RecordStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_RecordStatus_RefRecordStatusCreatorEntityId",
                table: "RecordStatus",
                column: "RefRecordStatusCreatorEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_RecordStatus_RefRecordStatusTypeId",
                table: "RecordStatus",
                column: "RefRecordStatusTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_RefRecordStatusCreatorEntity_DataCollectionId",
                table: "RefRecordStatusCreatorEntity",
                column: "DataCollectionId");

            migrationBuilder.CreateIndex(
                name: "IX_RefRecordStatusCreatorEntity_OrganizationId",
                table: "RefRecordStatusCreatorEntity",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_RefRecordStatusCreatorEntity_RecordStatusId",
                table: "RefRecordStatusCreatorEntity",
                column: "RecordStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_RefRecordStatusType_DataCollectionId",
                table: "RefRecordStatusType",
                column: "DataCollectionId");

            migrationBuilder.CreateIndex(
                name: "IX_RefRecordStatusType_OrganizationId",
                table: "RefRecordStatusType",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_RefRecordStatusType_RecordStatusId",
                table: "RefRecordStatusType",
                column: "RecordStatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_Activity_DataCollection_DataCollectionId",
                table: "Activity",
                column: "DataCollectionId",
                principalTable: "DataCollection",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Activity_Organization_OrganizationId",
                table: "Activity",
                column: "OrganizationId",
                principalTable: "Organization",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Activity_RecordStatus_RecordStatusId",
                table: "Activity",
                column: "RecordStatusId",
                principalTable: "RecordStatus",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DataCollection_RecordStatus_RecordStatusId",
                table: "DataCollection",
                column: "RecordStatusId",
                principalTable: "RecordStatus",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Organization_RecordStatus_RecordStatusId",
                table: "Organization",
                column: "RecordStatusId",
                principalTable: "RecordStatus",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RecordStatus_RefRecordStatusCreatorEntity_RefRecordStatusCreatorEntityId",
                table: "RecordStatus",
                column: "RefRecordStatusCreatorEntityId",
                principalTable: "RefRecordStatusCreatorEntity",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RecordStatus_RefRecordStatusType_RefRecordStatusTypeId",
                table: "RecordStatus",
                column: "RefRecordStatusTypeId",
                principalTable: "RefRecordStatusType",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Organization_DataCollection_DataCollectionId",
                table: "Organization");

            migrationBuilder.DropForeignKey(
                name: "FK_RecordStatus_DataCollection_DataCollectionId",
                table: "RecordStatus");

            migrationBuilder.DropForeignKey(
                name: "FK_RefRecordStatusCreatorEntity_DataCollection_DataCollectionId",
                table: "RefRecordStatusCreatorEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_RefRecordStatusType_DataCollection_DataCollectionId",
                table: "RefRecordStatusType");

            migrationBuilder.DropForeignKey(
                name: "FK_RefRecordStatusCreatorEntity_Organization_OrganizationId",
                table: "RefRecordStatusCreatorEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_RefRecordStatusType_Organization_OrganizationId",
                table: "RefRecordStatusType");

            migrationBuilder.DropForeignKey(
                name: "FK_RefRecordStatusCreatorEntity_RecordStatus_RecordStatusId",
                table: "RefRecordStatusCreatorEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_RefRecordStatusType_RecordStatus_RecordStatusId",
                table: "RefRecordStatusType");

            migrationBuilder.DropTable(
                name: "Activity");

            migrationBuilder.DropTable(
                name: "DataCollection");

            migrationBuilder.DropTable(
                name: "Organization");

            migrationBuilder.DropTable(
                name: "RecordStatus");

            migrationBuilder.DropTable(
                name: "RefRecordStatusCreatorEntity");

            migrationBuilder.DropTable(
                name: "RefRecordStatusType");
        }
    }
}
