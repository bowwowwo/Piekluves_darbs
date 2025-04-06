namespace piekluves_darbs
{
    partial class Register
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
            name_Box = new MaterialSkin.Controls.MaterialTextBox();
            email_box = new MaterialSkin.Controls.MaterialTextBox();
            pass2_Box = new MaterialSkin.Controls.MaterialTextBox();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            register_button = new MaterialSkin.Controls.MaterialButton();
            toLogin_button = new MaterialSkin.Controls.MaterialButton();
            pass1_Box = new MaterialSkin.Controls.MaterialTextBox();
            SuspendLayout();
            // 
            // name_Box
            // 
            name_Box.Anchor = AnchorStyles.None;
            name_Box.AnimateReadOnly = false;
            name_Box.BorderStyle = BorderStyle.None;
            name_Box.Depth = 0;
            name_Box.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            name_Box.Hint = "Lietotājvārds";
            name_Box.LeadingIcon = null;
            name_Box.Location = new Point(43, 206);
            name_Box.MaxLength = 50;
            name_Box.MouseState = MaterialSkin.MouseState.OUT;
            name_Box.Multiline = false;
            name_Box.Name = "name_Box";
            name_Box.Size = new Size(182, 50);
            name_Box.TabIndex = 0;
            name_Box.Text = "";
            name_Box.TrailingIcon = null;
            // 
            // email_box
            // 
            email_box.Anchor = AnchorStyles.None;
            email_box.AnimateReadOnly = true;
            email_box.BorderStyle = BorderStyle.None;
            email_box.Depth = 0;
            email_box.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            email_box.Hint = "E-pasts";
            email_box.LeadingIcon = null;
            email_box.Location = new Point(265, 206);
            email_box.MaxLength = 50;
            email_box.MouseState = MaterialSkin.MouseState.OUT;
            email_box.Multiline = false;
            email_box.Name = "email_box";
            email_box.Size = new Size(182, 50);
            email_box.TabIndex = 1;
            email_box.Text = "";
            email_box.TrailingIcon = null;
            // 
            // pass2_Box
            // 
            pass2_Box.Anchor = AnchorStyles.None;
            pass2_Box.AnimateReadOnly = false;
            pass2_Box.BorderStyle = BorderStyle.None;
            pass2_Box.Depth = 0;
            pass2_Box.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            pass2_Box.Hint = "Atkārtot paroli";
            pass2_Box.LeadingIcon = null;
            pass2_Box.Location = new Point(265, 296);
            pass2_Box.MaxLength = 50;
            pass2_Box.MouseState = MaterialSkin.MouseState.OUT;
            pass2_Box.Multiline = false;
            pass2_Box.Name = "pass2_Box";
            pass2_Box.Password = true;
            pass2_Box.Size = new Size(182, 50);
            pass2_Box.TabIndex = 2;
            pass2_Box.Text = "";
            pass2_Box.TrailingIcon = null;
            // 
            // materialLabel1
            // 
            materialLabel1.Anchor = AnchorStyles.None;
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(183, 157);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(121, 19);
            materialLabel1.TabIndex = 3;
            materialLabel1.Text = "Jauns lietotājs/a";
            // 
            // register_button
            // 
            register_button.Anchor = AnchorStyles.None;
            register_button.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            register_button.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            register_button.Depth = 0;
            register_button.HighEmphasis = true;
            register_button.Icon = null;
            register_button.Location = new Point(230, 385);
            register_button.Margin = new Padding(4, 6, 4, 6);
            register_button.MouseState = MaterialSkin.MouseState.HOVER;
            register_button.Name = "register_button";
            register_button.NoAccentTextColor = Color.Empty;
            register_button.Size = new Size(217, 36);
            register_button.TabIndex = 4;
            register_button.Text = "Izveidot jaunu lietotāju";
            register_button.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            register_button.UseAccentColor = false;
            register_button.UseVisualStyleBackColor = true;
            register_button.Click += register_button_Click;
            // 
            // toLogin_button
            // 
            toLogin_button.Anchor = AnchorStyles.None;
            toLogin_button.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            toLogin_button.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            toLogin_button.Depth = 0;
            toLogin_button.HighEmphasis = true;
            toLogin_button.Icon = null;
            toLogin_button.Location = new Point(43, 90);
            toLogin_button.Margin = new Padding(4, 6, 4, 6);
            toLogin_button.MouseState = MaterialSkin.MouseState.HOVER;
            toLogin_button.Name = "toLogin_button";
            toLogin_button.NoAccentTextColor = Color.Empty;
            toLogin_button.Size = new Size(140, 36);
            toLogin_button.TabIndex = 5;
            toLogin_button.Text = "Doties atpakaļ";
            toLogin_button.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            toLogin_button.UseAccentColor = false;
            toLogin_button.UseVisualStyleBackColor = true;
            toLogin_button.Click += toLogin_button_Click;
            // 
            // pass1_Box
            // 
            pass1_Box.Anchor = AnchorStyles.None;
            pass1_Box.AnimateReadOnly = false;
            pass1_Box.BorderStyle = BorderStyle.None;
            pass1_Box.Depth = 0;
            pass1_Box.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            pass1_Box.Hint = "Parole";
            pass1_Box.LeadingIcon = null;
            pass1_Box.Location = new Point(43, 296);
            pass1_Box.MaxLength = 50;
            pass1_Box.MouseState = MaterialSkin.MouseState.OUT;
            pass1_Box.Multiline = false;
            pass1_Box.Name = "pass1_Box";
            pass1_Box.Password = true;
            pass1_Box.Size = new Size(182, 50);
            pass1_Box.TabIndex = 6;
            pass1_Box.Text = "";
            pass1_Box.TrailingIcon = null;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(492, 519);
            Controls.Add(pass1_Box);
            Controls.Add(toLogin_button);
            Controls.Add(register_button);
            Controls.Add(materialLabel1);
            Controls.Add(pass2_Box);
            Controls.Add(email_box);
            Controls.Add(name_Box);
            Name = "Register";
            Text = "Piereģistrēties";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox name_Box;
        private MaterialSkin.Controls.MaterialTextBox email_box;
        private MaterialSkin.Controls.MaterialTextBox pass2_Box;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton register_button;
        private MaterialSkin.Controls.MaterialButton toLogin_button;
        private MaterialSkin.Controls.MaterialTextBox pass1_Box;
    }
}