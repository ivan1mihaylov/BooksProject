using BooksProject.Forms.Controls;
using Common.Models;
using MaterialSkin;
using MaterialSkin.Controls;

namespace BooksProject.Forms;

/// <summary>
/// Represents the main screen of the application.
/// </summary>
public partial class MainScreen : MaterialForm
{
    /// <summary>
    /// List of books.
    /// </summary>
    public List<Book> Books = [];

    /// <summary>
    /// List of audiobooks.
    /// </summary>
    public List<AudioBook> AudioBooks = [];

    /// <summary>
    /// Label to display when there are no books or audiobooks.
    /// </summary>
    private readonly Label noDataLabel = new()
    {
        Name = "NoDataLabel",
        Text = "Няма добавени книги!",
        TextAlign = ContentAlignment.TopCenter,
        Size = new Size(478, 450)
    };

    /// <summary>
    /// Initializes a new instance of the <see cref="MainScreen"/> class.
    /// </summary>
    /// <param name="books">Collection of books.</param>
    /// <param name="audioBooks">Collection of audiobooks.</param>
    public MainScreen(ICollection<Book> books, ICollection<AudioBook> audioBooks)
    {
        // Add the provided books to the Books list
        Books.AddRange(books);

        // Add the provided audiobooks to the AudioBooks list
        AudioBooks.AddRange(audioBooks);

        // Initialize the form components
        InitializeComponent();

        #region Configure color scheme
        // Get the instance of MaterialSkinManager
        MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;

        // Add this form to the MaterialSkinManager to manage its theme and color scheme
        materialSkinManager.AddFormToManage(this);

        // Set the theme to dark
        materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;

        // Set the color scheme with specified primary, accent, and text colors
        materialSkinManager.ColorScheme = new ColorScheme(
                    Primary.BlueGrey800,
                    Primary.BlueGrey900,
                    Primary.BlueGrey500,
                    Accent.LightBlue200,
                    TextShade.WHITE
        );
        #endregion

        // Set the data source for the ListView control
        SetListViewDataSource();

        // Subscribe to the Add button click event
        AddButton.Click += AddButton_Click;
    }

    /// <summary>
    /// Sets the data source for the ListView control.
    /// </summary>
    private void SetListViewDataSource()
    {
        // Combine books and audiobooks into a single list
        var allItems = Books.Concat(AudioBooks).ToList();

        // Check if there are any items to display
        if (allItems.Count > 0)
        {
            // Remove the no data label if it exists
            if (BooksPreviewPanel.Controls.ContainsKey(noDataLabel.Name))
            {
                BooksPreviewPanel.Controls.RemoveByKey(noDataLabel.Name);
            }

            // Add the ListView control if it does not exist
            if (!BooksPreviewPanel.Controls.ContainsKey(BooksListView.Name))
            {
                BooksPreviewPanel.Controls.Add(BooksListView);
            }

            // Add each item to the ListView
            foreach (var item in allItems)
            {
                // Skip items that are already in the ListView
                if (BooksListView.Items.ContainsKey(item.ToShortString()))
                {
                    continue;
                }

                // Create a new ListViewItem for the book or audiobook
                var listViewItem = new ListViewItem(item.Name)
                {
                    Name = item.ToShortString()
                };

                // Add sub-items for author, genre, and language
                listViewItem.SubItems.Add(item.Author);
                listViewItem.SubItems.Add(item.Genre.ToString());
                listViewItem.SubItems.Add(item.Language.ToString());

                // Add the ListViewItem to the ListView
                BooksListView.Items.Add(listViewItem);
            }
        }
        else
        {
            // Clear the ListView if there are no items
            BooksListView.Items.Clear();

            // Remove the ListView control if it exists
            if (BooksPreviewPanel.Controls.ContainsKey(BooksListView.Name))
            {
                BooksPreviewPanel.Controls.RemoveByKey(BooksListView.Name);
            }

            // Add the no data label if it does not exist
            if (!BooksPreviewPanel.Controls.ContainsKey(noDataLabel.Name))
            {
                BooksPreviewPanel.Controls.Add(noDataLabel);
            }
        }
    }

