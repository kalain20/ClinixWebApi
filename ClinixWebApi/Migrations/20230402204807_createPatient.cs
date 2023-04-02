using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClinixWebApi.Migrations
{
    /// <inheritdoc />
    public partial class createPatient : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "patients",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BirthDay = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PatientState = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Photo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DoctorId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    NurseId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    BeneficiaryId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_patients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_patients_beneficiary_BeneficiaryId",
                        column: x => x.BeneficiaryId,
                        principalTable: "beneficiary",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_patients_doctors_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "doctors",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_patients_nurses_NurseId",
                        column: x => x.NurseId,
                        principalTable: "nurses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_patients_users_Id",
                        column: x => x.Id,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_patients_BeneficiaryId",
                table: "patients",
                column: "BeneficiaryId");

            migrationBuilder.CreateIndex(
                name: "IX_patients_DoctorId",
                table: "patients",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_patients_NurseId",
                table: "patients",
                column: "NurseId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "patients");
        }
    }
}
