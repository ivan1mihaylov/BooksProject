using BooksProject.Forms;
using Common;
using Common.Models;
using System.Text.Json;

namespace BooksProject;

public static class Program
{
    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(true);
        ApplicationConfiguration.Initialize();

        List<Book> books = [];
        List<AudioBook> audioBooks = [];

        if (Directory.Exists(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data")))
        {
            string booksJson = File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data\\books.json"));
            string audioBooksJson = File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data\\audioBooks.json"));
            if (!string.IsNullOrEmpty(booksJson))
            {
                books.AddRange(JsonSerializer.Deserialize<List<Book>>(booksJson) ?? []);
            }
            else
            {
                books.AddRange(SeedData.Books);
            }

            if (!string.IsNullOrEmpty(audioBooksJson))
            {
                audioBooks.AddRange(JsonSerializer.Deserialize<List<AudioBook>>(audioBooksJson) ?? []);
            }
            else
            {
                audioBooks.AddRange(SeedData.AudioBooks);
            }
        }
        else
        {
            Directory.CreateDirectory(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data"));
            books.AddRange(SeedData.Books);
            audioBooks.AddRange(SeedData.AudioBooks);
        }

        var mainForm = new MainScreen(books, audioBooks);

        mainForm.FormClosing += (sender, e) =>
        {
            if (!Directory.Exists(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data")))
            {
                Directory.CreateDirectory(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data"));
            }

            string booksJson = JsonSerializer.Serialize(mainForm.Books);
            File.WriteAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data\\books.json"), booksJson);

            string audioBooksJson = JsonSerializer.Serialize(mainForm.AudioBooks);
            File.WriteAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data\\audioBooks.json"), audioBooksJson);
        };

        Application.Run(mainForm);
    }
}