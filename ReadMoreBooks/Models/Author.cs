using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReadMoreBooks.Models
{
    public class Author
    {
        public int AuthorId { get; set; }

        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; } = null!;

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; } = null!;

        [Required]
        [MaxLength(100)]
        public string Email { get; set; } = null!;

        [MaxLength(500)]
        public string? Biography { get; set; }

        [Column("BirthDate", TypeName = "date")]
        public DateTime DateOfBirth { get; set; }

        [NotMapped]
        public string FullName => $"{FirstName} {LastName}";

        public ICollection<Book> Books { get; set; } = new List<Book>();
    }
}
