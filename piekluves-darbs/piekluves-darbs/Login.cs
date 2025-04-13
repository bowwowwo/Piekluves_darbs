using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Data.SQLite;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Text;
using System.Security.Cryptography;
using System.Security.Policy;

namespace piekluves_darbs
{
    public partial class Login : MaterialForm
    {
        private string username = "";
        private string password = "";


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
            Application.Exit();
        }

        string databaseFilePath() //connect sqlite database to string
        {
            string exeDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string projectRootDirectory = Path.GetFullPath(Path.Combine(exeDirectory, @"..\..\..\..\"));
            string dbFilePath = Path.Combine(projectRootDirectory, "database", "main.db");

            string connectionString = @"data source =" + dbFilePath;

            return connectionString;
        }

        private void register_button_Click(object sender, EventArgs e) // register button
        {
            Register ShowForm_newUserForm = new Register(); //aizs?ta uz register form
            ShowForm_newUserForm.Show();

            this.Hide();
            this.Closed += (s, args) => Application.Exit();
        }

        private void login_button_Click(object sender, EventArgs e) // login button
        {
            username = username_button.Text;
            Global.global_username = username;
            password = pass_button.Text;

            try
            {
                if (String.IsNullOrEmpty(username))
                {
                    MessageBox.Show("Nav ievadīts lietotājvārds!");
                }
                else if (String.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Nav ievadīta parole!");
                }
                else
                {
                    string query = "SELECT COUNT(*) FROM Users WHERE username=@username AND password_hash=@password";

                    using (SQLiteConnection con = new SQLiteConnection(databaseFilePath()))
                    {
                        con.Open();
                        string password2 = HashPass(password);
                            using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                            {
                                cmd.Parameters.AddWithValue("@username", username);
                                cmd.Parameters.AddWithValue("@password", password2);

                                int count = Convert.ToInt32(cmd.ExecuteScalar());

                                if (count > 0)
                                {
                                            mainPage ShowMain = new mainPage();
                                            ShowMain.Show();


                                            pass_button.Text = pass_button.Text.Replace(password, "");
                                            this.Hide();
                                            this.Closed += (s, args) => Application.Exit();
                                }
                            else
                            {
                                MessageBox.Show("Nepareiza parole vai lietotājvārds.");
                            }
                            }
                        }
                    }

            }
            catch
            {
                MessageBox.Show("Radusies kļūda!");
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
        public string decryptPass(string encrypted)
        {
            return "";
        }
    }
}

public static class Global
{ // Modifiable
    public static String global_username = "";
}