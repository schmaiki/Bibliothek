using System.ComponentModel.DataAnnotations;

namespace Bibliothek.API.Models.Buch;

public class Buch
{
    [Key]
    public int Id { get; set; }

    [MaxLength(100)]
    [Required]
    public string Titel { get; set; }

    [MaxLength(100)]
    [Required]
    public string ISBN { get; set; }

    [Required]
    [DataType(DataType.Date)]
    public DateOnly Erscheinungsdatum { get; set; }

    public Herausgeber Herausgeber { get; set; }

    public Kategorie Kategorie { get; set; }

    public Sprache Sprache { get; set; }

    public Author Author { get; set; }
}