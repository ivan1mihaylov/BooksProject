using BooksProject.Models;

namespace BooksProject.Forms.Controls;

public partial class BookFormControl : UserControl
{
    public BookFormControl()
    {
        InitializeComponent();

        SetGenreComboBoxDataSource();
    }

    private void SetGenreComboBoxDataSource()
    {
        GenreComboBox.DataSource = Enum.GetValues(typeof(Enums.LiteratureGenre));
    }

    public Book GetBook()
    {
        return new Book(
            BookNameTextBox.Text,
            AuthorTextBox.Text,
            (Enums.LiteratureGenre)(GenreComboBox.SelectedItem ?? Enums.LiteratureGenre.AppliedKnowledge),
            LanguageTextBox.Text,
            PublishDateTimePicker.Value);
    }
}
