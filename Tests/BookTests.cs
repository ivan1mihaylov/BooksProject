using Common.Models;
using Common.Models.Enums;
using NUnit.Framework;

namespace Tests
{
    public class BookTests
    {
        private List<Book> books;

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

        [Test]
        public void TestBookToString()
        {
            var book = books[0].ToString();
            var expectedString = $"Име на книгата: To Kill a Mockingbird, Автор: Harper Lee, Жанр: Fiction, Език: Английски, Дата на публикуване: 11.07.1960 г.";
            Assert.That(book, Is.EqualTo(expectedString));
        }

        [Test]
        public void TestBookToShortString()
        {
            var book = books[1];
            var expectedString = "The Iliad, Homer";
            Assert.That(book.ToShortString(), Is.EqualTo(expectedString));
        }

        [Test]
        public void TestBookGetAge()
        {
            var book = books[2];
            var expectedAge = DateTime.Now.Year - book.PublishDate.Year;
            Assert.That(book.GetAge(), Is.EqualTo(expectedAge));
        }

        [Test]
        public void TestBookIsInBulgarian()
        {
            var book = books[1];
            Assert.That(book.IsInBulgarian(), Is.True);
        }

        [Test]
        public void TestBookIsNotInBulgarian()
        {
            var book = books[0];
            Assert.That(book.IsInBulgarian(), Is.False);
        }
    }

}
