using Common.Models;
using Common.Models.Enums;

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
        GenreComboBox.DataSource = Enum.GetValues(typeof(LiteratureGenre));
    }

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
