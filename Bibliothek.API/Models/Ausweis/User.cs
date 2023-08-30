using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bibliothek.API.Models.Ausweis;

public class User
{
    [Key]
    public int Id { get; set; }

    [MaxLength(100)]
    [Required]
    public string Vorname { get; set; }

    [MaxLength(100)]
    [Required]
    public string Nachname { get; set; }

    [MaxLength(100)]
    public string Geburtsname { get; set; }

    [DataType(DataType.Date)]
    public DateOnly Geburtsdatum { get; set; }

    [MaxLength(20)]
    public string Geschlecht { get; set; }

    [MaxLength(150)]
    public string Strasse { get; set; }

    [MaxLength(5)]
    public string Hausnummer { get; set; }

    [DataType(DataType.PostalCode)]
    public int PLZ { get; set; }

    [MaxLength(100)]
    public string Ort { get; set; }

    [DataType(DataType.EmailAddress)]
    [EmailAddress]
    [Required]
    public string EMail { get; set; }

    [DataType(DataType.PhoneNumber)]
    [Phone]
    [Required]
    public string Telefonnummer { get; set; }

    [DataType(DataType.Date)]
    public DateOnly Aufenthaltsgenehmigung { get; set; }

    [MaxLength(100)]
    public string Nationalitaet { get; set; }

    [InverseProperty("User")]
    public virtual ICollection<Buch.Buch> Buch { get; set; } = new HashSet<Buch.Buch>();
}
