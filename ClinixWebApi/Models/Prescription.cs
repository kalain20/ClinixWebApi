using System.ComponentModel.DataAnnotations;

namespace ClinixWebApi.Models
{
    public class Prescription
    {
        [Key]
        public string Id { get; set; }
        public string PrescriptionDate { get; set; }
        public Patient Patient { get; set; }
    }
}
