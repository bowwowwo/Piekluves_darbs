namespace piekluves_darbs
{
    partial class ReturnForm
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
            book_combobox = new MaterialSkin.Controls.MaterialComboBox();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            return_book_button = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // book_combobox
            // 
            book_combobox.AutoResize = false;
            book_combobox.BackColor = Color.FromArgb(255, 255, 255);
            book_combobox.Depth = 0;
            book_combobox.DrawMode = DrawMode.OwnerDrawVariable;
            book_combobox.DropDownHeight = 174;
            book_combobox.DropDownStyle = ComboBoxStyle.DropDownList;
            book_combobox.DropDownWidth = 121;
            book_combobox.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            book_combobox.ForeColor = Color.FromArgb(222, 0, 0, 0);
            book_combobox.FormattingEnabled = true;
            book_combobox.IntegralHeight = false;
            book_combobox.ItemHeight = 43;
            book_combobox.Location = new Point(54, 121);
            book_combobox.MaxDropDownItems = 4;
            book_combobox.MouseState = MaterialSkin.MouseState.OUT;
            book_combobox.Name = "book_combobox";
            book_combobox.Size = new Size(257, 49);
            book_combobox.StartIndex = 0;
            book_combobox.TabIndex = 0;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(79, 88);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(194, 19);
            materialLabel1.TabIndex = 1;
            materialLabel1.Text = "Grāmatas, ko esat paņēmis";
            // 
            // return_book_button
            // 
            return_book_button.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            return_book_button.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            return_book_button.Depth = 0;
            return_book_button.HighEmphasis = true;
            return_book_button.Icon = null;
            return_book_button.Location = new Point(145, 204);
            return_book_button.Margin = new Padding(4, 6, 4, 6);
            return_book_button.MouseState = MaterialSkin.MouseState.HOVER;
            return_book_button.Name = "return_book_button";
            return_book_button.NoAccentTextColor = Color.Empty;
            return_book_button.Size = new Size(71, 36);
            return_book_button.TabIndex = 2;
            return_book_button.Text = "Nodot";
            return_book_button.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            return_book_button.UseAccentColor = false;
            return_book_button.UseVisualStyleBackColor = true;
            return_book_button.Click += return_book_button_Click;
            // 
            // ReturnForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 436);
            Controls.Add(return_book_button);
            Controls.Add(materialLabel1);
            Controls.Add(book_combobox);
            Name = "ReturnForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialComboBox book_combobox;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton return_book_button;
    }
}