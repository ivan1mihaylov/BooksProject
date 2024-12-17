using Common.Models;
using MaterialSkin.Controls;

namespace BooksProject.Forms.Controls;

/// <summary>
/// Represents a user control for adding a book or an audiobook.
/// </summary>
public partial class AddBookControl : UserControl
{
    /// <summary>
    /// Represents the form control for entering book details.
    /// </summary>
    private BookFormControl? bookFormControl;

    /// <summary>
    /// Represents the form control for entering audio book details.
    /// </summary>
    private AudioBookFormControl? audioBookFormControl;

    /// <summary>
    /// Event that is raised when a book is added.
    /// </summary>
    public EventHandler<Book>? OnBookAdded;

    /// <summary>
    /// Event that is raised when an audio book is added.
    /// </summary>
    public EventHandler<AudioBook>? OnAudioBookAdded;

    public AddBookControl()
    {
        InitializeComponent();

        // Set the default selection to Book
        BookRadioButton.Checked = true;
    }

    /// <summary>
    /// Handles the CheckedChanged event of the BookRadioButton control.
    /// Switches the form to the BookFormControl.
    /// </summary>
    private void BookRadioButton_CheckedChanged(object sender, EventArgs e)
    {
        // Set the audioBookFormControl to null as we are switching to BookFormControl
        audioBookFormControl = null;

        // Initialize a new instance of BookFormControl
        bookFormControl = new BookFormControl();

        // Clear any existing controls in the FormLayoutControl
        FormLayoutControl.Controls.Clear();

        // Add the new BookFormControl to the FormLayoutControl
        FormLayoutControl.Controls.Add(bookFormControl);
    }

    /// <summary>
    /// Handles the CheckedChanged event of the AudioBookRadioButton control.
    /// Switches the form to the AudioBookFormControl.
    /// </summary>
    private void AudioBookRadioButton_CheckedChanged(object sender, EventArgs e)
    {
        // Set the bookFormControl to null as we are switching to AudioBookFormControl
        bookFormControl = null;

        // Initialize a new instance of AudioBookFormControl
        audioBookFormControl = new AudioBookFormControl();

        // Clear any existing controls in the FormLayoutControl
        FormLayoutControl.Controls.Clear();

        // Add the new AudioBookFormControl to the FormLayoutControl
        FormLayoutControl.Controls.Add(audioBookFormControl);
    }

    /// <summary>
    /// Handles the Click event of the SaveBookButton control.
    /// Saves the book or audiobook based on the selected form and raises the appropriate event.
    /// </summary>
    private void SaveBookButton_Click(object sender, EventArgs e)
    {
        // Check if the book form control is not null
        if (bookFormControl != null)
        {
            // Get the book details from the book form control
            var book = bookFormControl.GetBook();

            // Raise the OnBookAdded event
            OnBookAdded?.Invoke(this, book);

            // Show success message
            MaterialSnackBar SnackBarMessage = new("Успешно добавена книга", "OK", true);
            SnackBarMessage.Show(this);
        }
        // Check if the audiobook form control is not null
        else if (audioBookFormControl != null)
        {
            // Get the audiobook details from the audiobook form control
            var audioBook = audioBookFormControl.GetBook();

            // Raise the OnAudioBookAdded event
            OnAudioBookAdded?.Invoke(this, audioBook);

            // Show success message
            MaterialSnackBar SnackBarMessage = new("Успешно е добавена аудио книга", "OK", true);
            SnackBarMessage.Show(this);
        }

        // Destroy the handle to close the form
        this.DestroyHandle();
    }
}
