using System.ComponentModel.DataAnnotations;

namespace Bibliothek.API.Models.Author;

public class Author
{
    [Key]
    public int Id { get; set; }
    
    [MaxLength(100)]
    [Required]
    public string Vorname { get; set; } = String.Empty;
    
    [MaxLength(100)]
    [Required]
    public string Nachname { get; set; } = String.Empty;
}