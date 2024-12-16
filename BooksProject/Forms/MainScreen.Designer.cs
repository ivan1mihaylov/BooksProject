
namespace BooksProject.Forms;

partial class MainScreen
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        BookManagePanel = new FlowLayoutPanel();
        AddButton = new MaterialSkin.Controls.MaterialFloatingActionButton();
        BooksListView = new MaterialSkin.Controls.MaterialListView();
        NameColumn = new ColumnHeader();
        AuthorColumn = new ColumnHeader();
        GenreColumn = new ColumnHeader();
        LanguageColumn = new ColumnHeader();
        BooksPreviewPanel = new FlowLayoutPanel();
        materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
        DeleteButton = new MaterialSkin.Controls.MaterialFloatingActionButton();
        BooksPreviewPanel.SuspendLayout();
        SuspendLayout();
        // 
        // BookManagePanel
        // 
        BookManagePanel.Location = new Point(6, 67);
        BookManagePanel.Name = "BookManagePanel";
        BookManagePanel.Size = new Size(298, 545);
        BookManagePanel.TabIndex = 0;
        // 
        // AddButton
        // 
        AddButton.Depth = 0;
        AddButton.ForeColor = SystemColors.ControlText;
        AddButton.Icon = Properties.Resources.plus;
        AddButton.Location = new Point(771, 546);
        AddButton.MouseState = MaterialSkin.MouseState.HOVER;
        AddButton.Name = "AddButton";
        AddButton.Size = new Size(56, 56);
        AddButton.TabIndex = 1;
        AddButton.Text = "+";
        AddButton.UseVisualStyleBackColor = true;
        // 
        // BooksListView
        // 
        BooksListView.AllowColumnReorder = true;
        BooksListView.AutoSizeTable = true;
        BooksListView.BackColor = Color.FromArgb(255, 255, 255);
        BooksListView.BorderStyle = BorderStyle.None;
        BooksListView.Columns.AddRange(new ColumnHeader[] { NameColumn, AuthorColumn, GenreColumn, LanguageColumn });
        BooksListView.Depth = 0;
        BooksListView.Dock = DockStyle.Fill;
        BooksListView.Font = new Font("Microsoft Sans Serif", 34F, FontStyle.Bold, GraphicsUnit.Pixel);
        BooksListView.FullRowSelect = true;
        BooksListView.Location = new Point(3, 3);
        BooksListView.MaximumSize = new Size(528, 420);
        BooksListView.MinimumSize = new Size(528, 420);
        BooksListView.MouseLocation = new Point(-1, -1);
        BooksListView.MouseState = MaterialSkin.MouseState.OUT;
        BooksListView.Name = "BooksListView";
        BooksListView.OwnerDraw = true;
        BooksListView.Scrollable = true;
        BooksListView.Size = new Size(528, 420);
        BooksListView.TabIndex = 2;
        BooksListView.UseCompatibleStateImageBehavior = false;
        BooksListView.View = View.Details;
        BooksListView.ItemSelectionChanged += BooksListView_ItemSelectionChanged;
        BooksListView.MouseDoubleClick += BooksListView_MouseDoubleClick;
        // 
        // NameColumn
        // 
        NameColumn.Text = "Име";
        NameColumn.Width = 180;
        // 
        // AuthorColumn
        // 
        AuthorColumn.Text = "Автор";
        AuthorColumn.Width = 110;
        // 
        // GenreColumn
        // 
        GenreColumn.Text = "Жанр";
        GenreColumn.Width = 100;
        // 
        // LanguageColumn
        // 
        LanguageColumn.Text = "Език";
        LanguageColumn.Width = 120;
        // 
        // BooksPreviewPanel
        // 
        BooksPreviewPanel.Controls.Add(BooksListView);
        BooksPreviewPanel.Location = new Point(310, 97);
        BooksPreviewPanel.Name = "BooksPreviewPanel";
        BooksPreviewPanel.Size = new Size(528, 426);
        BooksPreviewPanel.TabIndex = 3;
        // 
        // materialLabel1
        // 
        materialLabel1.Depth = 0;
        materialLabel1.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
        materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
        materialLabel1.Location = new Point(310, 67);
        materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
        materialLabel1.Name = "materialLabel1";
        materialLabel1.Size = new Size(483, 27);
        materialLabel1.TabIndex = 0;
        materialLabel1.Text = "Списък с налични книги";
        materialLabel1.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // DeleteButton
        // 
        DeleteButton.Depth = 0;
        DeleteButton.ForeColor = SystemColors.ControlText;
        DeleteButton.Icon = Properties.Resources.trash;
        DeleteButton.Location = new Point(771, 546);
        DeleteButton.MouseState = MaterialSkin.MouseState.HOVER;
        DeleteButton.Name = "DeleteButton";
        DeleteButton.Size = new Size(56, 56);
        DeleteButton.TabIndex = 4;
        DeleteButton.Text = "+";
        DeleteButton.UseVisualStyleBackColor = true;
        DeleteButton.Visible = false;
        DeleteButton.Click += DeleteButton_Click;
        // 
        // MainScreen
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(844, 618);
        Controls.Add(DeleteButton);
        Controls.Add(materialLabel1);
        Controls.Add(AddButton);
        Controls.Add(BookManagePanel);
        Controls.Add(BooksPreviewPanel);
        Name = "MainScreen";
        Text = "Каталог от книги";
        BooksPreviewPanel.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private FlowLayoutPanel BookManagePanel;
    private MaterialSkin.Controls.MaterialFloatingActionButton AddButton;
    private MaterialSkin.Controls.MaterialListView BooksListView;
    private FlowLayoutPanel BooksPreviewPanel;
    private ColumnHeader NameColumn;
    private ColumnHeader AuthorColumn;
    private ColumnHeader GenreColumn;
    private ColumnHeader LanguageColumn;
    private MaterialSkin.Controls.MaterialLabel materialLabel1;
    private MaterialSkin.Controls.MaterialFloatingActionButton DeleteButton;
}
