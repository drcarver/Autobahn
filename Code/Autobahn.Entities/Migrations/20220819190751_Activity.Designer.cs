﻿// <auto-generated />
using System;
using Autobahn.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Autobahn.Entities.Migrations
{
    [DbContext(typeof(AutobahnCommonContext))]
    [Migration("20220819190751_Activity")]
    partial class Activity
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.8");

            modelBuilder.Entity("Autobahn.Entities.Activity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("ActivityDescription")
                        .HasMaxLength(300)
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("DataCollectionId")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<Guid?>("ModifiedBy")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ModifiedOn")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("OrganizationId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("RecordEndDateTime")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("RecordStartDateTime")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("RecordStatusId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("DataCollectionId");

                    b.HasIndex("OrganizationId");

                    b.HasIndex("RecordStatusId");

                    b.ToTable("Activity");
                });

            modelBuilder.Entity("Autobahn.Entities.DataCollection", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("DataCollectionAcademicSchoolYear")
                        .HasMaxLength(4)
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DataCollectionCloseDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("DataCollectionDescription")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("DataCollectionId")
                        .HasColumnType("TEXT");

                    b.Property<string>("DataCollectionName")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DataCollectionOpenDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("DataCollectionSchoolYear")
                        .HasMaxLength(4)
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<Guid?>("ModifiedBy")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ModifiedOn")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("RecordEndDateTime")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("RecordStartDateTime")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("RecordStatusId")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("RefDataCollectionStatusId")
                        .HasColumnType("TEXT");

                    b.Property<string>("SourceSystemDataCollectionIdentifier")
                        .HasMaxLength(36)
                        .HasColumnType("TEXT");

                    b.Property<string>("SourceSystemName")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("DataCollectionId");

                    b.HasIndex("RecordStatusId");

                    b.ToTable("DataCollection");
                });

            modelBuilder.Entity("Autobahn.Entities.Organization", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("DataCollectionId")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<Guid?>("ModifiedBy")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ModifiedOn")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("RecordEndDateTime")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("RecordStartDateTime")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("RecordStatusId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("DataCollectionId");

                    b.HasIndex("RecordStatusId");

                    b.ToTable("Organization");
                });

            modelBuilder.Entity("Autobahn.Entities.RecordStatus", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("DataCollectionId")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<Guid?>("ModifiedBy")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ModifiedOn")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("RecordEndDateTime")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("RecordStartDateTime")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("RecordStatusCreatorOrganizationId")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("RecordStatusCreatorPersonId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("RecordStatusDate")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("RecordStatusId")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("RefRecordStatusCreatorEntityId")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("RefRecordStatusTypeId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("DataCollectionId");

                    b.HasIndex("RecordStatusId");

                    b.HasIndex("RefRecordStatusCreatorEntityId");

                    b.HasIndex("RefRecordStatusTypeId");

                    b.ToTable("RecordStatus");
                });

            modelBuilder.Entity("Autobahn.Entities.RefRecordStatusCreatorEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Code")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("DataCollectionId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Definition")
                        .HasMaxLength(4000)
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<Guid?>("ModifiedBy")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ModifiedOn")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("OrganizationId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("RecordEndDateTime")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("RecordStartDateTime")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("RecordStatusId")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("RefJurisdictionId")
                        .HasColumnType("TEXT");

                    b.Property<decimal?>("SortOrder")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("DataCollectionId");

                    b.HasIndex("OrganizationId");

                    b.HasIndex("RecordStatusId");

                    b.ToTable("RefRecordStatusCreatorEntity");
                });

            modelBuilder.Entity("Autobahn.Entities.RefRecordStatusType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Code")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("DataCollectionId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Definition")
                        .HasMaxLength(4000)
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<Guid?>("ModifiedBy")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ModifiedOn")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("OrganizationId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("RecordEndDateTime")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("RecordStartDateTime")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("RecordStatusId")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("RefJurisdictionId")
                        .HasColumnType("TEXT");

                    b.Property<decimal?>("SortOrder")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("DataCollectionId");

                    b.HasIndex("OrganizationId");

                    b.HasIndex("RecordStatusId");

                    b.ToTable("RefRecordStatusType");
                });

            modelBuilder.Entity("Autobahn.Entities.Activity", b =>
                {
                    b.HasOne("Autobahn.Entities.DataCollection", "DataCollection")
                        .WithMany("Activities")
                        .HasForeignKey("DataCollectionId");

                    b.HasOne("Autobahn.Entities.Organization", "Organization")
                        .WithMany("Activities")
                        .HasForeignKey("OrganizationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Autobahn.Entities.RecordStatus", "RecordStatus")
                        .WithMany("Activities")
                        .HasForeignKey("RecordStatusId");

                    b.Navigation("DataCollection");

                    b.Navigation("Organization");

                    b.Navigation("RecordStatus");
                });

            modelBuilder.Entity("Autobahn.Entities.DataCollection", b =>
                {
                    b.HasOne("Autobahn.Entities.DataCollection", "DataCollection")
                        .WithMany()
                        .HasForeignKey("DataCollectionId");

                    b.HasOne("Autobahn.Entities.RecordStatus", "RecordStatus")
                        .WithMany()
                        .HasForeignKey("RecordStatusId");

                    b.Navigation("DataCollection");

                    b.Navigation("RecordStatus");
                });

            modelBuilder.Entity("Autobahn.Entities.Organization", b =>
                {
                    b.HasOne("Autobahn.Entities.DataCollection", "DataCollection")
                        .WithMany("Organizations")
                        .HasForeignKey("DataCollectionId");

                    b.HasOne("Autobahn.Entities.RecordStatus", "RecordStatus")
                        .WithMany("Organizations")
                        .HasForeignKey("RecordStatusId");

                    b.Navigation("DataCollection");

                    b.Navigation("RecordStatus");
                });

            modelBuilder.Entity("Autobahn.Entities.RecordStatus", b =>
                {
                    b.HasOne("Autobahn.Entities.DataCollection", "DataCollection")
                        .WithMany()
                        .HasForeignKey("DataCollectionId");

                    b.HasOne("Autobahn.Entities.RecordStatus", "RecordStatus")
                        .WithMany()
                        .HasForeignKey("RecordStatusId");

                    b.HasOne("Autobahn.Entities.RefRecordStatusCreatorEntity", "RefRecordStatusCreatorEntity")
                        .WithMany()
                        .HasForeignKey("RefRecordStatusCreatorEntityId");

                    b.HasOne("Autobahn.Entities.RefRecordStatusType", "RefRecordStatusType")
                        .WithMany()
                        .HasForeignKey("RefRecordStatusTypeId");

                    b.Navigation("DataCollection");

                    b.Navigation("RecordStatus");

                    b.Navigation("RefRecordStatusCreatorEntity");

                    b.Navigation("RefRecordStatusType");
                });

            modelBuilder.Entity("Autobahn.Entities.RefRecordStatusCreatorEntity", b =>
                {
                    b.HasOne("Autobahn.Entities.DataCollection", "DataCollection")
                        .WithMany()
                        .HasForeignKey("DataCollectionId");

                    b.HasOne("Autobahn.Entities.Organization", "Organization")
                        .WithMany()
                        .HasForeignKey("OrganizationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Autobahn.Entities.RecordStatus", "RecordStatus")
                        .WithMany()
                        .HasForeignKey("RecordStatusId");

                    b.Navigation("DataCollection");

                    b.Navigation("Organization");

                    b.Navigation("RecordStatus");
                });

            modelBuilder.Entity("Autobahn.Entities.RefRecordStatusType", b =>
                {
                    b.HasOne("Autobahn.Entities.DataCollection", "DataCollection")
                        .WithMany()
                        .HasForeignKey("DataCollectionId");

                    b.HasOne("Autobahn.Entities.Organization", "Organization")
                        .WithMany()
                        .HasForeignKey("OrganizationId");

                    b.HasOne("Autobahn.Entities.RecordStatus", "RecordStatus")
                        .WithMany()
                        .HasForeignKey("RecordStatusId");

                    b.Navigation("DataCollection");

                    b.Navigation("Organization");

                    b.Navigation("RecordStatus");
                });

            modelBuilder.Entity("Autobahn.Entities.DataCollection", b =>
                {
                    b.Navigation("Activities");

                    b.Navigation("Organizations");
                });

            modelBuilder.Entity("Autobahn.Entities.Organization", b =>
                {
                    b.Navigation("Activities");
                });

            modelBuilder.Entity("Autobahn.Entities.RecordStatus", b =>
                {
                    b.Navigation("Activities");

                    b.Navigation("Organizations");
                });
#pragma warning restore 612, 618
        }
    }
}
