using Common.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Models
{

    public class AudioBooksList
    {
        public List<AudioBook> AudioBooks { get; set; } = [];

        public event EventHandler<AudioBooksListHandlerEventArgs>? AudioBooksListChanged;

        public AudioBooksList() { }

        public AudioBooksList(List<AudioBook> audioBooks)
        {
            AudioBooks = audioBooks;
        }

        public void AddAudioBook(AudioBook audioBook)
        {
            AudioBooks.Add(audioBook);
            OnAudioBooksListChanged(new AudioBooksListHandlerEventArgs("AudioBook added", audioBook));
        }

        public void RemoveAudioBook(AudioBook audioBook)
        {
            AudioBooks.Remove(audioBook);
            OnAudioBooksListChanged(new AudioBooksListHandlerEventArgs("AudioBook removed", audioBook));
        }

        public void RemoveAudioBook(int index)
        {
            var audioBook = AudioBooks[index];
            AudioBooks.RemoveAt(index);
            OnAudioBooksListChanged(new AudioBooksListHandlerEventArgs("AudioBook removed by index", audioBook));
        }

        public void ClearAudioBooks()
        {
            AudioBooks.Clear();
            OnAudioBooksListChanged(new AudioBooksListHandlerEventArgs("All AudioBooks cleared", null));
        }

        public void SortAudioBooksByDurationAscending()
        {
            AudioBooks.Sort(new AudioBook.SortDurationAscending());
        }

        public void SortAudioBooksByDurationDescending()
        {
            AudioBooks.Sort((x, y) => y.Duration.CompareTo(x.Duration));
        }

        public void SortAudioBooksByPriceAscending()
        {
            AudioBooks.Sort((x, y) => x.Price.CompareTo(y.Price));
        }

        public void SortAudioBooksByPriceDescending()
        {
            AudioBooks.Sort((x, y) => y.Price.CompareTo(x.Price));
        }

        public void SortAudioBooksByNameAscending()
        {
            AudioBooks.Sort((x, y) => x.Name.CompareTo(y.Name));
        }

        public void SortAudioBooksByNameDescending()
        {
            AudioBooks.Sort((x, y) => y.Name.CompareTo(x.Name));
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            foreach (var audioBook in AudioBooks)
            {
                sb.AppendLine(audioBook.ToString());
            }
            return sb.ToString();
        }

        public void Show()
        {
            Console.WriteLine(this.ToString());
        }

        public TimeSpan MaxDuration => AudioBooks.Max(a => a.Duration);

        public List<AudioBook> GetComedy => AudioBooks.Where(a => a.Genre == LiteratureGenre.Comedy).ToList();

        protected virtual void OnAudioBooksListChanged(AudioBooksListHandlerEventArgs e)
        {
            AudioBooksListChanged?.Invoke(this, e);
        }
    }

    public class AudioBooksListHandlerEventArgs : EventArgs
    {
        public string? Message { get; }
        public AudioBook? AudioBook { get; }

        public AudioBooksListHandlerEventArgs() { }

        public AudioBooksListHandlerEventArgs(string? message, AudioBook? audioBook)
        {
            Message = message;
            AudioBook = audioBook;
        }
    }
}
