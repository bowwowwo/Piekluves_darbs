namespace piekluves_darbs
{
    partial class BookPopUp
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BookTitle = new MaterialSkin.Controls.MaterialLabel();
            materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            BookAuthor = new MaterialSkin.Controls.MaterialLabel();
            description_box = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            chooseBook_button = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // BookTitle
            // 
            BookTitle.AutoSize = true;
            BookTitle.Depth = 0;
            BookTitle.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            BookTitle.Location = new Point(20, 83);
            BookTitle.MouseState = MaterialSkin.MouseState.HOVER;
            BookTitle.Name = "BookTitle";
            BookTitle.Size = new Size(32, 19);
            BookTitle.TabIndex = 0;
            BookTitle.Text = "Title";
            // 
            // materialDivider1
            // 
            materialDivider1.BackColor = Color.FromArgb(30, 0, 0, 0);
            materialDivider1.Depth = 0;
            materialDivider1.Location = new Point(20, 150);
            materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            materialDivider1.Name = "materialDivider1";
            materialDivider1.Size = new Size(409, 10);
            materialDivider1.TabIndex = 1;
            materialDivider1.Text = "materialDivider1";
            // 
            // BookAuthor
            // 
            BookAuthor.AutoSize = true;
            BookAuthor.Depth = 0;
            BookAuthor.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            BookAuthor.Location = new Point(20, 119);
            BookAuthor.MouseState = MaterialSkin.MouseState.HOVER;
            BookAuthor.Name = "BookAuthor";
            BookAuthor.Size = new Size(48, 19);
            BookAuthor.TabIndex = 3;
            BookAuthor.Text = "Author";
            // 
            // description_box
            // 
            description_box.AnimateReadOnly = false;
            description_box.BackgroundImageLayout = ImageLayout.None;
            description_box.CharacterCasing = CharacterCasing.Normal;
            description_box.Depth = 0;
            description_box.HideSelection = true;
            description_box.Location = new Point(20, 175);
            description_box.MaxLength = 32767;
            description_box.MouseState = MaterialSkin.MouseState.OUT;
            description_box.Name = "description_box";
            description_box.PasswordChar = '\0';
            description_box.ReadOnly = true;
            description_box.ScrollBars = ScrollBars.None;
            description_box.SelectedText = "";
            description_box.SelectionLength = 0;
            description_box.SelectionStart = 0;
            description_box.ShortcutsEnabled = true;
            description_box.Size = new Size(409, 137);
            description_box.TabIndex = 4;
            description_box.TabStop = false;
            description_box.Text = "description";
            description_box.TextAlign = HorizontalAlignment.Left;
            description_box.UseSystemPasswordChar = false;
            // 
            // chooseBook_button
            // 
            chooseBook_button.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            chooseBook_button.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            chooseBook_button.Depth = 0;
            chooseBook_button.HighEmphasis = true;
            chooseBook_button.Icon = null;
            chooseBook_button.Location = new Point(256, 331);
            chooseBook_button.Margin = new Padding(4, 6, 4, 6);
            chooseBook_button.MouseState = MaterialSkin.MouseState.HOVER;
            chooseBook_button.Name = "chooseBook_button";
            chooseBook_button.NoAccentTextColor = Color.Empty;
            chooseBook_button.Size = new Size(173, 36);
            chooseBook_button.TabIndex = 5;
            chooseBook_button.Text = "Izvēlēties grāmatu";
            chooseBook_button.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            chooseBook_button.UseAccentColor = false;
            chooseBook_button.UseVisualStyleBackColor = true;
            // 
            // BookPopUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(454, 483);
            Controls.Add(chooseBook_button);
            Controls.Add(description_box);
            Controls.Add(BookAuthor);
            Controls.Add(materialDivider1);
            Controls.Add(BookTitle);
            Name = "BookPopUp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel BookTitle;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialLabel BookAuthor;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 description_box;
        private MaterialSkin.Controls.MaterialButton chooseBook_button;
    }
}