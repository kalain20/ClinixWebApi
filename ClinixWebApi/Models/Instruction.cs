using System.ComponentModel.DataAnnotations;

namespace ClinixWebApi.Models
{
    public class Instruction
    {
        [Key]
        public string Id { get; set; }
        public string Content { get; set; }
        public string ReleaseDate { get; set; }
        public string EndDate { get; set; }
    }
}
