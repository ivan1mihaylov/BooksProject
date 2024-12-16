using BooksProject.Models;

namespace BooksProject.Forms.Controls;

public partial class AudioBookFormControl : UserControl
{
    public AudioBookFormControl()
    {
        InitializeComponent();

        SetGenreComboBoxDataSource();
    }

    private void SetGenreComboBoxDataSource()
    {
        GenreComboBox.DataSource = Enum.GetValues(typeof(Enums.LiteratureGenre));
    }


    public AudioBook GetBook()
    {
        return new AudioBook(
            NameTextBox.Text,
            AuthorTextBox.Text,
            (Enums.LiteratureGenre)(GenreComboBox.SelectedItem ?? Enums.LiteratureGenre.AppliedKnowledge),
            LanguageTextBox.Text,
            PublishDateTimePicker.Value,
            NarratorTextBox.Text,
            DurationDateTimePicker.Value.TimeOfDay,
            decimal.Parse(PriceTextBox.Text));
    }

    private void PriceTextBox_KeyDown(object sender, KeyEventArgs e)
    {
        e.SuppressKeyPress = !char.IsDigit((char)e.KeyCode) && e.KeyCode != Keys.Back && e.KeyCode != Keys.Oemcomma;
    }
}
