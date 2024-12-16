namespace BooksProject.Forms.Controls;

partial class BookFormControl
{
    /// <summary> 
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// Clean up any resources being used.
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        BookNameTextBox = new MaterialSkin.Controls.MaterialTextBox2();
        AuthorTextBox = new MaterialSkin.Controls.MaterialTextBox2();
        GenreComboBox = new MaterialSkin.Controls.MaterialComboBox();
        LanguageTextBox = new MaterialSkin.Controls.MaterialTextBox2();
        materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
        PublishDateTimePicker = new DateTimePicker();
        SuspendLayout();
        // 
        // BookNameTextBox
        // 
        BookNameTextBox.AnimateReadOnly = false;
        BookNameTextBox.BackgroundImageLayout = ImageLayout.None;
        BookNameTextBox.CharacterCasing = CharacterCasing.Normal;
        BookNameTextBox.Depth = 0;
        BookNameTextBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
        BookNameTextBox.HideSelection = true;
        BookNameTextBox.Hint = "Заглавие";
        BookNameTextBox.LeadingIcon = null;
        BookNameTextBox.Location = new Point(3, 3);
        BookNameTextBox.MaxLength = 32767;
        BookNameTextBox.MouseState = MaterialSkin.MouseState.OUT;
        BookNameTextBox.Name = "BookNameTextBox";
        BookNameTextBox.PasswordChar = '\0';
        BookNameTextBox.PrefixSuffixText = null;
        BookNameTextBox.ReadOnly = false;
        BookNameTextBox.RightToLeft = RightToLeft.No;
        BookNameTextBox.SelectedText = "";
        BookNameTextBox.SelectionLength = 0;
        BookNameTextBox.SelectionStart = 0;
        BookNameTextBox.ShortcutsEnabled = true;
        BookNameTextBox.Size = new Size(286, 48);
        BookNameTextBox.TabIndex = 0;
        BookNameTextBox.TabStop = false;
        BookNameTextBox.TextAlign = HorizontalAlignment.Left;
        BookNameTextBox.TrailingIcon = null;
        BookNameTextBox.UseSystemPasswordChar = false;
        // 
        // AuthorTextBox
        // 
        AuthorTextBox.AnimateReadOnly = false;
        AuthorTextBox.BackgroundImageLayout = ImageLayout.None;
        AuthorTextBox.CharacterCasing = CharacterCasing.Normal;
        AuthorTextBox.Depth = 0;
        AuthorTextBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
        AuthorTextBox.HideSelection = true;
        AuthorTextBox.Hint = "Автор";
        AuthorTextBox.LeadingIcon = null;
        AuthorTextBox.Location = new Point(3, 57);
        AuthorTextBox.MaxLength = 32767;
        AuthorTextBox.MouseState = MaterialSkin.MouseState.OUT;
        AuthorTextBox.Name = "AuthorTextBox";
        AuthorTextBox.PasswordChar = '\0';
        AuthorTextBox.PrefixSuffixText = null;
        AuthorTextBox.ReadOnly = false;
        AuthorTextBox.RightToLeft = RightToLeft.No;
        AuthorTextBox.SelectedText = "";
        AuthorTextBox.SelectionLength = 0;
        AuthorTextBox.SelectionStart = 0;
        AuthorTextBox.ShortcutsEnabled = true;
        AuthorTextBox.Size = new Size(286, 48);
        AuthorTextBox.TabIndex = 1;
        AuthorTextBox.TabStop = false;
        AuthorTextBox.TextAlign = HorizontalAlignment.Left;
        AuthorTextBox.TrailingIcon = null;
        AuthorTextBox.UseSystemPasswordChar = false;
        // 
        // GenreComboBox
        // 
        GenreComboBox.AutoResize = false;
        GenreComboBox.BackColor = Color.FromArgb(255, 255, 255);
        GenreComboBox.Depth = 0;
        GenreComboBox.DrawMode = DrawMode.OwnerDrawVariable;
        GenreComboBox.DropDownHeight = 174;
        GenreComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        GenreComboBox.DropDownWidth = 121;
        GenreComboBox.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
        GenreComboBox.ForeColor = Color.FromArgb(222, 0, 0, 0);
        GenreComboBox.FormattingEnabled = true;
        GenreComboBox.Hint = "Жанр";
        GenreComboBox.IntegralHeight = false;
        GenreComboBox.ItemHeight = 43;
        GenreComboBox.Location = new Point(3, 111);
        GenreComboBox.MaxDropDownItems = 4;
        GenreComboBox.MouseState = MaterialSkin.MouseState.OUT;
        GenreComboBox.Name = "GenreComboBox";
        GenreComboBox.Size = new Size(286, 49);
        GenreComboBox.StartIndex = 0;
        GenreComboBox.TabIndex = 2;
        // 
        // LanguageTextBox
        // 
        LanguageTextBox.AnimateReadOnly = false;
        LanguageTextBox.BackgroundImageLayout = ImageLayout.None;
        LanguageTextBox.CharacterCasing = CharacterCasing.Normal;
        LanguageTextBox.Depth = 0;
        LanguageTextBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
        LanguageTextBox.HideSelection = true;
        LanguageTextBox.Hint = "Език";
        LanguageTextBox.LeadingIcon = null;
        LanguageTextBox.Location = new Point(3, 166);
        LanguageTextBox.MaxLength = 32767;
        LanguageTextBox.MouseState = MaterialSkin.MouseState.OUT;
        LanguageTextBox.Name = "LanguageTextBox";
        LanguageTextBox.PasswordChar = '\0';
        LanguageTextBox.PrefixSuffixText = null;
        LanguageTextBox.ReadOnly = false;
        LanguageTextBox.RightToLeft = RightToLeft.No;
        LanguageTextBox.SelectedText = "";
        LanguageTextBox.SelectionLength = 0;
        LanguageTextBox.SelectionStart = 0;
        LanguageTextBox.ShortcutsEnabled = true;
        LanguageTextBox.Size = new Size(286, 48);
        LanguageTextBox.TabIndex = 3;
        LanguageTextBox.TabStop = false;
        LanguageTextBox.TextAlign = HorizontalAlignment.Left;
        LanguageTextBox.TrailingIcon = null;
        LanguageTextBox.UseSystemPasswordChar = false;
        // 
        // materialLabel1
        // 
        materialLabel1.AutoSize = true;
        materialLabel1.Depth = 0;
        materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
        materialLabel1.Location = new Point(3, 234);
        materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
        materialLabel1.Name = "materialLabel1";
        materialLabel1.Size = new Size(100, 19);
        materialLabel1.TabIndex = 12;
        materialLabel1.Text = "Публикувана";
        // 
        // PublishDateTimePicker
        // 
        PublishDateTimePicker.Location = new Point(152, 229);
        PublishDateTimePicker.Name = "PublishDateTimePicker";
        PublishDateTimePicker.Size = new Size(137, 23);
        PublishDateTimePicker.TabIndex = 11;
        // 
        // BookFormControl
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(materialLabel1);
        Controls.Add(PublishDateTimePicker);
        Controls.Add(LanguageTextBox);
        Controls.Add(GenreComboBox);
        Controls.Add(AuthorTextBox);
        Controls.Add(BookNameTextBox);
        Name = "BookFormControl";
        Size = new Size(292, 422);
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private MaterialSkin.Controls.MaterialTextBox2 BookNameTextBox;
    private MaterialSkin.Controls.MaterialTextBox2 AuthorTextBox;
    private MaterialSkin.Controls.MaterialComboBox GenreComboBox;
    private MaterialSkin.Controls.MaterialTextBox2 LanguageTextBox;
    private MaterialSkin.Controls.MaterialLabel materialLabel1;
    private DateTimePicker PublishDateTimePicker;
}
