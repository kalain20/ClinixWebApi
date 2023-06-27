namespace ClinixWebApi.Models;

public class Beneficiary : User
{
    public string UserName { get; set; }
    public string IdentityCartNumber { get; set; }
    public string Photo { get; set; }
    public int YearExperience { get; set; }
}