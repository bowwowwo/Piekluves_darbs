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

        public ReturnForm()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Amber800, Primary.Amber900, Primary.Amber500, Accent.LightBlue200, TextShade.WHITE);


            string query = "SELECT book_ID FROM Reservations WHERE user_username=@username";
            string query2 = "SELECT title FROM Books WHERE isReserved=1 AND ID=@id";

            using (SQLiteConnection con = new SQLiteConnection(databaseFilePath())) //sekojosais kods iegust lietotaja rezervetas gramatas
            {
                con.Open();

                //get the bookID
                using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@username", Global.global_username);


                    int bookID = -1;
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read()) //izmantots while gadijuma ja lietotajs ir aiznemies vairakas gramatas
                        {
                            // Read the bookID from the first table
                            bookID = Convert.ToInt32(reader["book_ID"]);
                            I_ID.ID = bookID;

                            if (bookID > 0)
                            {
                                //get more info from another table
                                using (SQLiteCommand cmd2 = new SQLiteCommand(query2, con))
                                {
                                    cmd2.Parameters.AddWithValue("@id", bookID);

                                    using (SQLiteDataReader reader2 = cmd2.ExecuteReader())
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

        private void LoadAllLists() //atsvaidzina main page sarakstus
        {
            MainPageManager.CurrentInstance.LoadMainBooks();
            //--------------------------------
            MainPageManager.CurrentInstance.LoadLog();
            //--------------------------------
            MainPageManager.CurrentInstance.LoadAdminBooks();
        }

        private void return_book_button_Click(object sender, EventArgs e) //nodot gramatu poga
        {

            try
            {
                if (book_combobox.SelectedItem == null)
                {
                    MessageBox.Show("Nav izvēlēta grāmata!");
                }
                else //ievieto info datubaze par nodosanu
                {
                    DateTime current_time = DateTime.Now;

                    string query = "UPDATE Books SET isReserved = 0 WHERE id = @id"; //atsvaidzina gramatas statusu

                    using (SQLiteConnection con = new SQLiteConnection(databaseFilePath()))
                    {
                        con.Open();
                        using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@id", I_ID.ID);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    string deleteQuery = "DELETE FROM Reservations WHERE book_ID=@id"; //izdzes no rezervaciju tabulas datubaze

                    using (SQLiteConnection con = new SQLiteConnection(databaseFilePath()))
                    {
                        con.Open();
                        using (SQLiteCommand cmd = new SQLiteCommand(deleteQuery, con))
                        {
                            cmd.Parameters.AddWithValue("@id", I_ID.ID);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    string query2 = "INSERT INTO Returns (user_username, book_ID, returned_at) VALUES (@user, @book, @at)"; //ievieto zurnala tabula datubaze info

                    using (SQLiteConnection con = new SQLiteConnection(databaseFilePath()))
                    {
                        using (SQLiteCommand cmd = new SQLiteCommand(query2, con))
                        {
                            con.Open();

                            cmd.Parameters.AddWithValue("@user", Global.global_username);
                            cmd.Parameters.AddWithValue("@book", I_ID.ID);
                            cmd.Parameters.AddWithValue("@at", current_time.ToString("dd/MM/yyyy"));

                            cmd.ExecuteNonQuery();

                        }
                    }

                    MessageBox.Show("Grāmata nodota :)");
                    //---------------------------------------
                    LoadAllLists();
                    //---------------------------------------
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Atgadījusies kļuda!");
            }

        }
    }
}

public static class I_ID //mainigais globalai lietosanai
{ // Modifiable
    public static int ID;
}