    /// <summary>
    /// Handles the Add button click event.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void AddButton_Click(object? sender, EventArgs e)
    {
        // Create a new instance of AddBookControl
        var addBookControl = new AddBookControl();

        // Subscribe to the OnBookAdded event to add the new book to the Books list and update the ListView
        addBookControl.OnBookAdded += (s, book) =>
        {
            Books.Add(book);
            SetListViewDataSource();
        };

        // Subscribe to the OnAudioBookAdded event to add the new audiobook to the AudioBooks list and update the ListView
        addBookControl.OnAudioBookAdded += (s, audioBook) =>
        {
            AudioBooks.Add(audioBook);
            SetListViewDataSource();
        };

        // Subscribe to the ControlRemoved event to dispose of the AddBookControl when it is removed from the panel
        BookManagePanel.ControlRemoved += (s, e) =>
        {
            var control = (AddBookControl)e.Control;
            control?.Dispose();
        };

        // Clear the controls in the BookManagePanel and add the AddBookControl
        BookManagePanel.Controls.Clear();
        BookManagePanel.Controls.Add(addBookControl);
    }

    /// <summary>
    /// Handles the item selection changed event of the ListView.
    /// </summary>
    private void BooksListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
    {
        // Show the Delete button if any items are selected
        DeleteButton.Visible = BooksListView.SelectedItems.Count > 0;

        // Show the Add button if no items are selected
        AddButton.Visible = BooksListView.SelectedItems.Count == 0;
    }

    /// <summary>
    /// Handles the mouse double-click event of the ListView.
    /// </summary>
    private void BooksListView_MouseDoubleClick(object sender, MouseEventArgs e)
    {
        // Get the item that was double-clicked
        ListViewHitTestInfo info = BooksListView.HitTest(e.X, e.Y);
        ListViewItem item = info.Item ?? new ListViewItem();

        // Check if the item is not null
        if (item != null)
        {
            // Find the book or audiobook that matches the selected item
            var book = Books.FirstOrDefault(b => b.Name == item.Text && b.Author == item.SubItems[1].Text);
            var audioBook = AudioBooks.FirstOrDefault(b => b.Name == item.Text && b.Author == item.SubItems[1].Text);

            // Display the information of the selected book or audiobook
            MessageBox.Show($"{book?.ToString() ?? audioBook?.ToString()}", "Информация за избраната книга");
        }
    }

    /// <summary>
    /// Handles the Delete button click event.
    /// </summary>
    private void DeleteButton_Click(object sender, EventArgs e)
    {
        // Iterate through each selected item in the ListView
        BooksListView.SelectedItems.Cast<ListViewItem>().ToList().ForEach(item =>
        {
            // Find the corresponding book or audiobook based on the selected item's text and sub-items
            var book = Books.FirstOrDefault(b => b.Name == item.Text && b.Author == item.SubItems[1].Text);
            var audioBook = AudioBooks.FirstOrDefault(b => b.Name == item.Text && b.Author == item.SubItems[1].Text);

            // Remove the book or audiobook from the respective list if found
            if (book != null)
            {
                Books.Remove(book);
            }
            else if (audioBook != null)
            {
                AudioBooks.Remove(audioBook);
            }
            else
            {
                return;
            }

            // Remove the item from the ListView
            BooksListView.Items.Remove(item);

            // Remove the ListView control from the panel if it exists
            if (BooksPreviewPanel.Controls.ContainsKey(BooksListView.Name))
            {
                BooksPreviewPanel.Controls.RemoveByKey(BooksListView.Name);
            }

            // Add the no data label to the panel if it does not exist
            if (!BooksPreviewPanel.Controls.ContainsKey(noDataLabel.Name))
            {
                BooksPreviewPanel.Controls.Add(noDataLabel);
            }
        });
    }
}
