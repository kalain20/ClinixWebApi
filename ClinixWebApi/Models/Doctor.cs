namespace ClinixWebApi.Models
{
    public class Doctor : User
    {
        public string UserName { get; set; }
        
        public string IdentityCartNumber { get; set; }
        public string Photo { get; set; }
        public string AuthorizationNumber{ get; set; }
        public string Diploma { get; set; }
        public int YearExperience { get; set; }


    }
}
