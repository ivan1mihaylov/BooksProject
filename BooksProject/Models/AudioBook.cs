using BooksProject.Enums;

namespace BooksProject.Models;

public class AudioBook : Book
{
    public AudioBook() { }
    public AudioBook(
            string name,
            string author,
            LiteratureGenre genre,
            string language,
            DateTime publishDate,
            string narrator,
            TimeSpan duration,
            decimal price = 0)
        : base(name, author, genre, language, publishDate)
    {
        Narrator = narrator;
        Duration = duration;
        Price = price;
    }

    public string Narrator { get; set; } = default!;
    public TimeSpan Duration { get; set; }
    public decimal Price { get; set; }

    public override string ToString()
    {
        return base.ToString() + $", Име на четец: {Narrator}, Продължителност: {Duration.TotalMinutes} минути, Цена: {Price:0.00} лв.";
    }

    public new string ToShortString()
    {
        return base.ToShortString() + $", {Duration.TotalMinutes} минути";
    }

    public bool IsFree()
    {
        return Price == 0;
    }
}
