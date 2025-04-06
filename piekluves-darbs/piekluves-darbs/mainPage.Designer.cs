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
            log_tab = new TabPage();
            user_tab = new TabPage();
            admin_tab = new TabPage();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            autors = new MaterialSkin.Controls.MaterialTextBox();
            nosaukums = new MaterialSkin.Controls.MaterialTextBox();
            imageList1 = new ImageList(components);
            listView = new MaterialSkin.Controls.MaterialListView();
            materialTabControl1.SuspendLayout();
            admin_tab.SuspendLayout();
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
            materialTabControl1.ImageList = imageList1;
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
            reservation_tab.ImageKey = "icons8-book-50.png";
            reservation_tab.Location = new Point(4, 32);
            reservation_tab.Name = "reservation_tab";
            reservation_tab.Padding = new Padding(3);
            reservation_tab.Size = new Size(931, 395);
            reservation_tab.TabIndex = 0;
            reservation_tab.Text = "Grāmatu rezervācija";
            reservation_tab.UseVisualStyleBackColor = true;
            // 
            // log_tab
            // 
            log_tab.ImageKey = "icons8-log-50.png";
            log_tab.Location = new Point(4, 32);
            log_tab.Name = "log_tab";
            log_tab.Padding = new Padding(3);
            log_tab.Size = new Size(931, 395);
            log_tab.TabIndex = 1;
            log_tab.Text = "Izsniegšana";
            log_tab.UseVisualStyleBackColor = true;
            // 
            // user_tab
            // 
            user_tab.ImageKey = "icons8-user-50.png";
            user_tab.Location = new Point(4, 32);
            user_tab.Name = "user_tab";
            user_tab.Size = new Size(931, 395);
            user_tab.TabIndex = 2;
            user_tab.Text = "Lietotājs";
            user_tab.UseVisualStyleBackColor = true;
            // 
            // admin_tab
            // 
            admin_tab.Controls.Add(listView);
            admin_tab.Controls.Add(materialButton1);
            admin_tab.Controls.Add(autors);
            admin_tab.Controls.Add(nosaukums);
            admin_tab.Location = new Point(4, 32);
            admin_tab.Name = "admin_tab";
            admin_tab.Size = new Size(931, 395);
            admin_tab.TabIndex = 3;
            admin_tab.Text = "Admin access";
            admin_tab.UseVisualStyleBackColor = true;
            admin_tab.Visible = false;
            // 
            // materialButton1
            // 
            materialButton1.Anchor = AnchorStyles.None;
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(217, 165);
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
            autors.Location = new Point(38, 91);
            autors.MaxLength = 50;
            autors.MouseState = MaterialSkin.MouseState.OUT;
            autors.Multiline = false;
            autors.Name = "autors";
            autors.Size = new Size(292, 50);
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
            nosaukums.Size = new Size(292, 50);
            nosaukums.TabIndex = 1;
            nosaukums.Text = "";
            nosaukums.TrailingIcon = null;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "icons8-book-50.png");
            imageList1.Images.SetKeyName(1, "icons8-user-50.png");
            imageList1.Images.SetKeyName(2, "icons8-log-50.png");
            // 
            // listView
            // 
            listView.Anchor = AnchorStyles.None;
            listView.AutoSizeTable = true;
            listView.BackColor = Color.FromArgb(255, 255, 255);
            listView.BorderStyle = BorderStyle.None;
            listView.Depth = 0;
            listView.FullRowSelect = true;
            listView.Location = new Point(353, 21);
            listView.MinimumSize = new Size(200, 100);
            listView.MouseLocation = new Point(-1, -1);
            listView.MouseState = MaterialSkin.MouseState.OUT;
            listView.Name = "listView";
            listView.OwnerDraw = true;
            listView.Scrollable = false;
            listView.Size = new Size(200, 100);
            listView.TabIndex = 4;
            listView.UseCompatibleStateImageBehavior = false;
            listView.UseWaitCursor = true;
            listView.View = View.Details;
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
            admin_tab.ResumeLayout(false);
            admin_tab.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private TabPage reservation_tab;
        private TabPage log_tab;
        private ImageList imageList1;
        private TabPage user_tab;
        private TabPage admin_tab;
        private MaterialSkin.Controls.MaterialTextBox nosaukums;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialTextBox autors;
        private MaterialSkin.Controls.MaterialListView listView;
    }
}