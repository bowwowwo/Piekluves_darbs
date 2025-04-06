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
using System.Xml.Linq;
using System.Security.Cryptography;
using System.Security.Policy;

namespace piekluves_darbs
{
    public partial class Register : MaterialForm
    {

        private string username = "";
        private string email = "";
        private string password1 = "";
        private string password2 = "";
        private bool user;

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

        string databaseFilePath() //connect sqlite database to string
        {
            string exeDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string projectRootDirectory = Path.GetFullPath(Path.Combine(exeDirectory, @"..\..\..\..\"));
            string dbFilePath = Path.Combine(projectRootDirectory, "database", "main.db");

            string connectionString = @"data source =" + dbFilePath;

            return connectionString;
        }

        private void toLogin_button_Click(object sender, EventArgs e) //to login
        {
            Login ShowForm_LoginForm = new Login(); //aizsūta uz login form
            ShowForm_LoginForm.Show();

            this.Hide();
            this.Closed += (s, args) => Application.Exit();
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
                    MessageBox.Show("Nav ievadīts Lietotājvārds!");
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
                    using (SQLiteConnection con = new SQLiteConnection(databaseFilePath()))
                    {
                        con.Open();
                        string query = "INSERT INTO Users (username, email, password_hash) VALUES (@username, @email, @password)";
                        string userExistsQuery = "SELECT COUNT(*) FROM Users WHERE username = @username";

                        using (SQLiteCommand cmd = new SQLiteCommand(userExistsQuery, con))
                        {
                            cmd.Parameters.AddWithValue("@username", username);
                            int emailCount = Convert.ToInt32(cmd.ExecuteScalar());
                            user = emailCount != 0;
                        }

                        if (user)
                        {
                            MessageBox.Show("Lietotājvārds jau tiek izmantots!");
                        }
                        else
                        {
                            string password3 = HashPass(password1);
                            using (SQLiteCommand cmd2 = new SQLiteCommand(query, con))
                            {
                                cmd2.Parameters.AddWithValue("@username", username);
                                cmd2.Parameters.AddWithValue("@email", email);
                                cmd2.Parameters.AddWithValue("@password", password3);

                                int rowsAffected = cmd2.ExecuteNonQuery(); //

                                if (rowsAffected > 0)
                                {
                                    DialogResult result = MessageBox.Show("Veiksmīga pieteikšanās!", "Pieteikšanās", MessageBoxButtons.OK);

                                    if (result == DialogResult.OK)
                                    {
                                        Login loginform = new Login();
                                        loginform.Show();

                                        this.Hide();
                                        this.Closed += (s, args) => Application.Exit();

                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Atgadījusies kļūda!" + ex);
            }

        }
        public static string HashPass(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);
                byte[] hashBytes = sha256.ComputeHash(bytes);
                return Convert.ToBase64String(hashBytes);
            }
        }
        public bool userExists(string username) //checks if user exists
        {
            using (SQLiteConnection con = new SQLiteConnection(databaseFilePath()))
            {
                con.Open();
                string userExistsQuery = "SELECT COUNT(*) FROM Users WHERE username = @username";
                using (SQLiteCommand cmd = new SQLiteCommand(userExistsQuery, con))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    int emailCount = Convert.ToInt32(cmd.ExecuteScalar());
                    bool user = emailCount != 0;

                    return user;
                }
            }
        }
    }
}

