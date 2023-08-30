using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Bibliothek.API.DataTypes;
using Bibliothek.API.Models.Ausweis;

namespace Bibliothek.API.Models.Buch;

public class Buch
{
    [Key]
    public int Id { get; set; }

    [MaxLength(100)]
    [Required]
    public string Titel { get; set; } = String.Empty;

    [Required] public ISBN ISBN { get; set; } = new ISBN("978-1-234567-89-0");

    [Required] [DataType(DataType.Date)] public DateOnly Erscheinungsdatum { get; set; } = new DateOnly();

    public Herausgeber Herausgeber { get; set; }

    public Kategorie Kategorie { get; set; }

    public Sprache Sprache { get; set; }

    public Author.Author Author { get; set; }

    [InverseProperty("User")]
    public virtual ICollection<User> Users { get; set; } = new HashSet<User>();
}