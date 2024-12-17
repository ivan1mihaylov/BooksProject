using Common.Models.Enums;

namespace Common.Models;

/// <summary>
/// Represents a book with various properties such as name, author, genre, language, and publish date.
/// </summary>
public class Book
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Book"/> class.
    /// </summary>
    public Book() { }

    /// <summary>
    /// Initializes a new instance of the <see cref="Book"/> class with specified details.
    /// </summary>
    /// <param name="name">The name of the book.</param>
    /// <param name="author">The author of the book.</param>
    /// <param name="genre">The genre of the book.</param>
    /// <param name="language">The language of the book.</param>
    /// <param name="publishDate">The publish date of the book.</param>
    public Book(
        string name,
        string author,
        LiteratureGenre genre,
        string language,
        DateTime publishDate)
    {
        Name = name;
        Author = author;
        Genre = genre;
        Language = language;
        PublishDate = publishDate;
    }

    /// <summary>
    /// Gets or sets the name of the book.
    /// </summary>
    public string Name { get; set; } = default!;

    /// <summary>
    /// Gets or sets the author of the book.
    /// </summary>
    public string Author { get; set; } = default!;

    /// <summary>
    /// Gets or sets the genre of the book.
    /// </summary>
    public LiteratureGenre Genre { get; set; }

    /// <summary>
    /// Gets or sets the language of the book.
    /// </summary>
    public string Language { get; set; } = default!;

    /// <summary>
    /// Gets or sets the publish date of the book.
    /// </summary>
    public DateTime PublishDate { get; set; }

    /// <summary>
    /// Returns a string that represents the current book.
    /// </summary>
    /// <returns>The full information about the book</returns>
    public override string ToString()
    {
        return $"Име на книгата: {Name}, Автор: {Author}, Жанр: {Genre}, Език: {Language}, Дата на публикуване: {PublishDate:dd.MM.yyyy г.}";
    }

    /// <summary>
    /// Returns a short string that represents the current book.
    /// </summary>
    /// <returns>The name and the author of the book.</returns>
    public string ToShortString()
    {
        return $"{Name}, {Author}";
    }

    /// <summary>
    /// Gets the age of the book in years.
    /// </summary>
    /// <returns>The age of the book in years.</returns>
    public int GetAge()
    {
        return DateTime.Now.Year - PublishDate.Year;
    }

    /// <summary>
    /// Determines whether the book is in Bulgarian language.
    /// </summary>
    /// <returns><c>true</c> if the book is in Bulgarian; otherwise, <c>false</c>.</returns>
    public bool IsInBulgarian()
    {
        return Language == "Български";
    }
}
