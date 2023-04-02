using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClinixWebApi.Migrations
{
    /// <inheritdoc />
    public partial class createPrescription : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_patients_beneficiary_BeneficiaryId",
                table: "patients");

            migrationBuilder.DropForeignKey(
                name: "FK_patients_doctors_DoctorId",
                table: "patients");

            migrationBuilder.DropForeignKey(
                name: "FK_patients_nurses_NurseId",
                table: "patients");

            migrationBuilder.DropForeignKey(
                name: "FK_patients_users_Id",
                table: "patients");

            migrationBuilder.DropPrimaryKey(
                name: "PK_patients",
                table: "patients");

            migrationBuilder.RenameTable(
                name: "patients",
                newName: "prescription");

            migrationBuilder.RenameIndex(
                name: "IX_patients_NurseId",
                table: "prescription",
                newName: "IX_prescription_NurseId");

            migrationBuilder.RenameIndex(
                name: "IX_patients_DoctorId",
                table: "prescription",
                newName: "IX_prescription_DoctorId");

            migrationBuilder.RenameIndex(
                name: "IX_patients_BeneficiaryId",
                table: "prescription",
                newName: "IX_prescription_BeneficiaryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_prescription",
                table: "prescription",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Prescriptions",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PrescriptionDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PatientId = table.Column<string>(type: "nvarchar(450)", nullable: true)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropPrimaryKey(
                name: "PK_prescription",
                table: "prescription");

            migrationBuilder.RenameTable(
                name: "prescription",
                newName: "patients");

            migrationBuilder.RenameIndex(
                name: "IX_prescription_NurseId",
                table: "patients",
                newName: "IX_patients_NurseId");

            migrationBuilder.RenameIndex(
                name: "IX_prescription_DoctorId",
                table: "patients",
                newName: "IX_patients_DoctorId");

            migrationBuilder.RenameIndex(
                name: "IX_prescription_BeneficiaryId",
                table: "patients",
                newName: "IX_patients_BeneficiaryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_patients",
                table: "patients",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_patients_beneficiary_BeneficiaryId",
                table: "patients",
                column: "BeneficiaryId",
                principalTable: "beneficiary",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_patients_doctors_DoctorId",
                table: "patients",
                column: "DoctorId",
                principalTable: "doctors",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_patients_nurses_NurseId",
                table: "patients",
                column: "NurseId",
                principalTable: "nurses",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_patients_users_Id",
                table: "patients",
                column: "Id",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
