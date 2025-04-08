using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace piekluves_darbs
{
    public partial class ReturnForm : MaterialForm
    {
        private mainPage _mainPageInstance;

        public ReturnForm(mainPage mainPageInstance)
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Amber800, Primary.Amber900, Primary.Amber500, Accent.LightBlue200, TextShade.WHITE);

            _mainPageInstance = mainPageInstance;

            string query = "SELECT book_ID FROM Reservations WHERE user_username=@username";
            string query2 = "SELECT title FROM Books WHERE ID=@id";

            using (SQLiteConnection con = new SQLiteConnection(databaseFilePath()))
            {
                using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                {
                    con.Open();

                    cmd.Parameters.AddWithValue("@username", Global.global_username);

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int bookID = Convert.ToInt32(reader["book_ID"]);

                            using (SQLiteCommand cmd2 = new SQLiteCommand(query2, con))
                            {
                                using (SQLiteDataReader reader2 = cmd2.ExecuteReader()) //! ERROR
                                {
                                    while (reader2.Read())
                                    {
                                        string bookTitle = reader2["title"].ToString();

                                        book_combobox.Items.Add(bookTitle);
                                    }
                                }
                            }
                        }
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

        //--------------------------------------------------------------------------------------------------

        private void LoadAllLists()
        {
            _mainPageInstance.InitializeReservationListView();
            _mainPageInstance.LoadMainBooks();
            //--------------------------------
            _mainPageInstance.InitializeLogListView();
            _mainPageInstance.LoadLog();
        }
    }
}
