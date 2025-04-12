namespace piekluves_darbs
{
    partial class mainPage
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainPage));
            materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            reservation_tab = new TabPage();
            return_book_button = new MaterialSkin.Controls.MaterialButton();
            materialCard3 = new MaterialSkin.Controls.MaterialCard();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            reservation_list = new MaterialSkin.Controls.MaterialListView();
            log_tab = new TabPage();
            return_book_button2 = new MaterialSkin.Controls.MaterialButton();
            log_list = new MaterialSkin.Controls.MaterialListView();
            materialCard4 = new MaterialSkin.Controls.MaterialCard();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            user_tab = new TabPage();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            adminstatus_label = new MaterialSkin.Controls.MaterialLabel();
            logoff_button = new MaterialSkin.Controls.MaterialButton();
            user_label = new MaterialSkin.Controls.MaterialLabel();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            admin_tab = new TabPage();
            removeBook_button = new MaterialSkin.Controls.MaterialButton();
            materialCard2 = new MaterialSkin.Controls.MaterialCard();
            removeBook_label = new MaterialSkin.Controls.MaterialLabel();
            admin_list = new MaterialSkin.Controls.MaterialListView();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            autors = new MaterialSkin.Controls.MaterialTextBox();
            nosaukums = new MaterialSkin.Controls.MaterialTextBox();
            materialTabControl1.SuspendLayout();
            reservation_tab.SuspendLayout();
            materialCard3.SuspendLayout();
            log_tab.SuspendLayout();
            materialCard4.SuspendLayout();
            user_tab.SuspendLayout();
            materialCard1.SuspendLayout();
            admin_tab.SuspendLayout();
            materialCard2.SuspendLayout();
            SuspendLayout();
            // 
            // materialTabControl1
            // 
            materialTabControl1.Anchor = AnchorStyles.None;
            materialTabControl1.Controls.Add(reservation_tab);
            materialTabControl1.Controls.Add(log_tab);
            materialTabControl1.Controls.Add(user_tab);
            materialTabControl1.Controls.Add(admin_tab);
            materialTabControl1.Depth = 0;
            materialTabControl1.Location = new Point(-2, 67);
            materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            materialTabControl1.Multiline = true;
            materialTabControl1.Name = "materialTabControl1";
            materialTabControl1.SelectedIndex = 0;
            materialTabControl1.Size = new Size(939, 431);
            materialTabControl1.TabIndex = 0;
            // 
            // reservation_tab
            // 
            reservation_tab.Controls.Add(return_book_button);
            reservation_tab.Controls.Add(materialCard3);
            reservation_tab.Controls.Add(reservation_list);
            reservation_tab.ImageKey = "(none)";
            reservation_tab.Location = new Point(4, 32);
            reservation_tab.Name = "reservation_tab";
            reservation_tab.Padding = new Padding(3);
            reservation_tab.Size = new Size(931, 395);
            reservation_tab.TabIndex = 0;
            reservation_tab.Text = "Rezervācija";
            reservation_tab.UseVisualStyleBackColor = true;
            // 
            // return_book_button
            // 
            return_book_button.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            return_book_button.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            return_book_button.Depth = 0;
            return_book_button.HighEmphasis = true;
            return_book_button.Icon = null;
            return_book_button.Location = new Point(140, 142);
            return_book_button.Margin = new Padding(4, 6, 4, 6);
            return_book_button.MouseState = MaterialSkin.MouseState.HOVER;
            return_book_button.Name = "return_book_button";
            return_book_button.NoAccentTextColor = Color.Empty;
            return_book_button.Size = new Size(212, 36);
            return_book_button.TabIndex = 2;
            return_book_button.Text = "Vēlaties atdot grāmatu";
            return_book_button.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            return_book_button.UseAccentColor = false;
            return_book_button.UseVisualStyleBackColor = true;
            return_book_button.Click += return_book_button_Click;
            // 
            // materialCard3
            // 
            materialCard3.BackColor = Color.FromArgb(255, 255, 255);
            materialCard3.Controls.Add(materialLabel2);
            materialCard3.Depth = 0;
            materialCard3.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard3.Location = new Point(17, 22);
            materialCard3.Margin = new Padding(14);
            materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard3.Name = "materialCard3";
            materialCard3.Padding = new Padding(14);
            materialCard3.Size = new Size(335, 100);
            materialCard3.TabIndex = 1;
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(17, 14);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(303, 19);
            materialLabel2.TabIndex = 0;
            materialLabel2.Text = "Uzspiest uz grāmatas, ko vēlaties rezervēt!\r\n";
            // 
            // reservation_list
            // 
            reservation_list.AutoSizeTable = false;
            reservation_list.BackColor = Color.FromArgb(255, 255, 255);
            reservation_list.BorderStyle = BorderStyle.None;
            reservation_list.Depth = 0;
            reservation_list.FullRowSelect = true;
            reservation_list.Location = new Point(369, 22);
            reservation_list.MinimumSize = new Size(200, 100);
            reservation_list.MouseLocation = new Point(-1, -1);
            reservation_list.MouseState = MaterialSkin.MouseState.OUT;
            reservation_list.Name = "reservation_list";
            reservation_list.OwnerDraw = true;
            reservation_list.Size = new Size(481, 277);
            reservation_list.TabIndex = 0;
            reservation_list.UseCompatibleStateImageBehavior = false;
            reservation_list.View = View.Details;
            // 
            // log_tab
            // 
            log_tab.Controls.Add(return_book_button2);
            log_tab.Controls.Add(log_list);
            log_tab.Controls.Add(materialCard4);
            log_tab.ImageKey = "(none)";
            log_tab.Location = new Point(4, 32);
            log_tab.Name = "log_tab";
            log_tab.Padding = new Padding(3);
            log_tab.Size = new Size(931, 395);
            log_tab.TabIndex = 1;
            log_tab.Text = "Žurnāls";
            log_tab.UseVisualStyleBackColor = true;
            // 
            // return_book_button2
            // 
            return_book_button2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            return_book_button2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            return_book_button2.Depth = 0;
            return_book_button2.HighEmphasis = true;
            return_book_button2.Icon = null;
            return_book_button2.Location = new Point(17, 111);
            return_book_button2.Margin = new Padding(4, 6, 4, 6);
            return_book_button2.MouseState = MaterialSkin.MouseState.HOVER;
            return_book_button2.Name = "return_book_button2";
            return_book_button2.NoAccentTextColor = Color.Empty;
            return_book_button2.Size = new Size(212, 36);
            return_book_button2.TabIndex = 3;
            return_book_button2.Text = "Vēlaties atdot grāmatu";
            return_book_button2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            return_book_button2.UseAccentColor = false;
            return_book_button2.UseVisualStyleBackColor = true;
            // 
            // log_list
            // 
            log_list.AutoSizeTable = false;
            log_list.BackColor = Color.FromArgb(255, 255, 255);
            log_list.BorderStyle = BorderStyle.None;
            log_list.Depth = 0;
            log_list.FullRowSelect = true;
            log_list.Location = new Point(246, 14);
            log_list.MinimumSize = new Size(200, 100);
            log_list.MouseLocation = new Point(-1, -1);
            log_list.MouseState = MaterialSkin.MouseState.OUT;
            log_list.Name = "log_list";
            log_list.OwnerDraw = true;
            log_list.Size = new Size(632, 338);
            log_list.TabIndex = 2;
            log_list.UseCompatibleStateImageBehavior = false;
            log_list.View = View.Details;
            // 
            // materialCard4
            // 
            materialCard4.BackColor = Color.FromArgb(255, 255, 255);
            materialCard4.Controls.Add(materialLabel3);
            materialCard4.Depth = 0;
            materialCard4.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard4.Location = new Point(17, 14);
            materialCard4.Margin = new Padding(14);
            materialCard4.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard4.Name = "materialCard4";
            materialCard4.Padding = new Padding(14);
            materialCard4.Size = new Size(212, 77);
            materialCard4.TabIndex = 1;
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel3.Location = new Point(10, 14);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(149, 19);
            materialLabel3.TabIndex = 0;
            materialLabel3.Text = "Izsniegtās grāmatas.";
            // 
            // user_tab
            // 
            user_tab.Controls.Add(materialCard1);
            user_tab.Controls.Add(materialLabel1);
            user_tab.ImageKey = "(none)";
            user_tab.Location = new Point(4, 32);
            user_tab.Name = "user_tab";
            user_tab.Size = new Size(931, 395);
            user_tab.TabIndex = 2;
            user_tab.Text = "Lietotājs";
            user_tab.UseVisualStyleBackColor = true;
            // 
            // materialCard1
            // 
            materialCard1.Anchor = AnchorStyles.None;
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(adminstatus_label);
            materialCard1.Controls.Add(logoff_button);
            materialCard1.Controls.Add(user_label);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(276, 92);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(326, 181);
            materialCard1.TabIndex = 3;
            // 
            // adminstatus_label
            // 
            adminstatus_label.AutoSize = true;
            adminstatus_label.Depth = 0;
            adminstatus_label.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            adminstatus_label.Location = new Point(17, 47);
            adminstatus_label.MouseState = MaterialSkin.MouseState.HOVER;
            adminstatus_label.Name = "adminstatus_label";
            adminstatus_label.Size = new Size(107, 19);
            adminstatus_label.TabIndex = 3;
            adminstatus_label.Text = "materialLabel2";
            // 
            // logoff_button
            // 
            logoff_button.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            logoff_button.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            logoff_button.Depth = 0;
            logoff_button.HighEmphasis = true;
            logoff_button.Icon = null;
            logoff_button.Location = new Point(115, 95);
            logoff_button.Margin = new Padding(4, 6, 4, 6);
            logoff_button.MouseState = MaterialSkin.MouseState.HOVER;
            logoff_button.Name = "logoff_button";
            logoff_button.NoAccentTextColor = Color.Empty;
            logoff_button.Size = new Size(103, 36);
            logoff_button.TabIndex = 2;
            logoff_button.Text = "Izlogoties";
            logoff_button.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            logoff_button.UseAccentColor = false;
            logoff_button.UseVisualStyleBackColor = true;
            logoff_button.Click += logoff_button_Click;
            // 
            // user_label
            // 
            user_label.AutoSize = true;
            user_label.Depth = 0;
            user_label.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            user_label.Location = new Point(17, 14);
            user_label.MouseState = MaterialSkin.MouseState.HOVER;
            user_label.Name = "user_label";
            user_label.Size = new Size(107, 19);
            user_label.TabIndex = 1;
            user_label.Text = "materialLabel2";
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(448, 148);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(1, 0);
            materialLabel1.TabIndex = 0;
            // 
            // admin_tab
            // 
            admin_tab.Controls.Add(removeBook_button);
            admin_tab.Controls.Add(materialCard2);
            admin_tab.Controls.Add(admin_list);
            admin_tab.Controls.Add(materialButton1);
            admin_tab.Controls.Add(autors);
            admin_tab.Controls.Add(nosaukums);
            admin_tab.ImageKey = "(none)";
            admin_tab.Location = new Point(4, 32);
            admin_tab.Name = "admin_tab";
            admin_tab.Size = new Size(931, 395);
            admin_tab.TabIndex = 3;
            admin_tab.Text = "Admin access";
            admin_tab.UseVisualStyleBackColor = true;
            admin_tab.Visible = false;
            // 
            // removeBook_button
            // 
            removeBook_button.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            removeBook_button.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            removeBook_button.Depth = 0;
            removeBook_button.HighEmphasis = true;
            removeBook_button.Icon = null;
            removeBook_button.Location = new Point(246, 309);
            removeBook_button.Margin = new Padding(4, 6, 4, 6);
            removeBook_button.MouseState = MaterialSkin.MouseState.HOVER;
            removeBook_button.Name = "removeBook_button";
            removeBook_button.NoAccentTextColor = Color.Empty;
            removeBook_button.Size = new Size(156, 36);
            removeBook_button.TabIndex = 6;
            removeBook_button.Text = "Noņemt grāmatu";
            removeBook_button.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            removeBook_button.UseAccentColor = false;
            removeBook_button.UseVisualStyleBackColor = true;
            removeBook_button.Click += removeBook_button_Click;
            // 
            // materialCard2
            // 
            materialCard2.BackColor = Color.FromArgb(255, 255, 255);
            materialCard2.Controls.Add(removeBook_label);
            materialCard2.Depth = 0;
            materialCard2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard2.Location = new Point(38, 220);
            materialCard2.Margin = new Padding(14);
            materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard2.Name = "materialCard2";
            materialCard2.Padding = new Padding(14);
            materialCard2.Size = new Size(364, 69);
            materialCard2.TabIndex = 5;
            // 
            // removeBook_label
            // 
            removeBook_label.AutoSize = true;
            removeBook_label.Depth = 0;
            removeBook_label.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            removeBook_label.Location = new Point(13, 12);
            removeBook_label.MouseState = MaterialSkin.MouseState.HOVER;
            removeBook_label.Name = "removeBook_label";
            removeBook_label.Size = new Size(107, 19);
            removeBook_label.TabIndex = 0;
            removeBook_label.Text = "materialLabel2";
            // 
            // admin_list
            // 
            admin_list.Anchor = AnchorStyles.None;
            admin_list.AutoSizeTable = true;
            admin_list.BackColor = Color.FromArgb(255, 255, 255);
            admin_list.BorderStyle = BorderStyle.None;
            admin_list.Depth = 0;
            admin_list.FullRowSelect = true;
            admin_list.Location = new Point(441, 21);
            admin_list.MinimumSize = new Size(200, 100);
            admin_list.MouseLocation = new Point(-1, -1);
            admin_list.MouseState = MaterialSkin.MouseState.OUT;
            admin_list.Name = "admin_list";
            admin_list.OwnerDraw = true;
            admin_list.Scrollable = false;
            admin_list.Size = new Size(200, 100);
            admin_list.TabIndex = 4;
            admin_list.UseCompatibleStateImageBehavior = false;
            admin_list.View = View.Details;
            // 
            // materialButton1
            // 
            materialButton1.Anchor = AnchorStyles.None;
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(289, 151);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(113, 36);
            materialButton1.TabIndex = 3;
            materialButton1.Text = "Ievadīt info";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            materialButton1.Click += materialButton1_Click;
            // 
            // autors
            // 
            autors.Anchor = AnchorStyles.None;
            autors.AnimateReadOnly = false;
            autors.BorderStyle = BorderStyle.None;
            autors.Depth = 0;
            autors.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            autors.Hint = "Autors";
            autors.LeadingIcon = null;
            autors.Location = new Point(38, 92);
            autors.MaxLength = 50;
            autors.MouseState = MaterialSkin.MouseState.OUT;
            autors.Multiline = false;
            autors.Name = "autors";
            autors.Size = new Size(364, 50);
            autors.TabIndex = 2;
            autors.Text = "";
            autors.TrailingIcon = null;
            // 
            // nosaukums
            // 
            nosaukums.Anchor = AnchorStyles.None;
            nosaukums.AnimateReadOnly = false;
            nosaukums.BorderStyle = BorderStyle.None;
            nosaukums.Depth = 0;
            nosaukums.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            nosaukums.Hint = "Grāmatas nosaukums";
            nosaukums.LeadingIcon = null;
            nosaukums.Location = new Point(38, 21);
            nosaukums.MaxLength = 50;
            nosaukums.MouseState = MaterialSkin.MouseState.OUT;
            nosaukums.Multiline = false;
            nosaukums.Name = "nosaukums";
            nosaukums.Size = new Size(364, 50);
            nosaukums.TabIndex = 1;
            nosaukums.Text = "";
            nosaukums.TrailingIcon = null;
            // 
            // mainPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 504);
            Controls.Add(materialTabControl1);
            DrawerTabControl = materialTabControl1;
            Name = "mainPage";
            Load += mainPage_Load;
            materialTabControl1.ResumeLayout(false);
            reservation_tab.ResumeLayout(false);
            reservation_tab.PerformLayout();
            materialCard3.ResumeLayout(false);
            materialCard3.PerformLayout();
            log_tab.ResumeLayout(false);
            log_tab.PerformLayout();
            materialCard4.ResumeLayout(false);
            materialCard4.PerformLayout();
            user_tab.ResumeLayout(false);
            user_tab.PerformLayout();
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            admin_tab.ResumeLayout(false);
            admin_tab.PerformLayout();
            materialCard2.ResumeLayout(false);
            materialCard2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private TabPage reservation_tab;
        private TabPage log_tab;
        private TabPage user_tab;
        private TabPage admin_tab;
        private MaterialSkin.Controls.MaterialTextBox nosaukums;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialTextBox autors;
        private MaterialSkin.Controls.MaterialListView admin_list;
        private MaterialSkin.Controls.MaterialButton logoff_button;
        private MaterialSkin.Controls.MaterialLabel user_label;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel adminstatus_label;
        private MaterialSkin.Controls.MaterialListView reservation_list;
        private MaterialSkin.Controls.MaterialButton removeBook_button;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialLabel removeBook_label;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialCard materialCard4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialListView log_list;
        private MaterialSkin.Controls.MaterialButton return_book_button;
        private MaterialSkin.Controls.MaterialButton return_book_button2;
    }
}