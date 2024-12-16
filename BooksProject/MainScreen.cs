using BooksProject.Forms.Controls;
using BooksProject.Models;
using MaterialSkin;
using MaterialSkin.Controls;

namespace BooksProject;

public partial class MainScreen : MaterialForm
{
    public List<Book> Books;
    public List<AudioBook> AudioBooks;

    private readonly Label noDataLabel = new()
    {
        Name = "NoDataLabel",
        Text = "Няма добавени книги!",
        TextAlign = ContentAlignment.TopCenter,
        Size = new Size(478, 450)
    };

    public MainScreen(List<Book> books, List<AudioBook> audioBooks)
    {
        Books = books;
        AudioBooks = audioBooks;

        InitializeComponent();

        #region Configure color scheme
        MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
        materialSkinManager.AddFormToManage(this);
        materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;

        materialSkinManager.ColorScheme = new ColorScheme(
                    Primary.BlueGrey800,
                    Primary.BlueGrey900,
                    Primary.BlueGrey500,
                    Accent.LightBlue200,
                    TextShade.WHITE
        );
        #endregion

        SetListViewDataSource();

        AddButton.Click += AddButton_Click;
    }

    private void SetListViewDataSource()
    {
        var allItems = Books.Concat(AudioBooks).ToList();

        if (allItems.Count > 0)
        {
            if (BooksPreviewPanel.Controls.ContainsKey(noDataLabel.Name))
            {
                BooksPreviewPanel.Controls.RemoveByKey(noDataLabel.Name);
            }

            if (!BooksPreviewPanel.Controls.ContainsKey(BooksListView.Name))
            {
                BooksPreviewPanel.Controls.Add(BooksListView);
            }

            BooksListView.Items.Clear();

            foreach (var item in allItems)
            {
                var listViewItem = new ListViewItem(item.Name);
                listViewItem.SubItems.Add(item.Author);
                listViewItem.SubItems.Add(item.Genre.ToString());
                listViewItem.SubItems.Add(item.Language.ToString());
                BooksListView.Items.Add(listViewItem);
            }
        }
        else
        {
            BooksListView.Items.Clear();

            if (BooksPreviewPanel.Controls.ContainsKey(BooksListView.Name))
            {
                BooksPreviewPanel.Controls.RemoveByKey(BooksListView.Name);
            }

            if (!BooksPreviewPanel.Controls.ContainsKey(noDataLabel.Name))
            {
                BooksPreviewPanel.Controls.Add(noDataLabel);
            }
        }
    }

    private void AddButton_Click(object? sender, EventArgs e)
    {
        var addBookControl = new AddBookControl();
        addBookControl.OnBookAdded += (s, book) =>
        {
            Books.Add(book);
            SetListViewDataSource();
        };

        addBookControl.OnAudioBookAdded += (s, audioBook) =>
        {
            AudioBooks.Add(audioBook);
            SetListViewDataSource();
        };

        BookManagePanel.Controls.Clear();
        BookManagePanel.Controls.Add(addBookControl);
    }

    private void BooksListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
    {
        DeleteButton.Visible = BooksListView.SelectedItems.Count > 0;
        AddButton.Visible = BooksListView.SelectedItems.Count == 0;
    }

    private void DeleteButton_Click(object sender, EventArgs e)
    {
        BooksListView.SelectedItems.Cast<ListViewItem>().ToList().ForEach(item =>
        {
            var book = Books.FirstOrDefault(b => b.Name == item.Text && b.Author == item.SubItems[1].Text);
            var audioBook = AudioBooks.FirstOrDefault(b => b.Name == item.Text && b.Author == item.SubItems[1].Text);

            if (book != null)
            {
                Books.Remove(book);
                SetListViewDataSource();
            }
            else if (audioBook != null)
            {
                AudioBooks.Remove(audioBook);
                SetListViewDataSource();
            }
        });
    }
}
