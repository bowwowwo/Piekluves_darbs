using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Data.SQLite;

namespace piekluves_darbs
{
    public partial class Login : MaterialForm
    {
        public Login()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Amber800, Primary.Amber900, Primary.Amber500, Accent.LightBlue200, TextShade.WHITE);


        }

        protected override void OnFormClosing(FormClosingEventArgs e) //make it close
        {
            e.Cancel = false;
            base.OnFormClosing(e);
        }

        private void register_button_Click(object sender, EventArgs e) // register button
        {
            Register ShowForm_newUserForm = new Register(); //aizs?ta uz register form
            ShowForm_newUserForm.Show();

            this.Hide();
        }

        private void login_button_Click(object sender, EventArgs e) // login button
        {

        }
    }
}
