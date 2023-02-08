using System.ComponentModel.DataAnnotations;

namespace DataLayer.Entities;

public class Tag
{
    [Key]
    [Required]
    [MaxLength(40)]
    public string TagId { get; set; }

    public ICollection<Book> Books { get; set; }
}