using Common.Models;
using Common.Models.Enums;

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
        GenreComboBox.DataSource = Enum.GetValues<LiteratureGenre>();
    }


    public AudioBook GetBook()
    {
        return new AudioBook(
            NameTextBox.Text,
            AuthorTextBox.Text,
            (LiteratureGenre)(GenreComboBox.SelectedItem ?? LiteratureGenre.AppliedKnowledge),
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
