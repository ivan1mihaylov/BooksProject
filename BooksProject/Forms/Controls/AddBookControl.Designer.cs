namespace BooksProject.Forms.Controls;

partial class AddBookControl
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
        FormLayoutControl = new FlowLayoutPanel();
        BookRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
        AudioBookRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
        SaveBookButton = new MaterialSkin.Controls.MaterialButton();
        SuspendLayout();
        // 
        // FormLayoutControl
        // 
        FormLayoutControl.Location = new Point(3, 72);
        FormLayoutControl.Name = "FormLayoutControl";
        FormLayoutControl.Size = new Size(292, 422);
        FormLayoutControl.TabIndex = 4;
        // 
        // BookRadioButton
        // 
        BookRadioButton.AutoSize = true;
        BookRadioButton.Depth = 0;
        BookRadioButton.Location = new Point(24, 19);
        BookRadioButton.Margin = new Padding(0);
        BookRadioButton.MouseLocation = new Point(-1, -1);
        BookRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
        BookRadioButton.Name = "BookRadioButton";
        BookRadioButton.Ripple = true;
        BookRadioButton.Size = new Size(79, 37);
        BookRadioButton.TabIndex = 0;
        BookRadioButton.TabStop = true;
        BookRadioButton.Text = "Книга";
        BookRadioButton.UseVisualStyleBackColor = true;
        BookRadioButton.CheckedChanged += BookRadioButton_CheckedChanged;
        // 
        // AudioBookRadioButton
        // 
        AudioBookRadioButton.AutoSize = true;
        AudioBookRadioButton.Depth = 0;
        AudioBookRadioButton.Location = new Point(128, 19);
        AudioBookRadioButton.Margin = new Padding(0);
        AudioBookRadioButton.MouseLocation = new Point(-1, -1);
        AudioBookRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
        AudioBookRadioButton.Name = "AudioBookRadioButton";
        AudioBookRadioButton.Ripple = true;
        AudioBookRadioButton.Size = new Size(128, 37);
        AudioBookRadioButton.TabIndex = 1;
        AudioBookRadioButton.TabStop = true;
        AudioBookRadioButton.Text = "Аудио книга";
        AudioBookRadioButton.UseVisualStyleBackColor = true;
        AudioBookRadioButton.CheckedChanged += AudioBookRadioButton_CheckedChanged;
        // 
        // SaveBookButton
        // 
        SaveBookButton.AutoSize = false;
        SaveBookButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        SaveBookButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
        SaveBookButton.Depth = 0;
        SaveBookButton.HighEmphasis = true;
        SaveBookButton.Icon = null;
        SaveBookButton.Location = new Point(3, 503);
        SaveBookButton.Margin = new Padding(4, 6, 4, 6);
        SaveBookButton.MouseState = MaterialSkin.MouseState.HOVER;
        SaveBookButton.Name = "SaveBookButton";
        SaveBookButton.NoAccentTextColor = Color.Empty;
        SaveBookButton.Size = new Size(291, 36);
        SaveBookButton.TabIndex = 5;
        SaveBookButton.Text = "Запазване";
        SaveBookButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
        SaveBookButton.UseAccentColor = true;
        SaveBookButton.UseVisualStyleBackColor = true;
        SaveBookButton.Click += SaveBookButton_Click;
        // 
        // AddBookControl
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(SaveBookButton);
        Controls.Add(AudioBookRadioButton);
        Controls.Add(FormLayoutControl);
        Controls.Add(BookRadioButton);
        Name = "AddBookControl";
        Size = new Size(298, 545);
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private FlowLayoutPanel FormLayoutControl;
    private MaterialSkin.Controls.MaterialRadioButton AudioBookRadioButton;
    private MaterialSkin.Controls.MaterialRadioButton BookRadioButton;
    private MaterialSkin.Controls.MaterialButton SaveBookButton;
}
