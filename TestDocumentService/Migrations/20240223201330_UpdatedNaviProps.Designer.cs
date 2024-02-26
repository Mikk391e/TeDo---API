﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TestDocumentService.Data.Context;

#nullable disable

namespace TestDocumentService.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240223201330_UpdatedNaviProps")]
    partial class UpdatedNaviProps
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ParticipantTestDocument", b =>
                {
                    b.Property<int>("ParticipantsId")
                        .HasColumnType("int");

                    b.Property<int>("TestDocumentsId")
                        .HasColumnType("int");

                    b.HasKey("ParticipantsId", "TestDocumentsId");

                    b.HasIndex("TestDocumentsId");

                    b.ToTable("ParticipantTestDocument");
                });

            modelBuilder.Entity("PlaceOfTestingTestDocument", b =>
                {
                    b.Property<int>("PlaceOfTestingsId")
                        .HasColumnType("int");

                    b.Property<int>("TestDocumentsId")
                        .HasColumnType("int");

                    b.HasKey("PlaceOfTestingsId", "TestDocumentsId");

                    b.HasIndex("TestDocumentsId");

                    b.ToTable("PlaceOfTestingTestDocument");
                });

            modelBuilder.Entity("TestDocumentService.Models.Firm", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("FullAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PlaceOfTestingId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PlaceOfTestingId")
                        .IsUnique()
                        .HasFilter("[PlaceOfTestingId] IS NOT NULL");

                    b.ToTable("Firms");
                });

            modelBuilder.Entity("TestDocumentService.Models.Participant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Date")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FirmId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Signature")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FirmId");

                    b.ToTable("Participant");
                });

            modelBuilder.Entity("TestDocumentService.Models.PlaceOfTesting", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("FimId")
                        .HasColumnType("int");

                    b.Property<int>("TestType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("PlaceOfTesting");
                });

            modelBuilder.Entity("TestDocumentService.Models.Punch", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Action")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Owner")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PunchNumber")
                        .HasColumnType("int");

                    b.Property<int>("TestDocumentId")
                        .HasColumnType("int");

                    b.Property<int>("TestId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TestDocumentId");

                    b.HasIndex("TestId")
                        .IsUnique();

                    b.ToTable("Punches");
                });

            modelBuilder.Entity("TestDocumentService.Models.Revision", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ChapterAffected")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Date")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<string>("PageAffected")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TestDocumentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TestDocumentId");

                    b.ToTable("Revisions");
                });

            modelBuilder.Entity("TestDocumentService.Models.Test", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FATInitials")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IATInitials")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OATInitials")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PuchId")
                        .HasColumnType("int");

                    b.Property<string>("SATInitials")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TestDocumentId")
                        .HasColumnType("int");

                    b.Property<string>("TestProcedure")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Test");
                });

            modelBuilder.Entity("TestDocumentService.Models.TestDocument", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("DocumentSupplied")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Introduction")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TestDocuments");
                });

            modelBuilder.Entity("TestTestDocument", b =>
                {
                    b.Property<int>("TestDocumentId")
                        .HasColumnType("int");

                    b.Property<int>("TestsId")
                        .HasColumnType("int");

                    b.HasKey("TestDocumentId", "TestsId");

                    b.HasIndex("TestsId");

                    b.ToTable("TestTestDocument");
                });

            modelBuilder.Entity("ParticipantTestDocument", b =>
                {
                    b.HasOne("TestDocumentService.Models.Participant", null)
                        .WithMany()
                        .HasForeignKey("ParticipantsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TestDocumentService.Models.TestDocument", null)
                        .WithMany()
                        .HasForeignKey("TestDocumentsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PlaceOfTestingTestDocument", b =>
                {
                    b.HasOne("TestDocumentService.Models.PlaceOfTesting", null)
                        .WithMany()
                        .HasForeignKey("PlaceOfTestingsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TestDocumentService.Models.TestDocument", null)
                        .WithMany()
                        .HasForeignKey("TestDocumentsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TestDocumentService.Models.Firm", b =>
                {
                    b.HasOne("TestDocumentService.Models.PlaceOfTesting", "PlaceOfTesting")
                        .WithOne("Firm")
                        .HasForeignKey("TestDocumentService.Models.Firm", "PlaceOfTestingId");

                    b.Navigation("PlaceOfTesting");
                });

            modelBuilder.Entity("TestDocumentService.Models.Participant", b =>
                {
                    b.HasOne("TestDocumentService.Models.Firm", "Firm")
                        .WithMany("Participants")
                        .HasForeignKey("FirmId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Firm");
                });

            modelBuilder.Entity("TestDocumentService.Models.Punch", b =>
                {
                    b.HasOne("TestDocumentService.Models.TestDocument", "TestDocument")
                        .WithMany("PunchList")
                        .HasForeignKey("TestDocumentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TestDocumentService.Models.Test", "Test")
                        .WithOne("Punch")
                        .HasForeignKey("TestDocumentService.Models.Punch", "TestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Test");

                    b.Navigation("TestDocument");
                });

            modelBuilder.Entity("TestDocumentService.Models.Revision", b =>
                {
                    b.HasOne("TestDocumentService.Models.TestDocument", "TestDocument")
                        .WithMany("Revisions")
                        .HasForeignKey("TestDocumentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TestDocument");
                });

            modelBuilder.Entity("TestTestDocument", b =>
                {
                    b.HasOne("TestDocumentService.Models.TestDocument", null)
                        .WithMany()
                        .HasForeignKey("TestDocumentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TestDocumentService.Models.Test", null)
                        .WithMany()
                        .HasForeignKey("TestsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TestDocumentService.Models.Firm", b =>
                {
                    b.Navigation("Participants");
                });

            modelBuilder.Entity("TestDocumentService.Models.PlaceOfTesting", b =>
                {
                    b.Navigation("Firm")
                        .IsRequired();
                });

            modelBuilder.Entity("TestDocumentService.Models.Test", b =>
                {
                    b.Navigation("Punch");
                });

            modelBuilder.Entity("TestDocumentService.Models.TestDocument", b =>
                {
                    b.Navigation("PunchList");

                    b.Navigation("Revisions");
                });
#pragma warning restore 612, 618
        }
    }
}
