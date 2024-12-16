using Common.Models;
using MaterialSkin.Controls;

namespace BooksProject.Forms.Controls;

public partial class AddBookControl : UserControl
{
    private BookFormControl? bookFormControl;
    private AudioBookFormControl? audioBookFormControl;

    public EventHandler<Book>? OnBookAdded;
    public EventHandler<AudioBook>? OnAudioBookAdded;

    public AddBookControl()
    {
        InitializeComponent();

        BookRadioButton.Checked = true;
    }

    private void BookRadioButton_CheckedChanged(object sender, EventArgs e)
    {
        audioBookFormControl = null;
        bookFormControl = new BookFormControl();
        FormLayoutControl.Controls.Clear();
        FormLayoutControl.Controls.Add(bookFormControl);
    }

    private void AudioBookRadioButton_CheckedChanged(object sender, EventArgs e)
    {
        bookFormControl = null;
        audioBookFormControl = new AudioBookFormControl();
        FormLayoutControl.Controls.Clear();
        FormLayoutControl.Controls.Add(audioBookFormControl);
    }

    private void SaveBookButton_Click(object sender, EventArgs e)
    {
        if (bookFormControl != null)
        {
            var book = bookFormControl.GetBook();

            OnBookAdded?.Invoke(this, book);

            MaterialSnackBar SnackBarMessage = new("Успешно добавена книга", "OK", true);
            SnackBarMessage.Show(this);
        }
        else if (audioBookFormControl != null)
        {
            var audioBook = audioBookFormControl.GetBook();

            OnAudioBookAdded?.Invoke(this, audioBook);

            MaterialSnackBar SnackBarMessage = new("Успешно е добавена аудио книга", "OK", true);
            SnackBarMessage.Show(this);
        }

        this.DestroyHandle();
    }
}
