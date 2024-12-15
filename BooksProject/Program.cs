using BooksProject.Models;
using System.Text.Json;

namespace BooksProject
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(true);
            ApplicationConfiguration.Initialize();

            var mainForm = new MainScreen();

            if (Directory.Exists(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data")))
            {
                string booksJson = File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data\\books.json"));
                string audioBooksJson = File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data\\audioBooks.json"));
                if (!string.IsNullOrEmpty(booksJson))
                {
                    var books = JsonSerializer.Deserialize<List<Book>>(booksJson);
                    mainForm.Books = books ?? [];
                }
                if (!string.IsNullOrEmpty(audioBooksJson))
                {
                    var audioBooks = JsonSerializer.Deserialize<List<AudioBook>>(audioBooksJson);
                    mainForm.AudioBooks = audioBooks ?? [];
                }
            }

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
}