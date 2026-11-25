using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReadMoreBooks.Models
{
    [Table("BookCategories")]
    public class Category
    {
        public int CategoryId { get; set; }

        [Required]
        [MaxLength(80)]
        public string Name { get; set; } = null!;

        [MaxLength(300)]
        public string? Description { get; set; }

        public bool IsActive { get; set; }

        public ICollection<Book> Books { get; set; } = new List<Book>();
    }
}
