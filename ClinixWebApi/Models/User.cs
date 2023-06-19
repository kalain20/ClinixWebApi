using System.ComponentModel.DataAnnotations;

namespace ClinixWebApi.Models
{
    public class User
    {  
        [Key]
        public string Id { get; set; }
        public string UserName { get; set; }
        public string Name { get; set; }
        public string  Email { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Statement { get; set; }
        public bool AcceptTerm { get; set; }
        public string Token { get; set; }
    }
}
