using System.ComponentModel.DataAnnotations;

namespace TestDocumentService.Models
{
    public class Revision
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string? PageAffected { get; set; }
        public string? ChapterAffected { get; set; }
        public string? Description { get; set; }
        public string? Date { get; set; }

        //Navigation properties
        public int TestDocumentId { get; set; }
        public TestDocument? TestDocument { get; set; }

    }
}