using BooksProject.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksProject.Models
{
    public class Book
    {
        public Book() { }

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

        public string Name { get; set; } = default!;
        public string Author { get; set; } = default!;
        public LiteratureGenre Genre { get; set; }
        public string Language { get; set; } = default!;
        public DateTime PublishDate { get; set; }

        public override string ToString()
        {
            return $"Име на книгата: {Name}, Автор: {Author}, Жанр: {Genre}, Език: {Language}, Дата на публикуване: {PublishDate:dd.MM.yyyy г.}";
        }

        public string ToShortString()
        {
            return $"{Name}, {Author}";
        }

        public int GetAge()
        {
            return DateTime.Now.Year - PublishDate.Year;
        }

        public bool IsInBulgarian()
        {
            return Language == "Български";
        }
    }
}
