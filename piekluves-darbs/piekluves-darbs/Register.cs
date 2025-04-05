using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Data.SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace piekluves_darbs
{
    public partial class Register : MaterialForm
    {

        private string username = "";
        private string email = "";
        private string password1 = "";
        private string password2 = "";

        public Register()
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

        private void toLogin_button_Click(object sender, EventArgs e) //to login
        {
            Login ShowForm_LoginForm = new Login(); //aizsūta uz login form
            ShowForm_LoginForm.Show();

            this.Hide();
        }

        private void register_button_Click(object sender, EventArgs e) //"izveidot jaunu lietotāju"
        {
            username = name_Box.Text;
            email = email_box.Text;
            password1 = pass1_Box.Text;
            password2 = pass2_Box.Text;

            try // pārbauda iespējamās kļūdas
            {
                if (String.IsNullOrEmpty(username))
                {
                    MessageBox.Show("Nav ievadīts vārds!");
                }
                else if (String.IsNullOrEmpty(email) | !email.Contains("@"))
                {
                    MessageBox.Show("Nav ievadīts e-pasts!");
                }
                else if (String.IsNullOrEmpty(password1))
                {
                    MessageBox.Show("Nav ievadīta parole!");
                }
                else if (String.IsNullOrEmpty(password2))
                {
                    MessageBox.Show("Nav atkārtota parole!");
                }
                else if(password1.Length < 6)
                {
                    MessageBox.Show("Parolei jābūt vismaz 6 rakstzīmes garai!");
                }
                else if(password1 != password2)
                {
                    MessageBox.Show("Parolēm jābūt vienādām!");
                }
                else
                {
                    //
                }
            }
            catch
            {
                MessageBox.Show("Atgadījusies kļūda!");
            }

        }
    }
}
