using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClinixWebApi.Migrations
{
    /// <inheritdoc />
    public partial class createPatientV2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_prescription_beneficiary_BeneficiaryId",
                table: "prescription");

            migrationBuilder.DropForeignKey(
                name: "FK_prescription_doctors_DoctorId",
                table: "prescription");

            migrationBuilder.DropForeignKey(
                name: "FK_prescription_nurses_NurseId",
                table: "prescription");

            migrationBuilder.DropForeignKey(
                name: "FK_prescription_users_Id",
                table: "prescription");

            migrationBuilder.DropTable(
                name: "Prescriptions");

            migrationBuilder.DropIndex(
                name: "IX_prescription_BeneficiaryId",
                table: "prescription");

            migrationBuilder.DropIndex(
                name: "IX_prescription_DoctorId",
                table: "prescription");

            migrationBuilder.DropColumn(
                name: "BeneficiaryId",
                table: "prescription");

            migrationBuilder.DropColumn(
                name: "BirthDay",
                table: "prescription");

            migrationBuilder.DropColumn(
                name: "DoctorId",
                table: "prescription");

            migrationBuilder.DropColumn(
                name: "PatientState",
                table: "prescription");

            migrationBuilder.RenameColumn(
                name: "Photo",
                table: "prescription",
                newName: "PrescriptionDate");

            migrationBuilder.RenameColumn(
                name: "NurseId",
                table: "prescription",
                newName: "PatientId");

            migrationBuilder.RenameIndex(
                name: "IX_prescription_NurseId",
                table: "prescription",
                newName: "IX_prescription_PatientId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_prescription_patients_PatientId",
                table: "prescription",
                column: "PatientId",
                principalTable: "patients",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_prescription_patients_PatientId",
                table: "prescription");

            migrationBuilder.DropTable(
                name: "patients");

            migrationBuilder.RenameColumn(
                name: "PrescriptionDate",
                table: "prescription",
                newName: "Photo");

            migrationBuilder.RenameColumn(
                name: "PatientId",
                table: "prescription",
                newName: "NurseId");

            migrationBuilder.RenameIndex(
                name: "IX_prescription_PatientId",
                table: "prescription",
                newName: "IX_prescription_NurseId");

            migrationBuilder.AddColumn<string>(
                name: "BeneficiaryId",
                table: "prescription",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BirthDay",
                table: "prescription",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DoctorId",
                table: "prescription",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PatientState",
                table: "prescription",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Prescriptions",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PatientId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    PrescriptionDate = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prescriptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Prescriptions_prescription_PatientId",
                        column: x => x.PatientId,
                        principalTable: "prescription",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_prescription_BeneficiaryId",
                table: "prescription",
                column: "BeneficiaryId");

            migrationBuilder.CreateIndex(
                name: "IX_prescription_DoctorId",
                table: "prescription",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_Prescriptions_PatientId",
                table: "Prescriptions",
                column: "PatientId");

            migrationBuilder.AddForeignKey(
                name: "FK_prescription_beneficiary_BeneficiaryId",
                table: "prescription",
                column: "BeneficiaryId",
                principalTable: "beneficiary",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_prescription_doctors_DoctorId",
                table: "prescription",
                column: "DoctorId",
                principalTable: "doctors",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_prescription_nurses_NurseId",
                table: "prescription",
                column: "NurseId",
                principalTable: "nurses",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_prescription_users_Id",
                table: "prescription",
                column: "Id",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
