using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ACiS.Migrations
{
    /// <inheritdoc />
    public partial class InitTable_v10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "countrys",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArabicName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_countrys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "departments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AcademicCode = table.Column<int>(type: "int", nullable: false),
                    ArabicName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_departments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "faculities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_faculities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "gradingCriterias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaxGrade = table.Column<int>(type: "int", nullable: false),
                    A = table.Column<int>(type: "int", nullable: false),
                    B = table.Column<int>(type: "int", nullable: false),
                    C = table.Column<int>(type: "int", nullable: false),
                    D = table.Column<int>(type: "int", nullable: false),
                    MinGrade = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gradingCriterias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "positions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArabicName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_positions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "schoolYears",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Year = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsExamStarted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_schoolYears", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "stages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArabicName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_stages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "status",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumberOftries = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_status", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "citys",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArabicName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CountryBelongToId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_citys", x => x.Id);
                    table.ForeignKey(
                        name: "FK_citys_countrys_CountryBelongToId",
                        column: x => x.CountryBelongToId,
                        principalTable: "countrys",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "divisions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AcademicCode = table.Column<int>(type: "int", nullable: false),
                    ArabicName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    departmentId = table.Column<int>(type: "int", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_divisions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_divisions_departments_departmentId",
                        column: x => x.departmentId,
                        principalTable: "departments",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "subjects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AcademicCode = table.Column<int>(type: "int", nullable: false),
                    ArabicName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    stageId = table.Column<int>(type: "int", nullable: true),
                    gradingCriteriaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_subjects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_subjects_gradingCriterias_gradingCriteriaId",
                        column: x => x.gradingCriteriaId,
                        principalTable: "gradingCriterias",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_subjects_stages_stageId",
                        column: x => x.stageId,
                        principalTable: "stages",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MiltaryStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MiltaryId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Qualification = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QualificationFaculityId = table.Column<int>(type: "int", nullable: true),
                    QualificationYear = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AcadmicCode = table.Column<int>(type: "int", nullable: false),
                    ArabicFirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArabicLastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishFirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishLastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BirthCountryId = table.Column<int>(type: "int", nullable: true),
                    BirthCityId = table.Column<int>(type: "int", nullable: true),
                    LivingCountryId = table.Column<int>(type: "int", nullable: true),
                    LivingCityId = table.Column<int>(type: "int", nullable: true),
                    NationalityId = table.Column<int>(type: "int", nullable: true),
                    SSID = table.Column<int>(type: "int", nullable: false),
                    MobileNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TelephoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostalAdress = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_students", x => x.Id);
                    table.ForeignKey(
                        name: "FK_students_citys_BirthCityId",
                        column: x => x.BirthCityId,
                        principalTable: "citys",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_students_citys_LivingCityId",
                        column: x => x.LivingCityId,
                        principalTable: "citys",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_students_countrys_BirthCountryId",
                        column: x => x.BirthCountryId,
                        principalTable: "countrys",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_students_countrys_LivingCountryId",
                        column: x => x.LivingCountryId,
                        principalTable: "countrys",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_students_countrys_NationalityId",
                        column: x => x.NationalityId,
                        principalTable: "countrys",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_students_faculities_QualificationFaculityId",
                        column: x => x.QualificationFaculityId,
                        principalTable: "faculities",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "specialtys",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    departmentId = table.Column<int>(type: "int", nullable: true),
                    divisionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_specialtys", x => x.Id);
                    table.ForeignKey(
                        name: "FK_specialtys_departments_departmentId",
                        column: x => x.departmentId,
                        principalTable: "departments",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_specialtys_divisions_divisionId",
                        column: x => x.divisionId,
                        principalTable: "divisions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "subjectsdata",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    subjectId = table.Column<int>(type: "int", nullable: true),
                    divisionId = table.Column<int>(type: "int", nullable: true),
                    stageId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_subjectsdata", x => x.Id);
                    table.ForeignKey(
                        name: "FK_subjectsdata_divisions_divisionId",
                        column: x => x.divisionId,
                        principalTable: "divisions",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_subjectsdata_stages_stageId",
                        column: x => x.stageId,
                        principalTable: "stages",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_subjectsdata_subjects_subjectId",
                        column: x => x.subjectId,
                        principalTable: "subjects",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "studentExams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    studentId = table.Column<int>(type: "int", nullable: true),
                    SettingNumber = table.Column<int>(type: "int", nullable: true),
                    ThisYearStatusId = table.Column<int>(type: "int", nullable: true),
                    stageId = table.Column<int>(type: "int", nullable: true),
                    yearId = table.Column<int>(type: "int", nullable: true),
                    Descrption = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_studentExams", x => x.Id);
                    table.ForeignKey(
                        name: "FK_studentExams_schoolYears_yearId",
                        column: x => x.yearId,
                        principalTable: "schoolYears",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_studentExams_stages_stageId",
                        column: x => x.stageId,
                        principalTable: "stages",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_studentExams_status_ThisYearStatusId",
                        column: x => x.ThisYearStatusId,
                        principalTable: "status",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_studentExams_students_studentId",
                        column: x => x.studentId,
                        principalTable: "students",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "studentsData",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    studentId = table.Column<int>(type: "int", nullable: true),
                    statusId = table.Column<int>(type: "int", nullable: true),
                    stageId = table.Column<int>(type: "int", nullable: true),
                    DepartmentId = table.Column<int>(type: "int", nullable: true),
                    divisionId = table.Column<int>(type: "int", nullable: true),
                    RegstrationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_studentsData", x => x.Id);
                    table.ForeignKey(
                        name: "FK_studentsData_departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "departments",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_studentsData_divisions_divisionId",
                        column: x => x.divisionId,
                        principalTable: "divisions",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_studentsData_stages_stageId",
                        column: x => x.stageId,
                        principalTable: "stages",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_studentsData_status_statusId",
                        column: x => x.statusId,
                        principalTable: "status",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_studentsData_students_studentId",
                        column: x => x.studentId,
                        principalTable: "students",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "subjectsMarks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    studentId = table.Column<int>(type: "int", nullable: true),
                    subjectId = table.Column<int>(type: "int", nullable: true),
                    ExamMark = table.Column<int>(type: "int", nullable: false),
                    FinalMark = table.Column<int>(type: "int", nullable: false),
                    IsPassed = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_subjectsMarks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_subjectsMarks_students_studentId",
                        column: x => x.studentId,
                        principalTable: "students",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_subjectsMarks_subjects_subjectId",
                        column: x => x.subjectId,
                        principalTable: "subjects",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Professors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SpecialtizationId = table.Column<int>(type: "int", nullable: true),
                    PositionId = table.Column<int>(type: "int", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    University = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    facultyId = table.Column<int>(type: "int", nullable: true),
                    AcadmicCode = table.Column<int>(type: "int", nullable: false),
                    ArabicFirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArabicLastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishFirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishLastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BirthCountryId = table.Column<int>(type: "int", nullable: true),
                    BirthCityId = table.Column<int>(type: "int", nullable: true),
                    LivingCountryId = table.Column<int>(type: "int", nullable: true),
                    LivingCityId = table.Column<int>(type: "int", nullable: true),
                    NationalityId = table.Column<int>(type: "int", nullable: true),
                    SSID = table.Column<int>(type: "int", nullable: false),
                    MobileNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TelephoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostalAdress = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Professors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Professors_citys_BirthCityId",
                        column: x => x.BirthCityId,
                        principalTable: "citys",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Professors_citys_LivingCityId",
                        column: x => x.LivingCityId,
                        principalTable: "citys",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Professors_countrys_BirthCountryId",
                        column: x => x.BirthCountryId,
                        principalTable: "countrys",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Professors_countrys_LivingCountryId",
                        column: x => x.LivingCountryId,
                        principalTable: "countrys",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Professors_countrys_NationalityId",
                        column: x => x.NationalityId,
                        principalTable: "countrys",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Professors_faculities_facultyId",
                        column: x => x.facultyId,
                        principalTable: "faculities",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Professors_positions_PositionId",
                        column: x => x.PositionId,
                        principalTable: "positions",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Professors_specialtys_SpecialtizationId",
                        column: x => x.SpecialtizationId,
                        principalTable: "specialtys",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "authorities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: true),
                    termId = table.Column<int>(type: "int", nullable: true),
                    SubjectId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_authorities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_authorities_subjects_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "subjects",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_authorities_subjectsdata_termId",
                        column: x => x.termId,
                        principalTable: "subjectsdata",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "subjectProffs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProfessorId = table.Column<int>(type: "int", nullable: true),
                    subjectId = table.Column<int>(type: "int", nullable: true),
                    YearId = table.Column<int>(type: "int", nullable: true),
                    AutoLiftingDegree = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_subjectProffs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_subjectProffs_Professors_ProfessorId",
                        column: x => x.ProfessorId,
                        principalTable: "Professors",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_subjectProffs_schoolYears_YearId",
                        column: x => x.YearId,
                        principalTable: "schoolYears",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_subjectProffs_subjects_subjectId",
                        column: x => x.subjectId,
                        principalTable: "subjects",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArabicName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    authorityId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_users_authorities_authorityId",
                        column: x => x.authorityId,
                        principalTable: "authorities",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_authorities_SubjectId",
                table: "authorities",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_authorities_termId",
                table: "authorities",
                column: "termId");

            migrationBuilder.CreateIndex(
                name: "IX_citys_CountryBelongToId",
                table: "citys",
                column: "CountryBelongToId");

            migrationBuilder.CreateIndex(
                name: "IX_divisions_departmentId",
                table: "divisions",
                column: "departmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Professors_BirthCityId",
                table: "Professors",
                column: "BirthCityId");

            migrationBuilder.CreateIndex(
                name: "IX_Professors_BirthCountryId",
                table: "Professors",
                column: "BirthCountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Professors_facultyId",
                table: "Professors",
                column: "facultyId");

            migrationBuilder.CreateIndex(
                name: "IX_Professors_LivingCityId",
                table: "Professors",
                column: "LivingCityId");

            migrationBuilder.CreateIndex(
                name: "IX_Professors_LivingCountryId",
                table: "Professors",
                column: "LivingCountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Professors_NationalityId",
                table: "Professors",
                column: "NationalityId");

            migrationBuilder.CreateIndex(
                name: "IX_Professors_PositionId",
                table: "Professors",
                column: "PositionId");

            migrationBuilder.CreateIndex(
                name: "IX_Professors_SpecialtizationId",
                table: "Professors",
                column: "SpecialtizationId");

            migrationBuilder.CreateIndex(
                name: "IX_specialtys_departmentId",
                table: "specialtys",
                column: "departmentId");

            migrationBuilder.CreateIndex(
                name: "IX_specialtys_divisionId",
                table: "specialtys",
                column: "divisionId");

            migrationBuilder.CreateIndex(
                name: "IX_studentExams_stageId",
                table: "studentExams",
                column: "stageId");

            migrationBuilder.CreateIndex(
                name: "IX_studentExams_studentId",
                table: "studentExams",
                column: "studentId");

            migrationBuilder.CreateIndex(
                name: "IX_studentExams_ThisYearStatusId",
                table: "studentExams",
                column: "ThisYearStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_studentExams_yearId",
                table: "studentExams",
                column: "yearId");

            migrationBuilder.CreateIndex(
                name: "IX_students_BirthCityId",
                table: "students",
                column: "BirthCityId");

            migrationBuilder.CreateIndex(
                name: "IX_students_BirthCountryId",
                table: "students",
                column: "BirthCountryId");

            migrationBuilder.CreateIndex(
                name: "IX_students_LivingCityId",
                table: "students",
                column: "LivingCityId");

            migrationBuilder.CreateIndex(
                name: "IX_students_LivingCountryId",
                table: "students",
                column: "LivingCountryId");

            migrationBuilder.CreateIndex(
                name: "IX_students_NationalityId",
                table: "students",
                column: "NationalityId");

            migrationBuilder.CreateIndex(
                name: "IX_students_QualificationFaculityId",
                table: "students",
                column: "QualificationFaculityId");

            migrationBuilder.CreateIndex(
                name: "IX_studentsData_DepartmentId",
                table: "studentsData",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_studentsData_divisionId",
                table: "studentsData",
                column: "divisionId");

            migrationBuilder.CreateIndex(
                name: "IX_studentsData_stageId",
                table: "studentsData",
                column: "stageId");

            migrationBuilder.CreateIndex(
                name: "IX_studentsData_statusId",
                table: "studentsData",
                column: "statusId");

            migrationBuilder.CreateIndex(
                name: "IX_studentsData_studentId",
                table: "studentsData",
                column: "studentId");

            migrationBuilder.CreateIndex(
                name: "IX_subjectProffs_ProfessorId",
                table: "subjectProffs",
                column: "ProfessorId");

            migrationBuilder.CreateIndex(
                name: "IX_subjectProffs_subjectId",
                table: "subjectProffs",
                column: "subjectId");

            migrationBuilder.CreateIndex(
                name: "IX_subjectProffs_YearId",
                table: "subjectProffs",
                column: "YearId");

            migrationBuilder.CreateIndex(
                name: "IX_subjects_gradingCriteriaId",
                table: "subjects",
                column: "gradingCriteriaId");

            migrationBuilder.CreateIndex(
                name: "IX_subjects_stageId",
                table: "subjects",
                column: "stageId");

            migrationBuilder.CreateIndex(
                name: "IX_subjectsdata_divisionId",
                table: "subjectsdata",
                column: "divisionId");

            migrationBuilder.CreateIndex(
                name: "IX_subjectsdata_stageId",
                table: "subjectsdata",
                column: "stageId");

            migrationBuilder.CreateIndex(
                name: "IX_subjectsdata_subjectId",
                table: "subjectsdata",
                column: "subjectId");

            migrationBuilder.CreateIndex(
                name: "IX_subjectsMarks_studentId",
                table: "subjectsMarks",
                column: "studentId");

            migrationBuilder.CreateIndex(
                name: "IX_subjectsMarks_subjectId",
                table: "subjectsMarks",
                column: "subjectId");

            migrationBuilder.CreateIndex(
                name: "IX_users_authorityId",
                table: "users",
                column: "authorityId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "studentExams");

            migrationBuilder.DropTable(
                name: "studentsData");

            migrationBuilder.DropTable(
                name: "subjectProffs");

            migrationBuilder.DropTable(
                name: "subjectsMarks");

            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropTable(
                name: "status");

            migrationBuilder.DropTable(
                name: "Professors");

            migrationBuilder.DropTable(
                name: "schoolYears");

            migrationBuilder.DropTable(
                name: "students");

            migrationBuilder.DropTable(
                name: "authorities");

            migrationBuilder.DropTable(
                name: "positions");

            migrationBuilder.DropTable(
                name: "specialtys");

            migrationBuilder.DropTable(
                name: "citys");

            migrationBuilder.DropTable(
                name: "faculities");

            migrationBuilder.DropTable(
                name: "subjectsdata");

            migrationBuilder.DropTable(
                name: "countrys");

            migrationBuilder.DropTable(
                name: "divisions");

            migrationBuilder.DropTable(
                name: "subjects");

            migrationBuilder.DropTable(
                name: "departments");

            migrationBuilder.DropTable(
                name: "gradingCriterias");

            migrationBuilder.DropTable(
                name: "stages");
        }
    }
}
