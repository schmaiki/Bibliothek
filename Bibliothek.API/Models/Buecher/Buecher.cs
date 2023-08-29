namespace Bibliothek.API.Models.Buecher;

public class Buecher
{
    public int Id { get; set; }

    public string Titel { get; set; }
    
    public string Author { get; set; }

    public string ISBN { get; set; }

    public DateOnly Erscheinungsdatum { get; set; }

    public Herausgeber Herausgeber { get; set; }

    public Categorie Categorie { get; set; }

    public Sprache Sprache { get; set; }
}