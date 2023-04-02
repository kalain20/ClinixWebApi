using System.ComponentModel.DataAnnotations;

namespace ClinixWebApi.Models
{
    public class Localization
    {
        [Key]
        public int Id { get; set; }
        public string Commune { get; set; }
        public string Sector { get; set; }
    }
}
