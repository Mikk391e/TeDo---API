using System.ComponentModel.DataAnnotations;
using TestDocumentService.Models.Enums;

namespace TestDocumentService.Models
{
    public class Firm
    {
        [Key]
        [Required]
        public int Id { get; set; } 
        public string? Name { get; set; }
        public string? FullAddress { get; set; }
        public List<TestType>? TestTypes { get; set; }

        //Navigation properties
        public ICollection<Participant>? Participants { get; set; }
        public ICollection<FirmTestDocument>? FirmTestDocuments { get; set; }
        public ICollection<TestDocument>? TestDocuments { get; set; }
    }
}