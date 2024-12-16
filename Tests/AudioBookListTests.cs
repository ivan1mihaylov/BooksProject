using Common.Models;
using Common.Models.Enums;
using NUnit.Framework;
using System.Linq;
using System.Text;

namespace Tests
{
    public class AudioBooksListTests
    {
        private AudioBooksList audioBooksList;

        [SetUp]
        public void Setup()
        {
            audioBooksList = new AudioBooksList();
            audioBooksList.AddAudioBook(new AudioBook("To Kill a Mockingbird", "Harper Lee", LiteratureGenre.Fiction, "Английски", new DateTime(1960, 7, 11), "Sissy Spacek", new TimeSpan(8, 56, 0), 0));
            audioBooksList.AddAudioBook(new AudioBook("The Iliad", "Homer", LiteratureGenre.Poetry, "Български", new DateTime(762, 1, 1), "Иван Вазов", new TimeSpan(24, 0, 0), 0));
            audioBooksList.AddAudioBook(new AudioBook("A Brief History of Time", "Stephen Hawking", LiteratureGenre.Science, "Френски", new DateTime(1988, 4, 1), "Lucy Hawking", new TimeSpan(5, 0, 0), 2.2M));
        }
        [Test]
        public void TestAudioBooksListFunctionality()
        {
            // Test adding an audiobook
            var newAudioBook = new AudioBook("1984", "George Orwell", LiteratureGenre.Fiction, "Английски", new DateTime(1949, 6, 8), "Simon Prebble", new TimeSpan(11, 22, 0), 1.5M);
            audioBooksList.AddAudioBook(newAudioBook);
            Assert.That(audioBooksList.AudioBooks.Count, Is.EqualTo(4));
            Assert.That(audioBooksList.AudioBooks.Contains(newAudioBook), Is.EqualTo(true));

            // Test ToString
            var result = audioBooksList.ToString();

            var sb = new StringBuilder();
            foreach (var audioBook in audioBooksList.AudioBooks)
            {
                sb.AppendLine(audioBook.ToString());
            }
            var expectedResult = sb.ToString();

            Assert.That(result, Is.EqualTo(expectedResult));

            // Test MaxDuration
            var maxDuration = audioBooksList.MaxDuration;
            Assert.That(maxDuration, Is.EqualTo(new TimeSpan(24, 0, 0)));

            // Test GetComedy
            var comedyAudioBooks = audioBooksList.GetComedy;
            Assert.That(comedyAudioBooks.Count, Is.EqualTo(0));

            // Test removing an audiobook by object
            audioBooksList.RemoveAudioBook(newAudioBook);
            Assert.That(audioBooksList.AudioBooks.Count, Is.EqualTo(3));
            Assert.That(audioBooksList.AudioBooks.Contains(newAudioBook), Is.EqualTo(false));

            // Test removing an audiobook by index
            audioBooksList.RemoveAudioBook(0);
            Assert.That(audioBooksList.AudioBooks.Count, Is.EqualTo(2));

            // Test sorting by duration ascending
            audioBooksList.SortAudioBooksByDurationAscending();
            Assert.That(audioBooksList.AudioBooks[0].Name, Is.EqualTo("A Brief History of Time"));
            Assert.That(audioBooksList.AudioBooks[1].Name, Is.EqualTo("The Iliad"));

            // Test sorting by price descending
            audioBooksList.SortAudioBooksByPriceDescending();
            Assert.That(audioBooksList.AudioBooks[0].Name, Is.EqualTo("A Brief History of Time"));
            Assert.That(audioBooksList.AudioBooks[1].Name, Is.EqualTo("The Iliad"));

            // Test clearing the list
            audioBooksList.ClearAudioBooks();
            Assert.That(audioBooksList.AudioBooks.Count, Is.EqualTo(0));

        }


    }

}
