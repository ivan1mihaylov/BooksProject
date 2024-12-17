using Common.Models.Enums;

namespace Common.Models;

/// <summary>
/// Represents an audiobook with additional properties such as narrator, duration, and price.
/// </summary>
public class AudioBook : Book, IComparable<Book>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AudioBook"/> class.
    /// </summary>
    public AudioBook() { }

    /// <summary>
    /// Initializes a new instance of the <see cref="AudioBook"/> class with specified details.
    /// </summary>
    /// <param name="name">The name of the audiobook.</param>
    /// <param name="author">The author of the audiobook.</param>
    /// <param name="genre">The genre of the audiobook.</param>
    /// <param name="language">The language of the audiobook.</param>
    /// <param name="publishDate">The publish date of the audiobook.</param>
    /// <param name="narrator">The narrator of the audiobook.</param>
    /// <param name="duration">The duration of the audiobook.</param>
    /// <param name="price">The price of the audiobook.</param>
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

    /// <summary>
    /// Gets or sets the narrator of the audiobook.
    /// </summary>
    public string Narrator { get; set; } = default!;

    /// <summary>
    /// Gets or sets the duration of the audiobook.
    /// </summary>
    public TimeSpan Duration { get; set; }

    /// <summary>
    /// Gets or sets the price of the audiobook.
    /// </summary>
    public decimal Price { get; set; }

    /// <summary>
    /// Returns a string that represents the current audiobook.
    /// </summary>
    /// <returns>The full information about the audiobook.</returns>
    public override string ToString()
    {
        // Construct the string representation of the audiobook
        return base.ToString() + $", Име на четец: {Narrator}, Продължителност: {Duration.TotalMinutes} минути, Цена: {Price:0.00} лв.";
    }

    /// <summary>
    /// Returns a short string that represents the current audiobook.
    /// </summary>
    /// <returns>The name, author, and duration of the audiobook.</returns>
    public new string ToShortString()
    {
        // Construct the short string representation of the audiobook
        return base.ToShortString() + $", {Duration.TotalMinutes} минути";
    }

    /// <summary>
    /// Determines whether the audiobook is free.
    /// </summary>
    /// <returns><c>true</c> if the audiobook is free; otherwise, <c>false</c>.</returns>
    public bool IsFree()
    {
        // Check if the price is zero
        return Price == 0;
    }

    /// <summary>
    /// Compares the current audiobook with another book based on the name.
    /// </summary>
    /// <param name="other">The book to compare with.</param>
    /// <returns>An integer that indicates the relative order of the books being compared.</returns>
    public int CompareTo(Book? other)
    {
        if (other == null)
        {
            return 1;
        }

        // Compare the names of the books
        return Name.CompareTo(other.Name);
    }

    /// <summary>
    /// Provides a comparer for sorting audiobooks by duration in ascending order.
    /// </summary>
    public class SortDurationAscending : IComparer<AudioBook>
    {
        /// <summary>
        /// Compares two audiobooks based on their duration.
        /// </summary>
        /// <param name="x">The first audiobook to compare.</param>
        /// <param name="y">The second audiobook to compare.</param>
        /// <returns>An integer that indicates the relative order of the audiobooks being compared.</returns>
        public int Compare(AudioBook? x, AudioBook? y)
        {
            if (x == null || y == null)
            {
                return 0;
            }

            // Compare the durations of the audiobooks
            return x.Duration.CompareTo(y.Duration);
        }
    }
}
