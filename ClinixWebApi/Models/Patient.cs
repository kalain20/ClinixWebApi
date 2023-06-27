namespace ClinixWebApi.Models
{
    public class Patient: User
    {
        public string BirthDay { get; set; }
        public string PatientState { get; set; }
        public string Photo { get; set; }
        public Doctor Doctor { get; set; }
        public Nurse Nurse { get; set; }
        public Beneficiary Beneficiary { get; set; }
    }
}
