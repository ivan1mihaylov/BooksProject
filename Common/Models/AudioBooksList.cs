using Common.Models.Enums;
using System.Text;

namespace Common.Models;

/// <summary>
/// Represents a list of audiobooks with various operations and events.
/// </summary>
public class AudioBooksList
{
    /// <summary>
    /// Gets or sets the list of audiobooks.
    /// </summary>
    public List<AudioBook> AudioBooks { get; set; } = [];

    /// <summary>
    /// Event triggered when the audiobook list changes.
    /// </summary>
    public event EventHandler<AudioBooksListHandlerEventArgs>? AudioBooksListChanged;

    /// <summary>
    /// Gets or sets the website associated with the audiobooks.
    /// </summary>
    public string? Website { get; set; }

    /// <summary>
    /// Gets the maximum duration of the audiobooks in the list.
    /// </summary>
    public TimeSpan MaxDuration => AudioBooks.Max(a => a.Duration);

    /// <summary>
    /// Gets the list of comedy audiobooks.
    /// </summary>
    public List<AudioBook> GetComedy => AudioBooks.Where(a => a.Genre == LiteratureGenre.Comedy).ToList();

    /// <summary>
    /// Initializes a new instance of the <see cref="AudioBooksList"/> class.
    /// </summary>
    public AudioBooksList() { }

    /// <summary>
    /// Initializes a new instance of the <see cref="AudioBooksList"/> class with specified audiobooks and website.
    /// </summary>
    /// <param name="audioBooks">The list of audiobooks.</param>
    /// <param name="website">The website associated with the audiobooks.</param>
    public AudioBooksList(List<AudioBook> audioBooks, string website)
    {
        AudioBooks = audioBooks;
        Website = website;
    }

    /// <summary>
    /// Adds a list of audiobooks to the existing list.
    /// </summary>
    /// <param name="audioBooks">The list of audiobooks to add.</param>
    public void AddAudioBookList(List<AudioBook> audioBooks)
    {
        AudioBooks.AddRange(audioBooks);
        OnAudioBooksListChanged(new AudioBooksListHandlerEventArgs("AudioBooks added", null));
    }

    /// <summary>
    /// Adds a single audiobook to the list.
    /// </summary>
    /// <param name="audioBook">The audiobook to add.</param>
    public void AddAudioBook(AudioBook audioBook)
    {
        AudioBooks.Add(audioBook);
        OnAudioBooksListChanged(new AudioBooksListHandlerEventArgs("AudioBook added", audioBook));
    }

    /// <summary>
    /// Removes a specific audiobook from the list.
    /// </summary>
    /// <param name="audioBook">The audiobook to remove.</param>
    public void RemoveAudioBook(AudioBook audioBook)
    {
        AudioBooks.Remove(audioBook);
        OnAudioBooksListChanged(new AudioBooksListHandlerEventArgs("AudioBook removed", audioBook));
    }

    /// <summary>
    /// Removes an audiobook from the list by its index.
    /// </summary>
    /// <param name="index">The index of the audiobook to remove.</param>
    public void RemoveAudioBook(int index)
    {
        var audioBook = AudioBooks[index];
        AudioBooks.RemoveAt(index);
        OnAudioBooksListChanged(new AudioBooksListHandlerEventArgs("AudioBook removed by index", audioBook));
    }

    /// <summary>
    /// Clears all audiobooks from the list.
    /// </summary>
    public void ClearAudioBooks()
    {
        AudioBooks.Clear();
        OnAudioBooksListChanged(new AudioBooksListHandlerEventArgs("All AudioBooks cleared", null));
    }

    /// <summary>
    /// Sorts the audiobooks by duration in ascending order.
    /// </summary>
    public void SortAudioBooksByDurationAscending()
    {
        AudioBooks.Sort(new AudioBook.SortDurationAscending());
    }

    /// <summary>
    /// Sorts the audiobooks by duration in descending order.
    /// </summary>
    public void SortAudioBooksByDurationDescending()
    {
        AudioBooks.Sort((x, y) => y.Duration.CompareTo(x.Duration));
    }

    /// <summary>
    /// Sorts the audiobooks by price in ascending order.
    /// </summary>
    public void SortAudioBooksByPriceAscending()
    {
        AudioBooks.Sort((x, y) => x.Price.CompareTo(y.Price));
    }

    /// <summary>
    /// Sorts the audiobooks by price in descending order.
    /// </summary>
    public void SortAudioBooksByPriceDescending()
    {
        AudioBooks.Sort((x, y) => y.Price.CompareTo(x.Price));
    }

    /// <summary>
    /// Sorts the audiobooks by name in ascending order.
    /// </summary>
    public void SortAudioBooksByNameAscending()
    {
        AudioBooks.Sort((x, y) => x.Name.CompareTo(y.Name));
    }

    /// <summary>
    /// Sorts the audiobooks by name in descending order.
    /// </summary>
    public void SortAudioBooksByNameDescending()
    {
        AudioBooks.Sort((x, y) => y.Name.CompareTo(x.Name));
    }

    /// <summary>
    /// Returns a string representation of the audiobook list.
    /// </summary>
    /// <returns>A string representing the audiobook list.</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        foreach (var audioBook in AudioBooks)
        {
            sb.AppendLine(audioBook.ToString());
        }
        return sb.ToString();
    }

    /// <summary>
    /// Displays the audiobook list to the console.
    /// </summary>
    public void Show()
    {
        Console.WriteLine(this.ToString());
    }

    /// <summary>
    /// Raises the <see cref="AudioBooksListChanged"/> event.
    /// </summary>
    /// <param name="e">The event arguments.</param>
    protected virtual void OnAudioBooksListChanged(AudioBooksListHandlerEventArgs e)
    {
        AudioBooksListChanged?.Invoke(this, e);
    }
}

/// <summary>
/// Provides data for the <see cref="AudioBooksList.AudioBooksListChanged"/> event.
/// </summary>
public class AudioBooksListHandlerEventArgs : EventArgs
{
    /// <summary>
    /// Gets the message associated with the event.
    /// </summary>
    public string? Message { get; }

    /// <summary>
    /// Gets the audiobook associated with the event.
    /// </summary>
    public AudioBook? AudioBook { get; }

    /// <summary>
    /// Initializes a new instance of the <see cref="AudioBooksListHandlerEventArgs"/> class.
    /// </summary>
    public AudioBooksListHandlerEventArgs() { }

    /// <summary>
    /// Initializes a new instance of the <see cref="AudioBooksListHandlerEventArgs"/> class with specified message and audiobook.
    /// </summary>
    /// <param name="message">The message associated with the event.</param>
    /// <param name="audioBook">The audiobook associated with the event.</param>
    public AudioBooksListHandlerEventArgs(string? message, AudioBook? audioBook)
    {
        Message = message;
        AudioBook = audioBook;
    }
}
