using BooksProject.Forms;
using Common;
using Common.Models;
using System.Text.Json;

namespace BooksProject;

/// <summary>
/// The main entry point for the application.
/// </summary>
public static class Program
{
    [STAThread]
    static void Main()
    {
        // Enable visual styles for the application.
        Application.EnableVisualStyles();
        // Set compatible text rendering default.
        Application.SetCompatibleTextRenderingDefault(true);
        // Initialize application configuration.
        ApplicationConfiguration.Initialize();

        // Initialize lists to hold books and audiobooks.
        List<Book> books = [];
        List<AudioBook> audioBooks = [];

        // Check if the data directory exists.
        if (Directory.Exists(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data")))
        {
            // Create books.json file if it does not exist.
            if (!File.Exists(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data\\books.json")))
            {
                using var stream = File.Create(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data\\books.json"));
                stream.Close();
            }

            // Create audioBooks.json file if it does not exist.
            if (!File.Exists(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data\\audioBooks.json")))
            {
                using var stream = File.Create(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data\\audioBooks.json"));
                stream.Close();
            }
        }
        else
        {
            // Create the data directory and the JSON files.
            Directory.CreateDirectory(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data"));

            using var stream = File.Create(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data\\books.json"));
            stream.Close();

            using var secondStream = File.Create(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data\\audioBooks.json"));
            secondStream.Close();
        }

        // Read the content of the JSON files.
        var booksJson = File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data\\books.json"));
        string audioBooksJson = File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data\\audioBooks.json"));

        // Deserialize the JSON content into the lists. If there is no content, use the predefined seed data to initialy populate the lists.
        if (!string.IsNullOrWhiteSpace(booksJson))
        {
            books.AddRange(JsonSerializer.Deserialize<List<Book>>(booksJson) ?? []);
        }
        else
        {
            books.AddRange(SeedData.Books);
        }

        // Deserialize the JSON content into the lists. If there is no content, use the predefined seed data to initialy populate the lists.
        if (!string.IsNullOrWhiteSpace(audioBooksJson))
        {
            audioBooks.AddRange(JsonSerializer.Deserialize<List<AudioBook>>(audioBooksJson) ?? []);
        }
        else
        {
            audioBooks.AddRange(SeedData.AudioBooks);
        }

        // Initialize the main form with the books and audiobooks.
        var mainForm = new MainScreen(books, audioBooks);

        // Handle the FormClosing event to save data.
        mainForm.FormClosing += (sender, e) =>
        {
            // Ensure the data directory exists.
            if (!Directory.Exists(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data")))
            {
                Directory.CreateDirectory(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data"));
            }

            // Serialize the books and audiobooks lists to JSON and save them.
            string booksJson = JsonSerializer.Serialize(mainForm.Books);
            File.WriteAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data\\books.json"), booksJson);

            string audioBooksJson = JsonSerializer.Serialize(mainForm.AudioBooks);
            File.WriteAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data\\audioBooks.json"), audioBooksJson);
        };

        // Run the main form.
        Application.Run(mainForm);
    }
}
