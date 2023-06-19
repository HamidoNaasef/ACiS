﻿// <auto-generated />
using System;
using ACiS.DBContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ACiS.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    [Migration("20230617214328_InitTable_v1.0")]
    partial class InitTable_v10
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ACiS.Models.Authority", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SubjectId")
                        .HasColumnType("int");

                    b.Property<int?>("Year")
                        .HasColumnType("int");

                    b.Property<int?>("termId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SubjectId");

                    b.HasIndex("termId");

                    b.ToTable("authorities");
                });

            modelBuilder.Entity("ACiS.Models.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ArabicName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CountryBelongToId")
                        .HasColumnType("int");

                    b.Property<string>("EnglishName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CountryBelongToId");

                    b.ToTable("citys");
                });

            modelBuilder.Entity("ACiS.Models.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ArabicName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EnglishName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("countrys");
                });

            modelBuilder.Entity("ACiS.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AcademicCode")
                        .HasColumnType("int");

                    b.Property<string>("ArabicName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EnglishName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("departments");
                });

            modelBuilder.Entity("ACiS.Models.Division", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AcademicCode")
                        .HasColumnType("int");

                    b.Property<string>("ArabicName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EnglishName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("departmentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("departmentId");

                    b.ToTable("divisions");
                });

            modelBuilder.Entity("ACiS.Models.Faculity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("faculities");
                });

            modelBuilder.Entity("ACiS.Models.GradingCriteria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("A")
                        .HasColumnType("int");

                    b.Property<int>("B")
                        .HasColumnType("int");

                    b.Property<int>("C")
                        .HasColumnType("int");

                    b.Property<int>("D")
                        .HasColumnType("int");

                    b.Property<int>("MaxGrade")
                        .HasColumnType("int");

                    b.Property<int>("MinGrade")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("gradingCriterias");
                });

            modelBuilder.Entity("ACiS.Models.Position", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ArabicName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EnglishName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("positions");
                });

            modelBuilder.Entity("ACiS.Models.Professor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AcadmicCode")
                        .HasColumnType("int");

                    b.Property<string>("Adress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ArabicFirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ArabicLastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("BirthCityId")
                        .HasColumnType("int");

                    b.Property<int?>("BirthCountryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EnglishFirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EnglishLastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("LivingCityId")
                        .HasColumnType("int");

                    b.Property<int?>("LivingCountryId")
                        .HasColumnType("int");

                    b.Property<string>("MobileNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("NationalityId")
                        .HasColumnType("int");

                    b.Property<int?>("PositionId")
                        .HasColumnType("int");

                    b.Property<string>("PostalAdress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SSID")
                        .HasColumnType("int");

                    b.Property<int?>("SpecialtizationId")
                        .HasColumnType("int");

                    b.Property<string>("TelephoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BirthCityId");

                    b.HasIndex("BirthCountryId");

                    b.HasIndex("LivingCityId");

                    b.HasIndex("LivingCountryId");

                    b.HasIndex("NationalityId");

                    b.HasIndex("PositionId");

                    b.HasIndex("SpecialtizationId");

                    b.ToTable("Professors");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Professor");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("ACiS.Models.SchoolYear", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsExamStarted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Year")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("schoolYears");
                });

            modelBuilder.Entity("ACiS.Models.Specialty", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("departmentId")
                        .HasColumnType("int");

                    b.Property<int?>("divisionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("departmentId");

                    b.HasIndex("divisionId");

                    b.ToTable("specialtys");
                });

            modelBuilder.Entity("ACiS.Models.Stage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ArabicName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("stages");
                });

            modelBuilder.Entity("ACiS.Models.Status", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberOftries")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("status");
                });

            modelBuilder.Entity("ACiS.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AcadmicCode")
                        .HasColumnType("int");

                    b.Property<string>("Adress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ArabicFirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ArabicLastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("BirthCityId")
                        .HasColumnType("int");

                    b.Property<int?>("BirthCountryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EnglishFirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EnglishLastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("LivingCityId")
                        .HasColumnType("int");

                    b.Property<int?>("LivingCountryId")
                        .HasColumnType("int");

                    b.Property<string>("MiltaryId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MiltaryStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MobileNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("NationalityId")
                        .HasColumnType("int");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalAdress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Qualification")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("QualificationFaculityId")
                        .HasColumnType("int");

                    b.Property<string>("QualificationYear")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SSID")
                        .HasColumnType("int");

                    b.Property<string>("TelephoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BirthCityId");

                    b.HasIndex("BirthCountryId");

                    b.HasIndex("LivingCityId");

                    b.HasIndex("LivingCountryId");

                    b.HasIndex("NationalityId");

                    b.HasIndex("QualificationFaculityId");

                    b.ToTable("students");
                });

            modelBuilder.Entity("ACiS.Models.StudentData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<DateTime>("RegstrationDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("divisionId")
                        .HasColumnType("int");

                    b.Property<int?>("stageId")
                        .HasColumnType("int");

                    b.Property<int?>("statusId")
                        .HasColumnType("int");

                    b.Property<int?>("studentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("divisionId");

                    b.HasIndex("stageId");

                    b.HasIndex("statusId");

                    b.HasIndex("studentId");

                    b.ToTable("studentsData");
                });

            modelBuilder.Entity("ACiS.Models.StudentExamData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descrption")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SettingNumber")
                        .HasColumnType("int");

                    b.Property<int?>("ThisYearStatusId")
                        .HasColumnType("int");

                    b.Property<int?>("stageId")
                        .HasColumnType("int");

                    b.Property<int?>("studentId")
                        .HasColumnType("int");

                    b.Property<int?>("yearId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ThisYearStatusId");

                    b.HasIndex("stageId");

                    b.HasIndex("studentId");

                    b.HasIndex("yearId");

                    b.ToTable("studentExams");
                });

            modelBuilder.Entity("ACiS.Models.Subject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AcademicCode")
                        .HasColumnType("int");

                    b.Property<string>("ArabicName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EnglishName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("gradingCriteriaId")
                        .HasColumnType("int");

                    b.Property<int?>("stageId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("gradingCriteriaId");

                    b.HasIndex("stageId");

                    b.ToTable("subjects");
                });

            modelBuilder.Entity("ACiS.Models.SubjectData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("divisionId")
                        .HasColumnType("int");

                    b.Property<int?>("stageId")
                        .HasColumnType("int");

                    b.Property<int?>("subjectId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("divisionId");

                    b.HasIndex("stageId");

                    b.HasIndex("subjectId");

                    b.ToTable("subjectsdata");
                });

            modelBuilder.Entity("ACiS.Models.SubjectProff", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AutoLiftingDegree")
                        .HasColumnType("int");

                    b.Property<int?>("ProfessorId")
                        .HasColumnType("int");

                    b.Property<int?>("YearId")
                        .HasColumnType("int");

                    b.Property<int?>("subjectId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProfessorId");

                    b.HasIndex("YearId");

                    b.HasIndex("subjectId");

                    b.ToTable("subjectProffs");
                });

            modelBuilder.Entity("ACiS.Models.SubjectsMarks", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ExamMark")
                        .HasColumnType("int");

                    b.Property<int>("FinalMark")
                        .HasColumnType("int");

                    b.Property<bool>("IsPassed")
                        .HasColumnType("bit");

                    b.Property<int?>("studentId")
                        .HasColumnType("int");

                    b.Property<int?>("subjectId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("studentId");

                    b.HasIndex("subjectId");

                    b.ToTable("subjectsMarks");
                });

            modelBuilder.Entity("ACiS.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ArabicName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("authorityId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("authorityId");

                    b.ToTable("users");
                });

            modelBuilder.Entity("ACiS.Models.GuestProfesor", b =>
                {
                    b.HasBaseType("ACiS.Models.Professor");

                    b.Property<string>("University")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("facultyId")
                        .HasColumnType("int");

                    b.HasIndex("facultyId");

                    b.HasDiscriminator().HasValue("GuestProfesor");
                });

            modelBuilder.Entity("ACiS.Models.Authority", b =>
                {
                    b.HasOne("ACiS.Models.Subject", "Subject")
                        .WithMany()
                        .HasForeignKey("SubjectId");

                    b.HasOne("ACiS.Models.SubjectData", "term")
                        .WithMany()
                        .HasForeignKey("termId");

                    b.Navigation("Subject");

                    b.Navigation("term");
                });

            modelBuilder.Entity("ACiS.Models.City", b =>
                {
                    b.HasOne("ACiS.Models.Country", "CountryBelongTo")
                        .WithMany()
                        .HasForeignKey("CountryBelongToId");

                    b.Navigation("CountryBelongTo");
                });

            modelBuilder.Entity("ACiS.Models.Division", b =>
                {
                    b.HasOne("ACiS.Models.Department", "department")
                        .WithMany()
                        .HasForeignKey("departmentId");

                    b.Navigation("department");
                });

            modelBuilder.Entity("ACiS.Models.Professor", b =>
                {
                    b.HasOne("ACiS.Models.City", "BirthCity")
                        .WithMany()
                        .HasForeignKey("BirthCityId");

                    b.HasOne("ACiS.Models.Country", "BirthCountry")
                        .WithMany()
                        .HasForeignKey("BirthCountryId");

                    b.HasOne("ACiS.Models.City", "LivingCity")
                        .WithMany()
                        .HasForeignKey("LivingCityId");

                    b.HasOne("ACiS.Models.Country", "LivingCountry")
                        .WithMany()
                        .HasForeignKey("LivingCountryId");

                    b.HasOne("ACiS.Models.Country", "Nationality")
                        .WithMany()
                        .HasForeignKey("NationalityId");

                    b.HasOne("ACiS.Models.Position", "Position")
                        .WithMany()
                        .HasForeignKey("PositionId");

                    b.HasOne("ACiS.Models.Specialty", "Specialtization")
                        .WithMany()
                        .HasForeignKey("SpecialtizationId");

                    b.Navigation("BirthCity");

                    b.Navigation("BirthCountry");

                    b.Navigation("LivingCity");

                    b.Navigation("LivingCountry");

                    b.Navigation("Nationality");

                    b.Navigation("Position");

                    b.Navigation("Specialtization");
                });

            modelBuilder.Entity("ACiS.Models.Specialty", b =>
                {
                    b.HasOne("ACiS.Models.Department", "department")
                        .WithMany()
                        .HasForeignKey("departmentId");

                    b.HasOne("ACiS.Models.Division", "division")
                        .WithMany()
                        .HasForeignKey("divisionId");

                    b.Navigation("department");

                    b.Navigation("division");
                });

            modelBuilder.Entity("ACiS.Models.Student", b =>
                {
                    b.HasOne("ACiS.Models.City", "BirthCity")
                        .WithMany()
                        .HasForeignKey("BirthCityId");

                    b.HasOne("ACiS.Models.Country", "BirthCountry")
                        .WithMany()
                        .HasForeignKey("BirthCountryId");

                    b.HasOne("ACiS.Models.City", "LivingCity")
                        .WithMany()
                        .HasForeignKey("LivingCityId");

                    b.HasOne("ACiS.Models.Country", "LivingCountry")
                        .WithMany()
                        .HasForeignKey("LivingCountryId");

                    b.HasOne("ACiS.Models.Country", "Nationality")
                        .WithMany()
                        .HasForeignKey("NationalityId");

                    b.HasOne("ACiS.Models.Faculity", "QualificationFaculity")
                        .WithMany()
                        .HasForeignKey("QualificationFaculityId");

                    b.Navigation("BirthCity");

                    b.Navigation("BirthCountry");

                    b.Navigation("LivingCity");

                    b.Navigation("LivingCountry");

                    b.Navigation("Nationality");

                    b.Navigation("QualificationFaculity");
                });

            modelBuilder.Entity("ACiS.Models.StudentData", b =>
                {
                    b.HasOne("ACiS.Models.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentId");

                    b.HasOne("ACiS.Models.Division", "division")
                        .WithMany()
                        .HasForeignKey("divisionId");

                    b.HasOne("ACiS.Models.Stage", "stage")
                        .WithMany()
                        .HasForeignKey("stageId");

                    b.HasOne("ACiS.Models.Status", "status")
                        .WithMany()
                        .HasForeignKey("statusId");

                    b.HasOne("ACiS.Models.Student", "student")
                        .WithMany()
                        .HasForeignKey("studentId");

                    b.Navigation("Department");

                    b.Navigation("division");

                    b.Navigation("stage");

                    b.Navigation("status");

                    b.Navigation("student");
                });

            modelBuilder.Entity("ACiS.Models.StudentExamData", b =>
                {
                    b.HasOne("ACiS.Models.Status", "ThisYearStatus")
                        .WithMany()
                        .HasForeignKey("ThisYearStatusId");

                    b.HasOne("ACiS.Models.Stage", "stage")
                        .WithMany()
                        .HasForeignKey("stageId");

                    b.HasOne("ACiS.Models.Student", "student")
                        .WithMany()
                        .HasForeignKey("studentId");

                    b.HasOne("ACiS.Models.SchoolYear", "year")
                        .WithMany()
                        .HasForeignKey("yearId");

                    b.Navigation("ThisYearStatus");

                    b.Navigation("stage");

                    b.Navigation("student");

                    b.Navigation("year");
                });

            modelBuilder.Entity("ACiS.Models.Subject", b =>
                {
                    b.HasOne("ACiS.Models.GradingCriteria", "gradingCriteria")
                        .WithMany()
                        .HasForeignKey("gradingCriteriaId");

                    b.HasOne("ACiS.Models.Stage", "stage")
                        .WithMany()
                        .HasForeignKey("stageId");

                    b.Navigation("gradingCriteria");

                    b.Navigation("stage");
                });

            modelBuilder.Entity("ACiS.Models.SubjectData", b =>
                {
                    b.HasOne("ACiS.Models.Division", "division")
                        .WithMany()
                        .HasForeignKey("divisionId");

                    b.HasOne("ACiS.Models.Stage", "stage")
                        .WithMany()
                        .HasForeignKey("stageId");

                    b.HasOne("ACiS.Models.Subject", "subject")
                        .WithMany()
                        .HasForeignKey("subjectId");

                    b.Navigation("division");

                    b.Navigation("stage");

                    b.Navigation("subject");
                });

            modelBuilder.Entity("ACiS.Models.SubjectProff", b =>
                {
                    b.HasOne("ACiS.Models.Professor", "Professor")
                        .WithMany()
                        .HasForeignKey("ProfessorId");

                    b.HasOne("ACiS.Models.SchoolYear", "Year")
                        .WithMany()
                        .HasForeignKey("YearId");

                    b.HasOne("ACiS.Models.Subject", "subject")
                        .WithMany()
                        .HasForeignKey("subjectId");

                    b.Navigation("Professor");

                    b.Navigation("Year");

                    b.Navigation("subject");
                });

            modelBuilder.Entity("ACiS.Models.SubjectsMarks", b =>
                {
                    b.HasOne("ACiS.Models.Student", "student")
                        .WithMany()
                        .HasForeignKey("studentId");

                    b.HasOne("ACiS.Models.Subject", "subject")
                        .WithMany()
                        .HasForeignKey("subjectId");

                    b.Navigation("student");

                    b.Navigation("subject");
                });

            modelBuilder.Entity("ACiS.Models.User", b =>
                {
                    b.HasOne("ACiS.Models.Authority", "authority")
                        .WithMany()
                        .HasForeignKey("authorityId");

                    b.Navigation("authority");
                });

            modelBuilder.Entity("ACiS.Models.GuestProfesor", b =>
                {
                    b.HasOne("ACiS.Models.Faculity", "faculty")
                        .WithMany()
                        .HasForeignKey("facultyId");

                    b.Navigation("faculty");
                });
#pragma warning restore 612, 618
        }
    }
}