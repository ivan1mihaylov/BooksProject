using BooksProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BooksProject.Forms.Controls
{
    public partial class AddBookControl : UserControl
    {
        private BookFormControl? bookFormControl;
        private AudioBookFormControl? audioBookFormControl;

        public EventHandler<Book> OnBookAdded;
        public EventHandler<AudioBook> OnAudioBookAdded;

        public AddBookControl()
        {
            InitializeComponent();
        }

        private void BookRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            bookFormControl = new BookFormControl();
            FormLayoutControl.Controls.Clear();
            FormLayoutControl.Controls.Add(bookFormControl);
        }

        private void AudioBookRadioButton_CheckedChanged(object sender, EventArgs e)
        {
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

                MessageBox.Show($"Успешно е добавена книга със следната информация: {book}", "Успешно добавена книга");
            }
            else if (audioBookFormControl != null)
            {
                //var audioBook = audioBookFormControl.GetBook();
                //OnAudioBookAdded?.Invoke(this, audioBook);

                //MessageBox.Show($"Успешно е добавена аудио книга със следната информация: {audioBook.ToString()}", "Успешно добавена книга");
            }

        }
    }
}
