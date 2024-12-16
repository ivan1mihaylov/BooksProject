namespace BooksProject.Forms.Controls;

partial class AudioBookFormControl
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
        NameTextBox = new MaterialSkin.Controls.MaterialTextBox2();
        AuthorTextBox = new MaterialSkin.Controls.MaterialTextBox2();
        GenreComboBox = new MaterialSkin.Controls.MaterialComboBox();
        LanguageTextBox = new MaterialSkin.Controls.MaterialTextBox2();
        NarratorTextBox = new MaterialSkin.Controls.MaterialTextBox2();
        DurationDateTimePicker = new DateTimePicker();
        PriceTextBox = new MaterialSkin.Controls.MaterialTextBox2();
        DurationLabel = new MaterialSkin.Controls.MaterialLabel();
        materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
        PublishDateTimePicker = new DateTimePicker();
        SuspendLayout();
        // 
        // NameTextBox
        // 
        NameTextBox.AnimateReadOnly = false;
        NameTextBox.BackgroundImageLayout = ImageLayout.None;
        NameTextBox.CharacterCasing = CharacterCasing.Normal;
        NameTextBox.Depth = 0;
        NameTextBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
        NameTextBox.HideSelection = true;
        NameTextBox.Hint = "Заглавие";
        NameTextBox.LeadingIcon = null;
        NameTextBox.Location = new Point(3, 3);
        NameTextBox.MaxLength = 32767;
        NameTextBox.MouseState = MaterialSkin.MouseState.OUT;
        NameTextBox.Name = "NameTextBox";
        NameTextBox.PasswordChar = '\0';
        NameTextBox.PrefixSuffixText = null;
        NameTextBox.ReadOnly = false;
        NameTextBox.RightToLeft = RightToLeft.No;
        NameTextBox.SelectedText = "";
        NameTextBox.SelectionLength = 0;
        NameTextBox.SelectionStart = 0;
        NameTextBox.ShortcutsEnabled = true;
        NameTextBox.Size = new Size(286, 48);
        NameTextBox.TabIndex = 0;
        NameTextBox.TabStop = false;
        NameTextBox.TextAlign = HorizontalAlignment.Left;
        NameTextBox.TrailingIcon = null;
        NameTextBox.UseSystemPasswordChar = false;
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
        GenreComboBox.TabIndex = 3;
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
        LanguageTextBox.TabIndex = 4;
        LanguageTextBox.TabStop = false;
        LanguageTextBox.TextAlign = HorizontalAlignment.Left;
        LanguageTextBox.TrailingIcon = null;
        LanguageTextBox.UseSystemPasswordChar = false;
        // 
        // NarratorTextBox
        // 
        NarratorTextBox.AnimateReadOnly = false;
        NarratorTextBox.BackgroundImageLayout = ImageLayout.None;
        NarratorTextBox.CharacterCasing = CharacterCasing.Normal;
        NarratorTextBox.Depth = 0;
        NarratorTextBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
        NarratorTextBox.HideSelection = true;
        NarratorTextBox.Hint = "Име на четеца";
        NarratorTextBox.LeadingIcon = null;
        NarratorTextBox.Location = new Point(3, 220);
        NarratorTextBox.MaxLength = 32767;
        NarratorTextBox.MouseState = MaterialSkin.MouseState.OUT;
        NarratorTextBox.Name = "NarratorTextBox";
        NarratorTextBox.PasswordChar = '\0';
        NarratorTextBox.PrefixSuffixText = null;
        NarratorTextBox.ReadOnly = false;
        NarratorTextBox.RightToLeft = RightToLeft.No;
        NarratorTextBox.SelectedText = "";
        NarratorTextBox.SelectionLength = 0;
        NarratorTextBox.SelectionStart = 0;
        NarratorTextBox.ShortcutsEnabled = true;
        NarratorTextBox.Size = new Size(286, 48);
        NarratorTextBox.TabIndex = 5;
        NarratorTextBox.TabStop = false;
        NarratorTextBox.TextAlign = HorizontalAlignment.Left;
        NarratorTextBox.TrailingIcon = null;
        NarratorTextBox.UseSystemPasswordChar = false;
        // 
        // DurationDateTimePicker
        // 
        DurationDateTimePicker.CustomFormat = "hh:mm";
        DurationDateTimePicker.Format = DateTimePickerFormat.Custom;
        DurationDateTimePicker.Location = new Point(152, 380);
        DurationDateTimePicker.Name = "DurationDateTimePicker";
        DurationDateTimePicker.ShowUpDown = true;
        DurationDateTimePicker.Size = new Size(137, 23);
        DurationDateTimePicker.TabIndex = 6;
        // 
        // PriceTextBox
        // 
        PriceTextBox.AnimateReadOnly = false;
        PriceTextBox.BackgroundImageLayout = ImageLayout.None;
        PriceTextBox.CharacterCasing = CharacterCasing.Normal;
        PriceTextBox.Depth = 0;
        PriceTextBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
        PriceTextBox.HideSelection = true;
        PriceTextBox.Hint = "Цена";
        PriceTextBox.LeadingIcon = null;
        PriceTextBox.Location = new Point(3, 274);
        PriceTextBox.MaxLength = 32767;
        PriceTextBox.MouseState = MaterialSkin.MouseState.OUT;
        PriceTextBox.Name = "PriceTextBox";
        PriceTextBox.PasswordChar = '\0';
        PriceTextBox.PrefixSuffix = MaterialSkin.Controls.MaterialTextBox2.PrefixSuffixTypes.Suffix;
        PriceTextBox.PrefixSuffixText = "лв.";
        PriceTextBox.ReadOnly = false;
        PriceTextBox.RightToLeft = RightToLeft.Yes;
        PriceTextBox.SelectedText = "";
        PriceTextBox.SelectionLength = 0;
        PriceTextBox.SelectionStart = 0;
        PriceTextBox.ShortcutsEnabled = true;
        PriceTextBox.Size = new Size(286, 48);
        PriceTextBox.TabIndex = 7;
        PriceTextBox.TabStop = false;
        PriceTextBox.TextAlign = HorizontalAlignment.Left;
        PriceTextBox.TrailingIcon = null;
        PriceTextBox.UseSystemPasswordChar = false;
        PriceTextBox.KeyDown += PriceTextBox_KeyDown;
        // 
        // DurationLabel
        // 
        DurationLabel.AutoSize = true;
        DurationLabel.Depth = 0;
        DurationLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
        DurationLabel.Location = new Point(3, 385);
        DurationLabel.MouseState = MaterialSkin.MouseState.HOVER;
        DurationLabel.Name = "DurationLabel";
        DurationLabel.Size = new Size(139, 19);
        DurationLabel.TabIndex = 8;
        DurationLabel.Text = "Продължителност";
        // 
        // materialLabel1
        // 
        materialLabel1.AutoSize = true;
        materialLabel1.Depth = 0;
        materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
        materialLabel1.Location = new Point(3, 345);
        materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
        materialLabel1.Name = "materialLabel1";
        materialLabel1.Size = new Size(100, 19);
        materialLabel1.TabIndex = 10;
        materialLabel1.Text = "Публикувана";
        // 
        // PublishDateTimePicker
        // 
        PublishDateTimePicker.Location = new Point(152, 341);
        PublishDateTimePicker.Name = "PublishDateTimePicker";
        PublishDateTimePicker.Size = new Size(137, 23);
        PublishDateTimePicker.TabIndex = 9;
        // 
        // AudioBookFormControl
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(materialLabel1);
        Controls.Add(PublishDateTimePicker);
        Controls.Add(DurationLabel);
        Controls.Add(PriceTextBox);
        Controls.Add(DurationDateTimePicker);
        Controls.Add(NarratorTextBox);
        Controls.Add(LanguageTextBox);
        Controls.Add(GenreComboBox);
        Controls.Add(AuthorTextBox);
        Controls.Add(NameTextBox);
        Name = "AudioBookFormControl";
        Size = new Size(292, 422);
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private MaterialSkin.Controls.MaterialTextBox2 NameTextBox;
    private MaterialSkin.Controls.MaterialTextBox2 AuthorTextBox;
    private MaterialSkin.Controls.MaterialComboBox GenreComboBox;
    private MaterialSkin.Controls.MaterialTextBox2 LanguageTextBox;
    private MaterialSkin.Controls.MaterialTextBox2 NarratorTextBox;
    private DateTimePicker DurationDateTimePicker;
    private MaterialSkin.Controls.MaterialTextBox2 PriceTextBox;
    private MaterialSkin.Controls.MaterialLabel DurationLabel;
    private MaterialSkin.Controls.MaterialLabel materialLabel1;
    private DateTimePicker PublishDateTimePicker;
}
