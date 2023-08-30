namespace Bibliothek.API.DataTypes;

public struct ISBN
{
    private readonly string _value;

    public ISBN(string value)
    {
        if (IsValidISBN(value))
        {
            _value = value;
        }
        else
        {
            throw new ArgumentException("Ungültige ISBN.", nameof(value));
        }
    }

    public override string ToString()
    {
        return _value;
    }

    public static implicit operator string(ISBN isbn)
    {
        return isbn._value;
    }

    public static explicit operator ISBN(string value)
    {
        return new ISBN(value);
    }

    public static bool IsValidISBN(string isbn)
    {
        isbn = RemoveHyphens(isbn);

        if (isbn.Length == 10) return IsValidIsbn10(isbn);
        if (isbn.Length == 13) return IsValidIsbn13(isbn);

        return false;
    }

    private static bool IsValidIsbn10(string isbn)
    {
        if (string.IsNullOrEmpty(isbn)) return false;

        if (isbn.Length != 10 || !long.TryParse(isbn.Substring(0, 9), out _)) return false;

        var sum = 0;
        for (var i = 0; i < 9; i++)
        {
            sum += (10 - i) * (isbn[i] - '0');
        }

        var checkDigit = 11 - (sum % 11);
        switch (checkDigit)
        {
            case 10:
                return isbn[9] == 'X' || isbn[9] == 'x';
            case 11:
                return isbn[9] == '0';
            default:
                return isbn[9] - '0' == checkDigit;
        }
    }

    private static bool IsValidIsbn13(string isbn)
    {
        if (string.IsNullOrEmpty(isbn)) return false;

        if (isbn.Length != 13 || !long.TryParse(isbn, out _)) return false;

        var sum = 0;
        for (var i = 0; i < 12; i++)
        {
            sum += (i % 2 == 0 ? 1 : 3) * (isbn[i] - '0');
        }

        var checkDigit = 10 - (sum % 10);
        if (checkDigit == 10) checkDigit = 0;

        return isbn[12] - '0' == checkDigit;
    }

    private static string RemoveHyphens(string isbn) {
        return isbn.Replace("-", string.Empty);
    }

}