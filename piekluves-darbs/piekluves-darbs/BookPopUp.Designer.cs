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
            due_date_box = new MaterialSkin.Controls.MaterialComboBox();
            agreement_check = new MaterialSkin.Controls.MaterialCheckbox();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            SuspendLayout();
            // 
            // BookTitle
            // 
            BookTitle.Anchor = AnchorStyles.None;
            BookTitle.AutoSize = true;
            BookTitle.Depth = 0;
            BookTitle.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            BookTitle.Location = new Point(30, 82);
            BookTitle.MouseState = MaterialSkin.MouseState.HOVER;
            BookTitle.Name = "BookTitle";
            BookTitle.Size = new Size(32, 19);
            BookTitle.TabIndex = 0;
            BookTitle.Text = "Title";
            // 
            // materialDivider1
            // 
            materialDivider1.Anchor = AnchorStyles.None;
            materialDivider1.BackColor = Color.FromArgb(30, 0, 0, 0);
            materialDivider1.Depth = 0;
            materialDivider1.Location = new Point(30, 153);
            materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            materialDivider1.Name = "materialDivider1";
            materialDivider1.Size = new Size(641, 10);
            materialDivider1.TabIndex = 1;
            materialDivider1.Text = "materialDivider1";
            // 
            // BookAuthor
            // 
            BookAuthor.Anchor = AnchorStyles.None;
            BookAuthor.AutoSize = true;
            BookAuthor.Depth = 0;
            BookAuthor.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            BookAuthor.Location = new Point(30, 115);
            BookAuthor.MouseState = MaterialSkin.MouseState.HOVER;
            BookAuthor.Name = "BookAuthor";
            BookAuthor.Size = new Size(48, 19);
            BookAuthor.TabIndex = 3;
            BookAuthor.Text = "Author";
            // 
            // description_box
            // 
            description_box.Anchor = AnchorStyles.None;
            description_box.AnimateReadOnly = false;
            description_box.BackgroundImageLayout = ImageLayout.None;
            description_box.CharacterCasing = CharacterCasing.Normal;
            description_box.Depth = 0;
            description_box.HideSelection = true;
            description_box.Location = new Point(30, 169);
            description_box.MaxLength = 32767;
            description_box.MouseState = MaterialSkin.MouseState.OUT;
            description_box.Name = "description_box";
            description_box.PasswordChar = '\0';
            description_box.ReadOnly = true;
            description_box.ScrollBars = ScrollBars.Vertical;
            description_box.SelectedText = "";
            description_box.SelectionLength = 0;
            description_box.SelectionStart = 0;
            description_box.ShortcutsEnabled = true;
            description_box.Size = new Size(641, 290);
            description_box.TabIndex = 4;
            description_box.TabStop = false;
            description_box.Text = "description";
            description_box.TextAlign = HorizontalAlignment.Left;
            description_box.UseSystemPasswordChar = false;
            // 
            // chooseBook_button
            // 
            chooseBook_button.Anchor = AnchorStyles.None;
            chooseBook_button.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            chooseBook_button.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            chooseBook_button.Depth = 0;
            chooseBook_button.HighEmphasis = true;
            chooseBook_button.Icon = null;
            chooseBook_button.Location = new Point(498, 468);
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
            chooseBook_button.Click += chooseBook_button_Click;
            // 
            // due_date_box
            // 
            due_date_box.Anchor = AnchorStyles.None;
            due_date_box.AutoResize = false;
            due_date_box.BackColor = Color.FromArgb(255, 255, 255);
            due_date_box.Depth = 0;
            due_date_box.DrawMode = DrawMode.OwnerDrawVariable;
            due_date_box.DropDownHeight = 174;
            due_date_box.DropDownStyle = ComboBoxStyle.DropDownList;
            due_date_box.DropDownWidth = 121;
            due_date_box.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            due_date_box.ForeColor = Color.FromArgb(222, 0, 0, 0);
            due_date_box.FormattingEnabled = true;
            due_date_box.IntegralHeight = false;
            due_date_box.ItemHeight = 43;
            due_date_box.Items.AddRange(new object[] { "1 nedēļa", "2 nedēļas", "3 nedēļas" });
            due_date_box.Location = new Point(178, 464);
            due_date_box.MaxDropDownItems = 4;
            due_date_box.MouseState = MaterialSkin.MouseState.OUT;
            due_date_box.Name = "due_date_box";
            due_date_box.Size = new Size(166, 49);
            due_date_box.StartIndex = 0;
            due_date_box.TabIndex = 6;
            // 
            // agreement_check
            // 
            agreement_check.Anchor = AnchorStyles.None;
            agreement_check.AutoSize = true;
            agreement_check.Depth = 0;
            agreement_check.Location = new Point(21, 516);
            agreement_check.Margin = new Padding(0);
            agreement_check.MouseLocation = new Point(-1, -1);
            agreement_check.MouseState = MaterialSkin.MouseState.HOVER;
            agreement_check.Name = "agreement_check";
            agreement_check.ReadOnly = false;
            agreement_check.Ripple = true;
            agreement_check.Size = new Size(364, 37);
            agreement_check.TabIndex = 7;
            agreement_check.Text = "Es piekrītu grāmatas rezervācijas noteikumiem";
            agreement_check.UseVisualStyleBackColor = true;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(30, 481);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(142, 19);
            materialLabel1.TabIndex = 8;
            materialLabel1.Text = "Rezervācijas ilgums";
            // 
            // BookPopUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(702, 568);
            Controls.Add(materialLabel1);
            Controls.Add(agreement_check);
            Controls.Add(due_date_box);
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
        private MaterialSkin.Controls.MaterialComboBox due_date_box;
        private MaterialSkin.Controls.MaterialCheckbox agreement_check;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}