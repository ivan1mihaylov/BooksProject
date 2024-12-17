using Common.Models;
using Common.Models.Enums;

namespace Tests;

/// <summary>
/// Unit tests for the Book class.
/// </summary>
public class BookTests
{
    /// <summary>
    /// List of books used for testing.
    /// </summary>
    private List<Book> books;

    /// <summary>
    /// Sets up the test data before each test.
    /// </summary>
    [SetUp]
    public void Setup()
    {
        books =
        [
            new Book("To Kill a Mockingbird", "Harper Lee", LiteratureGenre.Fiction, "Английски", new DateTime(1960, 7, 11)),
            new Book("The Iliad", "Homer", LiteratureGenre.Poetry, "Български", new DateTime(762, 1, 1)),
            new Book("A Brief History of Time", "Stephen Hawking", LiteratureGenre.Science, "Френски", new DateTime(1988, 4, 1))
        ];
    }

    /// <summary>
    /// Tests the ToString method of the Book class.
    /// </summary>
    [Test]
    public void TestBookToString()
    {
        var book = books[0].ToString();
        var expectedString = $"Име на книгата: To Kill a Mockingbird, Автор: Harper Lee, Жанр: Fiction, Език: Английски, Дата на публикуване: 11.07.1960 г.";
        Assert.That(book, Is.EqualTo(expectedString));
    }

    /// <summary>
    /// Tests the ToShortString method of the Book class.
    /// </summary>
    [Test]
    public void TestBookToShortString()
    {
        var book = books[1];
        var expectedString = "The Iliad, Homer";
        Assert.That(book.ToShortString(), Is.EqualTo(expectedString));
    }

    /// <summary>
    /// Tests the GetAge method of the Book class.
    /// </summary>
    [Test]
    public void TestBookGetAge()
    {
        var book = books[2];
        var expectedAge = DateTime.Now.Year - book.PublishDate.Year;
        Assert.That(book.GetAge(), Is.EqualTo(expectedAge));
    }

    /// <summary>
    /// Tests if the book is in Bulgarian.
    /// </summary>
    [Test]
    public void TestBookIsInBulgarian()
    {
        var book = books[1];
        Assert.That(book.IsInBulgarian(), Is.True);
    }

    /// <summary>
    /// Tests if the book is not in Bulgarian.
    /// </summary>
    [Test]
    public void TestBookIsNotInBulgarian()
    {
        var book = books[0];
        Assert.That(book.IsInBulgarian(), Is.False);
    }
}
