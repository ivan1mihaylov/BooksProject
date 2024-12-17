using Common.Models;
using Common.Models.Enums;

namespace BooksProject.Forms.Controls;

/// <summary>
/// Represents a user control for entering book details.
/// </summary>
public partial class BookFormControl : UserControl
{
    public BookFormControl()
    {
        InitializeComponent();
        SetGenreComboBoxDataSource();
    }

    /// <summary>
    /// Sets the data source of the GenreComboBox to the values of the LiteratureGenre enum.
    /// </summary>
    private void SetGenreComboBoxDataSource()
    {
        GenreComboBox.DataSource = Enum.GetValues<LiteratureGenre>();
    }

    /// <summary>
    /// Creates a new Book object with the data entered in the form.
    /// </summary>
    /// <returns>A new Book object.</returns>
    public Book GetBook()
    {
        return new Book(
            BookNameTextBox.Text,
            AuthorTextBox.Text,
            (LiteratureGenre)(GenreComboBox.SelectedItem ?? LiteratureGenre.AppliedKnowledge),
            LanguageTextBox.Text,
            PublishDateTimePicker.Value);
    }
}
