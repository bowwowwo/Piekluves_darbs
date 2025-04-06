namespace piekluves_darbs
{
    partial class Login
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
            username_button = new MaterialSkin.Controls.MaterialTextBox();
            greeting = new MaterialSkin.Controls.MaterialLabel();
            pass_button = new MaterialSkin.Controls.MaterialTextBox();
            register_button = new MaterialSkin.Controls.MaterialButton();
            login_button = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // username_button
            // 
            username_button.Anchor = AnchorStyles.None;
            username_button.AnimateReadOnly = false;
            username_button.BorderStyle = BorderStyle.None;
            username_button.Depth = 0;
            username_button.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            username_button.Hint = "Lietotājvārds";
            username_button.LeadingIcon = null;
            username_button.Location = new Point(127, 128);
            username_button.MaxLength = 50;
            username_button.MouseState = MaterialSkin.MouseState.OUT;
            username_button.Multiline = false;
            username_button.Name = "username_button";
            username_button.Size = new Size(208, 50);
            username_button.TabIndex = 0;
            username_button.Text = "";
            username_button.TrailingIcon = null;
            // 
            // greeting
            // 
            greeting.Anchor = AnchorStyles.None;
            greeting.AutoSize = true;
            greeting.Depth = 0;
            greeting.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            greeting.Location = new Point(185, 84);
            greeting.MouseState = MaterialSkin.MouseState.HOVER;
            greeting.Name = "greeting";
            greeting.Size = new Size(78, 19);
            greeting.TabIndex = 1;
            greeting.Text = "Sveicināts!";
            // 
            // pass_button
            // 
            pass_button.Anchor = AnchorStyles.None;
            pass_button.AnimateReadOnly = false;
            pass_button.BorderStyle = BorderStyle.None;
            pass_button.Depth = 0;
            pass_button.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            pass_button.Hint = "Parole";
            pass_button.LeadingIcon = null;
            pass_button.Location = new Point(127, 203);
            pass_button.MaxLength = 50;
            pass_button.MouseState = MaterialSkin.MouseState.OUT;
            pass_button.Multiline = false;
            pass_button.Name = "pass_button";
            pass_button.Password = true;
            pass_button.Size = new Size(208, 50);
            pass_button.TabIndex = 2;
            pass_button.Text = "";
            pass_button.TrailingIcon = null;
            // 
            // register_button
            // 
            register_button.Anchor = AnchorStyles.None;
            register_button.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            register_button.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            register_button.Depth = 0;
            register_button.HighEmphasis = true;
            register_button.Icon = null;
            register_button.Location = new Point(127, 273);
            register_button.Margin = new Padding(4, 6, 4, 6);
            register_button.MouseState = MaterialSkin.MouseState.HOVER;
            register_button.Name = "register_button";
            register_button.NoAccentTextColor = Color.Empty;
            register_button.Size = new Size(119, 36);
            register_button.TabIndex = 3;
            register_button.Text = "Reģistrēties";
            register_button.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            register_button.UseAccentColor = false;
            register_button.UseVisualStyleBackColor = true;
            register_button.Click += register_button_Click;
            // 
            // login_button
            // 
            login_button.Anchor = AnchorStyles.None;
            login_button.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            login_button.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            login_button.Depth = 0;
            login_button.HighEmphasis = true;
            login_button.Icon = null;
            login_button.Location = new Point(263, 273);
            login_button.Margin = new Padding(4, 6, 4, 6);
            login_button.MouseState = MaterialSkin.MouseState.HOVER;
            login_button.Name = "login_button";
            login_button.NoAccentTextColor = Color.Empty;
            login_button.Size = new Size(72, 36);
            login_button.TabIndex = 4;
            login_button.Text = "Ienākt";
            login_button.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            login_button.UseAccentColor = false;
            login_button.UseVisualStyleBackColor = true;
            login_button.Click += login_button_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(471, 410);
            Controls.Add(login_button);
            Controls.Add(register_button);
            Controls.Add(pass_button);
            Controls.Add(greeting);
            Controls.Add(username_button);
            Name = "Login";
            Text = "Ielogošanās";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox username_button;
        private MaterialSkin.Controls.MaterialLabel greeting;
        private MaterialSkin.Controls.MaterialTextBox pass_button;
        private MaterialSkin.Controls.MaterialButton register_button;
        private MaterialSkin.Controls.MaterialButton login_button;
    }
}
