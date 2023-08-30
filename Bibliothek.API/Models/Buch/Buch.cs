namespace Bibliothek.API.Models.Buch;

public class Buch
{
    public int Id { get; set; }

    public string Titel { get; set; }
    
    public string ISBN { get; set; }

    public DateOnly Erscheinungsdatum { get; set; }

    public Herausgeber Herausgeber { get; set; }

    public Kategorie Kategorie { get; set; }

    public Sprache Sprache { get; set; }

    public Author Author { get; set; }
}