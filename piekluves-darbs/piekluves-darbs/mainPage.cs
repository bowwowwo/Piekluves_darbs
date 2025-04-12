using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Diagnostics;
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

            removeBook_label.Text = "Izvēlēties grāmatu, kuru izdzēst.";

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
                        adminstatus_label.Text = "Esat admins";
                    }
                    else
                    {
                        adminstatus_label.Text = "Neesat admins";
                    }
                }
                user_label.Text = $"Esat ielogojies, kā {Global.global_username}";

            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e) //make it close
        {
            e.Cancel = false;
            base.OnFormClosing(e);
            Process.GetCurrentProcess().Kill();
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

        private void InitializeAdminListView()
        {
            // Set the view to show details.
            admin_list.View = View.Details;
            admin_list.FullRowSelect = true;
            admin_list.GridLines = false;
            admin_list.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            admin_list.Scrollable = true;

            // Define columns (adjust width as necessary)
            admin_list.Columns.Add("ID", 50, HorizontalAlignment.Left);
            admin_list.Columns.Add("Title", 250, HorizontalAlignment.Left);
            admin_list.Columns.Add("Reserved", 100, HorizontalAlignment.Left);
        }

        public void LoadAdminBooks()
        {
            admin_list.Items.Clear();

            string query = "SELECT ID, title, isReserved FROM Books";

            using (SQLiteConnection con = new SQLiteConnection(databaseFilePath()))
            using (SQLiteCommand cmd = new SQLiteCommand(query, con))
            {
                con.Open();

                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader["ID"].ToString());

                        item.SubItems.Add(reader["title"].ToString());
                        item.SubItems.Add(reader["isReserved"].ToString());

                        admin_list.Items.Add(item);
                    }
                }
            }
        }


        private bool AddBook(string book, string author)
        {
            string query = "INSERT INTO Books (title, author) VALUES (@book, @author)";

            using (SQLiteConnection con = new SQLiteConnection(databaseFilePath()))
            {
                using (SQLiteCommand cmd = new SQLiteCommand(query, con))
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
        }

        public void InitializeReservationListView()
        {
            reservation_list.View = View.Details;
            reservation_list.FullRowSelect = true;
            reservation_list.GridLines = false;
            reservation_list.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            reservation_list.Scrollable = true;

            reservation_list.Columns.Add("ID", 50, HorizontalAlignment.Left);
            reservation_list.Columns.Add("Nosaukums", 250, HorizontalAlignment.Left);
            reservation_list.Columns.Add("Autors", 250, HorizontalAlignment.Left);
            reservation_list.Columns.Add("Rezervēts", 100, HorizontalAlignment.Left);
        }

        public void LoadMainBooks()
        {
            reservation_list.Items.Clear();

            string query = "SELECT ID, title, author, isReserved FROM Books";

            using (SQLiteConnection con = new SQLiteConnection(databaseFilePath()))
            using (SQLiteCommand cmd = new SQLiteCommand(query, con))
            {
                con.Open();

                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader["ID"].ToString());

                        item.SubItems.Add(reader["title"].ToString());
                        item.SubItems.Add(reader["author"].ToString());
                        item.SubItems.Add(reader["isReserved"].ToString());


                        reservation_list.Items.Add(item);
                    }
                }
            }
        }

        public void InitializeLogListView()
        {
            log_list.View = View.Details;
            log_list.FullRowSelect = true;
            log_list.GridLines = true;
            log_list.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            log_list.Scrollable = true;

            log_list.Columns.Add("I_ID", 55, HorizontalAlignment.Left);
            log_list.Columns.Add("Lietotājs", 140, HorizontalAlignment.Left);
            log_list.Columns.Add("Grāmata", 180, HorizontalAlignment.Left);
            log_list.Columns.Add("Rezervēta", 110, HorizontalAlignment.Left);
            log_list.Columns.Add("Atdota", 110, HorizontalAlignment.Left);
        }

        public void LoadLog()
        {
            log_list.Items.Clear();

            string query = "SELECT ID, user_username, book_ID, reserved_at, returned_at FROM Returns";

            using (SQLiteConnection con = new SQLiteConnection(databaseFilePath()))
            using (SQLiteCommand cmd = new SQLiteCommand(query, con))
            {
                con.Open();

                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader["ID"].ToString());

                        item.SubItems.Add(reader["user_username"].ToString());
                        item.SubItems.Add(reader["book_ID"].ToString());
                        item.SubItems.Add(reader["reserved_at"].ToString());
                        item.SubItems.Add(reader["returned_at"].ToString());


                        log_list.Items.Add(item);
                    }
                }
            }
        }

        //--------------------------------------------------------------------------------------------------

        private void mainPage_Load(object sender, EventArgs e) //ielade listview on load
        {
            //--------------------------------
            InitializeAdminListView();
            LoadAdminBooks();
            //--------------------------------
            InitializeReservationListView();
            LoadMainBooks();
            //--------------------------------
            InitializeLogListView();
            LoadLog();
            //--------------------------------

            admin_list.SelectedIndexChanged += admin_list_SelectedIndexChanged;
            reservation_list.SelectedIndexChanged += reservation_list_SelectedIndexChanged;
        }

        private void materialButton1_Click(object sender, EventArgs e) //pievienot grāmatu admin lapa
        {
            book = nosaukums.Text;
            author = autors.Text;

            if (String.IsNullOrEmpty(book))
            {
                MessageBox.Show("Nav ievadīts nosaukums!");
            }
            else if (String.IsNullOrEmpty(author))
            {
                MessageBox.Show("Nav ievadīts nosaukums!");
            }
            else
            {
                bool success = AddBook(book, author);

                if (success)
                {
                    MessageBox.Show("Grāmata pievienota");

                }
                else
                    MessageBox.Show("Neizdevās pievienot grāmatu.");

                LoadAdminBooks();
                LoadMainBooks();
            }
        }

        private void logoff_button_Click(object sender, EventArgs e) //log off button profile tab
        {

            Global.global_username = "";


            Login LoginInstance = Application.OpenForms
                             .OfType<Login>()
                             .FirstOrDefault();

            LoginInstance.Show();

            this.Hide();
            this.Closed += (s, args) => Application.Exit();

        }

        private void admin_list_SelectedIndexChanged(object sender, EventArgs e) // ja uzspiez uz listview admin lapa
        {
            if (admin_list.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = admin_list.SelectedItems[0];
                string id = selectedItem.SubItems[0].Text;
                //string title = selectedItem.SubItems[1].Text;

                BookID.deleteID = int.Parse(id);

                removeBook_label.Text = $"Noņemt grāmatu ID: {id}";
            }
        }

        private void reservation_list_SelectedIndexChanged(object sender, EventArgs e) //ja uzspiez uz listview rezervacijas lapa
        {
            if (reservation_list.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = reservation_list.SelectedItems[0];
                string id = selectedItem.SubItems[0].Text;

                int number = int.Parse(id);
                BookID.ID = number;

                if (selectedItem.SubItems[3].Text == "0")
                {
                    mainPage mainPageInstance = Application.OpenForms
                             .OfType<mainPage>()
                             .FirstOrDefault();  //creates an instance so functions from this form can be called

                    BookPopUp ShowPopUp = new BookPopUp(mainPageInstance);
                    ShowPopUp.Show();
                }
                else
                {
                    MessageBox.Show("Grāmata jau ir rezervēta!");
                }
            }
        }

        private void removeBook_button_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM Books WHERE ID=@id";

            using (SQLiteConnection con = new SQLiteConnection(databaseFilePath()))
            {
                using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                {
                    con.Open();

                    cmd.Parameters.AddWithValue("@AtslegasID", BookID.deleteID);
                    cmd.ExecuteNonQuery();

                }
            }

            MessageBox.Show("Grāmata tika noņemta no datubāzes!");

            LoadAdminBooks();
            LoadMainBooks();

        }

        private void return_book_button_Click(object sender, EventArgs e) //
        {
            mainPage mainPageInstance = Application.OpenForms
                    .OfType<mainPage>()
                    .FirstOrDefault(); //creates an instance so functions from this form can be called

            ReturnForm ShowReturnForm = new ReturnForm(mainPageInstance);
            ShowReturnForm.Show();

        }
    }
}

public static class BookID
{ // Modifiable
    public static int ID;
    public static int deleteID;
}