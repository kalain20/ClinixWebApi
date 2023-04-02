﻿// <auto-generated />
using ClinixWebApi.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ClinixWebApi.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230402212302_createPatientV2")]
    partial class createPatientV2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ClinixWebApi.Models.Instruction", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EndDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReleaseDate")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("instruction", (string)null);
                });

            modelBuilder.Entity("ClinixWebApi.Models.Localization", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Commune")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sector")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("localization", (string)null);
                });

            modelBuilder.Entity("ClinixWebApi.Models.Prescription", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("PatientId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("PrescriptionDate")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PatientId");

                    b.ToTable("prescription", (string)null);
                });

            modelBuilder.Entity("ClinixWebApi.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("AcceptTerm")
                        .HasColumnType("bit");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Statement")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("users", (string)null);

                    b.UseTptMappingStrategy();
                });

            modelBuilder.Entity("ClinixWebApi.Models.Beneficiary", b =>
                {
                    b.HasBaseType("ClinixWebApi.Models.User");

                    b.Property<string>("IdentityCartNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Photo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("YearExperience")
                        .HasColumnType("int");

                    b.ToTable("beneficiary", (string)null);
                });

            modelBuilder.Entity("ClinixWebApi.Models.Doctor", b =>
                {
                    b.HasBaseType("ClinixWebApi.Models.User");

                    b.Property<string>("AuthorizationNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Diploma")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdentityCartNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Photo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("YearExperience")
                        .HasColumnType("int");

                    b.ToTable("doctors", (string)null);
                });

            modelBuilder.Entity("ClinixWebApi.Models.Nurse", b =>
                {
                    b.HasBaseType("ClinixWebApi.Models.User");

                    b.Property<string>("AuthorizationNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Diploma")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdentityCartNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Photo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("YearExperience")
                        .HasColumnType("int");

                    b.ToTable("nurses", (string)null);
                });

            modelBuilder.Entity("ClinixWebApi.Models.Patient", b =>
                {
                    b.HasBaseType("ClinixWebApi.Models.User");

                    b.Property<string>("BeneficiaryId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("BirthDay")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DoctorId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("NurseId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("PatientState")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Photo")
                        .HasColumnType("nvarchar(max)");

                    b.HasIndex("BeneficiaryId");

                    b.HasIndex("DoctorId");

                    b.HasIndex("NurseId");

                    b.ToTable("patients", (string)null);
                });

            modelBuilder.Entity("ClinixWebApi.Models.Prescription", b =>
                {
                    b.HasOne("ClinixWebApi.Models.Patient", "Patient")
                        .WithMany()
                        .HasForeignKey("PatientId");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("ClinixWebApi.Models.Beneficiary", b =>
                {
                    b.HasOne("ClinixWebApi.Models.User", null)
                        .WithOne()
                        .HasForeignKey("ClinixWebApi.Models.Beneficiary", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ClinixWebApi.Models.Doctor", b =>
                {
                    b.HasOne("ClinixWebApi.Models.User", null)
                        .WithOne()
                        .HasForeignKey("ClinixWebApi.Models.Doctor", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ClinixWebApi.Models.Nurse", b =>
                {
                    b.HasOne("ClinixWebApi.Models.User", null)
                        .WithOne()
                        .HasForeignKey("ClinixWebApi.Models.Nurse", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ClinixWebApi.Models.Patient", b =>
                {
                    b.HasOne("ClinixWebApi.Models.Beneficiary", "Beneficiary")
                        .WithMany()
                        .HasForeignKey("BeneficiaryId");

                    b.HasOne("ClinixWebApi.Models.Doctor", "Doctor")
                        .WithMany()
                        .HasForeignKey("DoctorId");

                    b.HasOne("ClinixWebApi.Models.User", null)
                        .WithOne()
                        .HasForeignKey("ClinixWebApi.Models.Patient", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ClinixWebApi.Models.Nurse", "Nurse")
                        .WithMany()
                        .HasForeignKey("NurseId");

                    b.Navigation("Beneficiary");

                    b.Navigation("Doctor");

                    b.Navigation("Nurse");
                });
#pragma warning restore 612, 618
        }
    }
}
