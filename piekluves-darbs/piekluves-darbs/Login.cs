using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Data.SQLite;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Text;
using System.Security.Cryptography;
using System.Security.Policy;
using piekluves_darbs;

namespace piekluves_darbs
{
    public partial class Login : MaterialForm
    {
        private string username = ""; // mainigais tiek velak izmantots lietotajvards glabasanai
        private string password = ""; // mainigais tiek velak izmantots paroles glabasanai


        public Login()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance; // material skin bibliotēkas definicija
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Amber800, Primary.Amber900, Primary.Amber500, Accent.LightBlue200, TextShade.WHITE);

            if (Global.loginCount > 0) // parbauda vai ir lietotajs ir ielogojies ieprieks // beigt sesiju funkcijas darbibas del
            {
                mainPage mainPageInstance = Application.OpenForms.OfType<mainPage>().FirstOrDefault();
                mainPageInstance.Close();
                mainPageInstance = null;
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e) //darbibas kas tiek veiktas nospiezot "X"
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
            username = username_button.Text; // ievada datus mainigajos
            Global.global_username = username;
            password = pass_button.Text;


            try //prbauda vai dati ir ievaditi
            {
                if (String.IsNullOrEmpty(username)) 
                {
                    MessageBox.Show("Nav ievadīts lietotājvārds!");
                }
                else if (String.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Nav ievadīta parole!");
                }
                else //parbauda vai lietotajs ir datubaze
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

                                if (count > 0) // ja lietotajs ir datubaze lauj pieklut main page
                                {
                                                                          
                                            mainPage ShowMain = new mainPage(); //main page pieklusana
                                            MainPageManager.CurrentInstance = ShowMain;
                                            ShowMain.Show();
                                            
                                            Global.loginCount++; //beigt sesiju funkcijas darbibai

                                            pass_button.Text = pass_button.Text.Replace(password, "");  //notira paroli no mainiga
                                            this.Hide(); // slepj so lapu
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

        public static string HashPass(string password)//si metode parveido paroli uz sha256 šifru
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);
                byte[] hashBytes = sha256.ComputeHash(bytes);
                return Convert.ToBase64String(hashBytes);
            }
        }
        public string decryptPass(string encrypted)  //parbauda vai paroles hash ir pareizs 
        {
            return "";
        }
    }
}

public static class Global //lietotajvarda un login reižu globalai glabasanai
{ // Modifiable
    public static String global_username = "";
    public static int loginCount;
}

public static class MainPageManager //main page instances manager, lai varetu globali izmantot main page metodes un funkcionalitati
{
    public static mainPage CurrentInstance { get; set; }
}