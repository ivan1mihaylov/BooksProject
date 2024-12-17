using Common.Models;
using Common.Models.Enums;

namespace BooksProject.Forms.Controls;

/// <summary>
/// Represents a user control for entering audio book details.
/// </summary>
public partial class AudioBookFormControl : UserControl
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AudioBookFormControl"/> class.
    /// </summary>
    public AudioBookFormControl()
    {
        InitializeComponent();
        SetGenreComboBoxDataSource();
    }

    /// <summary>
    /// Sets the data source for the GenreComboBox to the values of the LiteratureGenre enum.
    /// </summary>
    private void SetGenreComboBoxDataSource()
    {
        GenreComboBox.DataSource = Enum.GetValues<LiteratureGenre>();
    }

    /// <summary>
    /// Creates and returns an AudioBook object with the data from the form controls.
    /// </summary>
    /// <returns>An <see cref="AudioBook"/> object.</returns>
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

    /// <summary>
    /// Handles the KeyDown event of the PriceTextBox control to allow only digits, backspace, and comma.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">A <see cref="KeyEventArgs"/> that contains the event data.</param>
    private void PriceTextBox_KeyDown(object sender, KeyEventArgs e)
    {
        e.SuppressKeyPress = !char.IsDigit((char)e.KeyCode) && e.KeyCode != Keys.Back && e.KeyCode != Keys.Oemcomma;
    }
}
