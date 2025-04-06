using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace piekluves_darbs
{
    public partial class mainPage : MaterialForm
    {

        //string username = Global.global_username;
        private TabPage _savedTabPage;

        private string book = "";
        private string author = "";


        public mainPage()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Amber800, Primary.Amber900, Primary.Amber500, Accent.LightBlue200, TextShade.WHITE);

            string username = string.Empty;
            HideAdminTab();

            using (SQLiteConnection con = new SQLiteConnection(databaseFilePath()))
            {
                string adminQuery = "SELECT admin FROM Users WHERE username=@username";
                con.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(adminQuery, con))
                {
                    cmd.Parameters.AddWithValue("@username", Global.global_username);
                    var result = cmd.ExecuteScalar();
                    bool isAdmin = Convert.ToBoolean(result);
                    //MessageBox.Show(result.ToString());
                    if (isAdmin == true)
                    {
                        ShowAdminTab();
                    }
                }
            }
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

        private void HideAdminTab() //removes tab
        {
            _savedTabPage = admin_tab; // keep reference
            materialTabControl1.TabPages.Remove(admin_tab);
        }

        private void ShowAdminTab() //show admin tab
        {
            if (_savedTabPage != null && !materialTabControl1.TabPages.Contains(_savedTabPage))
            {
                materialTabControl1.TabPages.Add(_savedTabPage);
            }
        }
        private void AddAdminListView(MaterialListView listView) //a
        {
            string query = "SELECT ID, title, isReserved FROM Books";


            try
            {
                using (SqlConnection con = new SqlConnection(databaseFilePath()))
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        //item.SubItems.Add(reader["title"].ToString());
                        //item.SubItems.Add(reader["isReserved"].ToString());


                    }
                }
            }
            catch
            {
                MessageBox.Show("Atgadījusies kļūda");
            }
        }

        private bool AddBook(string book, string author)
        {
            string query = "INSERT INTO Books (title, author) VALUES (@book, @author)";

            using (SqlConnection con = new SqlConnection(databaseFilePath()))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                con.Open();

                cmd.Parameters.AddWithValue("@book", book);
                cmd.Parameters.AddWithValue("@author", author);

                try
                {
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0; // returns true
                }
                catch
                {
                    MessageBox.Show("Atgadījusies kļūda!");
                    return false;
                }
            }
        }
           
        private void fetchBookInfo()
        {

        }

        //--------------------------------------------------------------------------------------------------

        private void mainPage_Load(object sender, EventArgs e)
        {
            
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            book = nosaukums.Text;
            author = autors.Text;

            bool success = AddBook(book, author);

            if (success)
            {
                MessageBox.Show("Grāmata pievienota");
                
            }
            else
                MessageBox.Show("Neizdevās pievienot grāmatu.");
        }
    }
}
