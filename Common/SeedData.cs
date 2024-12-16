using Common.Models;
using Common.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public static class SeedData
    {
        public static List<Book> Books { get; set; } =
        [
            new Book("To Kill a Mockingbird", "Harper Lee", LiteratureGenre.Fiction, "Английски", new DateTime(1960, 7, 11)),
            new Book("The Iliad", "Homer", LiteratureGenre.Poetry, "Български", new DateTime(762, 1, 1)),
            new Book("A Brief History of Time", "Stephen Hawking", LiteratureGenre.Science, "Френски", new DateTime(1988, 4, 1)),
            new Book("The Great Gatsby", "F. Scott Fitzgerald", LiteratureGenre.Fiction, "Английски", new DateTime(1925, 4, 10)),
            new Book("The Catcher in the Rye", "J.D. Salinger", LiteratureGenre.Fiction, "Английски", new DateTime(1951, 7, 16)),
            new Book("The Odyssey", "Homer", LiteratureGenre.Poetry, "Гръцки", new DateTime(1614, 1, 1)),
            new Book("The Divine Comedy", "Dante Alighieri", LiteratureGenre.Poetry, "Италиански", new DateTime(1320, 1, 1)),
            new Book("The Brothers Karamazov", "Fyodor Dostoevsky", LiteratureGenre.Fiction, "Руски", new DateTime(1880, 1, 1)),
            new Book("The Picture of Dorian Gray", "Oscar Wilde", LiteratureGenre.Fiction, "Английски", new DateTime(1890, 1, 1)),
            new Book("The Stranger", "Albert Camus", LiteratureGenre.Fiction, "Френски", new DateTime(1942, 1, 1)),
            new Book("The Plague", "Albert Camus", LiteratureGenre.Fiction, "Френски", new DateTime(1947, 1, 1)),
            new Book("The Metamorphosis", "Franz Kafka", LiteratureGenre.Fiction, "Немски", new DateTime(1915, 1, 1)),
            new Book("The Trial", "Franz Kafka", LiteratureGenre.Fiction, "Немски", new DateTime(1925, 1, 1)),
            new Book("The Castle", "Franz Kafka", LiteratureGenre.Fiction, "Немски", new DateTime(1926, 1, 1))
        ];

        public static List<AudioBook> AudioBooks { get; set; } =
        [
            new AudioBook("To Kill a Mockingbird", "Harper Lee", LiteratureGenre.Fiction, "Английски", new DateTime(1960, 7, 11), "Sissy Spacek", new TimeSpan(8, 56, 0), 0),
            new AudioBook("The Iliad", "Homer", LiteratureGenre.Poetry, "Български", new DateTime(762, 1, 1), "Иван Вазов", new TimeSpan(24, 0, 0), 0),
            new AudioBook("A Brief History of Time", "Stephen Hawking", LiteratureGenre.Science, "Френски", new DateTime(1988, 4, 1), "Lucy Hawking", new TimeSpan(5, 0, 0), 2.2M),
            new AudioBook("The Great Gatsby", "F. Scott Fitzgerald", LiteratureGenre.Fiction, "Английски", new DateTime(1925, 4, 10), "Jake Gyllenhaal", new TimeSpan(6, 0, 0), 0),
            new AudioBook("The Catcher in the Rye", "J.D. Salinger", LiteratureGenre.Fiction, "Английски", new DateTime(1951, 7, 16), "Jake Gyllenhaal", new TimeSpan(7, 0, 0), 0),
            new AudioBook("The Odyssey", "Homer", LiteratureGenre.Poetry, "Гръцки", new DateTime(1614, 1, 1), "Иван Вазов", new TimeSpan(24, 0, 0), 0),
            new AudioBook("The Divine Comedy", "Dante Alighieri", LiteratureGenre.Poetry, "Италиански", new DateTime(1320, 1, 1), "Иван Вазов", new TimeSpan(24, 0, 0), 0),
            new AudioBook("The Brothers Karamazov", "Fyodor Dostoevsky", LiteratureGenre.Fiction, "Руски", new DateTime(1880, 1, 1), "Иван Вазов", new TimeSpan(24, 0, 0), 0),
            new AudioBook("The Picture of Dorian Gray", "Oscar Wilde", LiteratureGenre.Fiction, "Английски", new DateTime(1890, 1, 1), "Иван Вазов", new TimeSpan(24, 0, 0), 0),
            new AudioBook("The Stranger", "Albert Camus", LiteratureGenre.Fiction, "Френски", new DateTime(1942, 1, 1), "Иван Вазов", new TimeSpan(24, 0, 0), 0),
            new AudioBook("The Plague", "Albert Camus", LiteratureGenre.Fiction, "Френски", new DateTime(1947, 1, 1), "Иван Вазов", new TimeSpan(24, 0, 0), 0),
            new AudioBook("The Metamorphosis", "Franz Kafka", LiteratureGenre.Fiction, "Немски", new DateTime(1915, 1, 1), "Иван Вазов", new TimeSpan(24, 0, 0), 0),
            new AudioBook("The Trial", "Franz Kafka", LiteratureGenre.Fiction, "Немски", new DateTime(1925, 1, 1), "Иван Вазов", new TimeSpan(24, 0, 0), 0),
            new AudioBook("The Castle", "Franz Kafka", LiteratureGenre.Fiction, "Немски", new DateTime(1926, 1, 1), "Иван Вазов", new TimeSpan(24, 0, 0), 0)
        ];
    }
}
