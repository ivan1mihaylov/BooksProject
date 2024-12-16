using Common.Models.Enums;

namespace Common.Models;

public class AudioBook : Book, IComparable<Book>
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

    public int CompareTo(Book? other)
    {
        if (other == null)
        {
            return 1;
        }

        return Name.CompareTo(other.Name);
    }

    public class SortDurationAscending : IComparer<AudioBook>
    {
        public int Compare(AudioBook? x, AudioBook? y)
        {
            if (x == null || y == null)
            {
                return 0;
            }

            return x.Duration.CompareTo(y.Duration);
        }
    }
}
