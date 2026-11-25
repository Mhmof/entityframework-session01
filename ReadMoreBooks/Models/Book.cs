using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReadMoreBooks.Models
{
    [Table("BooksInventory")]
    public class Book
    {
        [Key]
        public int BookCode { get; set; }

        [Required]
        [MaxLength(150)]
        public string Title { get; set; } = null!;

        [Required]
        [StringLength(20)]
        public string ISBN { get; set; } = null!;

        [Column("BookPrice", TypeName = "decimal(10,2)")]
        public decimal Price { get; set; }

        [Column("PagesCount")]
        public int NumberOfPages { get; set; }

        [Column("PublishYear")]
        public int PublishedYear { get; set; }

        public bool IsInStock { get; set; }

        public int AuthorId { get; set; }
        public Author Author { get; set; } = null!;

        public int CategoryId { get; set; }
        public Category Category { get; set; } = null!;
    }
}
