using Common.Models;
using Common.Models.Enums;

namespace Tests;

/// <summary>
/// Contains unit tests for the AudioBook class.
/// </summary>
public class AudioBookTests
{
    private List<AudioBook> audioBooks;

    /// <summary>
    /// Sets up the test data before each test.
    /// </summary>
    [SetUp]
    public void Setup()
    {
        audioBooks =
        [
            new AudioBook("To Kill a Mockingbird", "Harper Lee", LiteratureGenre.Fiction, "Английски", new DateTime(1960, 7, 11), "Sissy Spacek", new TimeSpan(8, 56, 0), 0),
            new AudioBook("The Iliad", "Homer", LiteratureGenre.Poetry, "Български", new DateTime(762, 1, 1), "Иван Вазов", new TimeSpan(24, 0, 0), 0),
            new AudioBook("A Brief History of Time", "Stephen Hawking", LiteratureGenre.Science, "Френски", new DateTime(1988, 4, 1), "Lucy Hawking", new TimeSpan(5, 0, 0), 2.2M)
        ];
    }

    /// <summary>
    /// Tests the ToString method of the AudioBook class.
    /// </summary>
    [Test]
    public void TestAudioBookToString()
    {
        var audioBook = audioBooks.First();
        var result = audioBook.ToString();
        Assert.That(result, Is.Not.Null);
        Assert.That(result, Is.Not.Empty);

        var expectedResult = $"Име на книгата: {audioBook.Name}, Автор: {audioBook.Author}, Жанр: {audioBook.Genre}, Език: {audioBook.Language}, Дата на публикуване: {audioBook.PublishDate:dd.MM.yyyy} г., Име на четец: {audioBook.Narrator}, Продължителност: {audioBook.Duration.TotalMinutes} минути, Цена: {audioBook.Price:0.00} лв.";
        Assert.That(result, Is.EqualTo(expectedResult));
    }

    /// <summary>
    /// Tests the ToShortString method of the AudioBook class.
    /// </summary>
    [Test]
    public void TestAudioBookToShortString()
    {
        var audioBook = audioBooks.First();
        var result = audioBook.ToShortString();
        Assert.That(result, Is.Not.Null);
        Assert.That(result, Is.Not.Empty);

        var expectedResult = $"{audioBook.Name}, {audioBook.Author}, {audioBook.Duration.TotalMinutes} минути";
        Assert.That(result, Is.EqualTo(expectedResult));
    }

    /// <summary>
    /// Tests the IsFree method of the AudioBook class.
    /// </summary>
    [Test]
    public void TestAudioBookIsFree()
    {
        var audioBook = audioBooks.First();
        var result = audioBook.IsFree();
        Assert.That(result, Is.True);
    }

    /// <summary>
    /// Tests the CompareTo method of the AudioBook class.
    /// </summary>
    [Test]
    public void TestAudioBookCompareTo()
    {
        var audioBook1 = audioBooks.First();
        var audioBook2 = audioBooks.Last();

        var result = audioBook1.CompareTo(audioBook2);
        Assert.That(result, Is.EqualTo(1));
    }

    /// <summary>
    /// Tests sorting AudioBooks by duration in ascending order.
    /// </summary>
    [Test]
    public void TestSortDurationAscending()
    {
        var sortedAudioBooks = audioBooks.OrderBy(a => a.Duration).ToList();
        var result = sortedAudioBooks.SequenceEqual(audioBooks.OrderBy(a => a.Duration));
    }

    /// <summary>
    /// Tests various sorting and filtering operations on a list of AudioBooks.
    /// </summary>
    [Test]
    public void TestAudioBooks()
    {
        var audioBooks = new List<AudioBook>
            {
                new ("To Kill a Mockingbird", "Harper Lee", LiteratureGenre.Fiction, "Английски", new DateTime(1960, 7, 11), "Sissy Spacek", new TimeSpan(8, 56, 0), 0),
                new ("The Iliad", "Homer", LiteratureGenre.Poetry, "Български", new DateTime(762, 1, 1), "Иван Вазов", new TimeSpan(24, 0, 0), 0),
                new ("A Brief History of Time", "Stephen Hawking", LiteratureGenre.Science, "Френски", new DateTime(1988, 4, 1), "Lucy Hawking", new TimeSpan(0, 15, 0), 2.2M)
            };

        // Sort by name using IComparable
        var sortedByName = audioBooks.Order().ToList();
        Assert.That(sortedByName, Is.Ordered.By("Name"));

        // Sort by duration using SortDurationAscending
        var sortedByDuration = audioBooks.OrderBy(a => a, new AudioBook.SortDurationAscending()).ToList();
        Assert.That(sortedByDuration, Is.Ordered.By("Duration"));

        // Sort by publish date using lambda function
        var sortedByPublishDate = audioBooks.OrderBy(a => a.PublishDate).ToList();
        Assert.That(sortedByPublishDate, Is.Ordered.By("PublishDate"));

        // Sort by price in descending order using LINQ
        var sortedByPriceDescending = audioBooks.OrderByDescending(a => a.Price).ToList();
        Assert.That(sortedByPriceDescending, Is.Ordered.By("Price").Descending);

        // Filter by free audiobooks and duration under 1 hour
        var freeAudioBooks = audioBooks.Where(a => a.IsFree()).ToList();
        Assert.That(freeAudioBooks, Has.Count.EqualTo(2));

        // Filter by duration under 1 hour
        var durationUnder1Hour = audioBooks.Where(a => a.Duration < TimeSpan.FromHours(1)).ToList();
        Assert.That(durationUnder1Hour, Has.Count.EqualTo(1));
    }
}
