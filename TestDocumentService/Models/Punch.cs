using System.ComponentModel.DataAnnotations;

namespace TestDocumentService.Models
{
    public class Punch
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public int PunchNumber { get; set; }
        [Required]
        public string? Description { get; set; }
        [Required]
        public string? Owner { get; set; }
        [Required]
        public string? Action { get; set; }
        //Navigation props
        [Required]
        public TestDocument? TestDocument { get; set; }
        public int TestId {get; set;}
        [Required]
        public Test? Test { get; set; }
    }
}