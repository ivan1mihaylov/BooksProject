using Common.Models;
using Common.Models.Enums;
using NUnit.Framework;
using System.Linq;
using System.Text;

namespace Tests
{
    public class AudioBookTests
    {
        private List<AudioBook> audioBooks;

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

        [Test]
        public void TestAudioBookIsFree()
        {
            var audioBook = audioBooks.First();
            var result = audioBook.IsFree();
            Assert.That(result, Is.True);
        }

        [Test]
        public void TestAudioBookCompareTo()
        {
            var audioBook1 = audioBooks.First();
            var audioBook2 = audioBooks.Last();
            var result = audioBook1.CompareTo(audioBook2);
            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void TestSortDurationAscending()
        {
            var sortedAudioBooks = audioBooks.OrderBy(a => a.Duration).ToList();
            var result = sortedAudioBooks.SequenceEqual(audioBooks.OrderBy(a => a.Duration));
        }

        [Test]
        public void TestAudioBooks()
        {
            var audioBooks = new List<AudioBook>
            {
                new ("To Kill a Mockingbird", "Harper Lee", LiteratureGenre.Fiction, "Английски", new DateTime(1960, 7, 11), "Sissy Spacek", new TimeSpan(8, 56, 0), 0),
                new ("The Iliad", "Homer", LiteratureGenre.Poetry, "Български", new DateTime(762, 1, 1), "Иван Вазов", new TimeSpan(24, 0, 0), 0),
                new ("A Brief History of Time", "Stephen Hawking", LiteratureGenre.Science, "Френски", new DateTime(1988, 4, 1), "Lucy Hawking", new TimeSpan(5, 0, 0), 2.2M)
            };

            // Sort by name using IComparable
            var sortedByName = audioBooks.OrderBy(a => a).ToList();
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
        }
    }

}
