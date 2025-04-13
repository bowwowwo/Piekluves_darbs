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
using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace piekluves_darbs
{
    public partial class BookPopUp : MaterialForm
    {

        //private mainPage _mainPageInstance;

        public BookPopUp()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Amber800, Primary.Amber900, Primary.Amber500, Accent.LightBlue200, TextShade.WHITE);

            //_mainPageInstance = mainPageInstance;

            using (SQLiteConnection con = new SQLiteConnection(databaseFilePath()))
            {
                string query = "SELECT title, author, description FROM Books WHERE id=@id";

                using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                {
                    con.Open();

                    cmd.Parameters.AddWithValue("@id", BookID.ID);

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            BookTitle.Text = (reader["title"].ToString());
                            BookAuthor.Text = (reader["author"].ToString());
                            description_box.Text = (reader["description"].ToString());
                        }
                    }
                }
            }

            LoadBookDataAsync();
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

        //----------------------------------------------------------------------------------------------------

        private void LoadAllLists()
        {
            MainPageManager.CurrentInstance.LoadMainBooks();
            //--------------------------------
            MainPageManager.CurrentInstance.LoadLog();
            //--------------------------------
            MainPageManager.CurrentInstance.LoadAdminBooks();
        }

        //-----------------------------------------------------------------------------------------------------

        private async void LoadBookDataAsync()
        {
            string title = "";
            string author = "";
            string description = "";

            using (SQLiteConnection con = new SQLiteConnection(databaseFilePath()))
            {
                string query = "SELECT title, author, description FROM Books WHERE id=@id";

                using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@id", BookID.ID);

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            title = reader["title"].ToString();
                            author = reader["author"].ToString();
                            description = reader["description"].ToString();
                        }
                    }
                }
            }

            BookTitle.Text = title;
            BookAuthor.Text = author;

            if (!string.IsNullOrWhiteSpace(description))
            {
                description_box.Text = description;
            }
            else
            {
                // Fetch from API
                BookService bookService = new BookService();
                string fetchedDescription = await bookService.GetBookDescriptionAsync(title);

                if (string.IsNullOrWhiteSpace(fetchedDescription) || fetchedDescription.StartsWith("No") || fetchedDescription.StartsWith("Description not"))
                {
                    description_box.Text = "Nav pieejama informācija šai grāmatai.";
                }
                else
                {
                    description_box.Text = fetchedDescription;

                    // Optionally, update the local DB
                    using (SQLiteConnection con = new SQLiteConnection(databaseFilePath()))
                    {
                        con.Open();
                        string updateQuery = "UPDATE Books SET description = @description WHERE id=@id";

                        using (SQLiteCommand cmd = new SQLiteCommand(updateQuery, con))
                        {
                            cmd.Parameters.AddWithValue("@description", fetchedDescription);
                            cmd.Parameters.AddWithValue("@id", BookID.ID);
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
            }
        }

        private void chooseBook_button_Click(object sender, EventArgs e)
        {
            DateTime current_time = DateTime.Now;
            DateTime due_date = DateTime.Now;

            switch (due_date_box.SelectedIndex)
            {
                case 0:
                    due_date = current_time.AddDays(7); 
                    break;
                case 1:
                    due_date = current_time.AddDays(14); 
                    break;
                case 2:
                    due_date = current_time.AddDays(21);
                    break;
            }

            try
            {
                if(agreement_check.Checked == true)
                {
                    string query = "INSERT INTO Returns (user_username, book_ID, reserved_at) VALUES (@user, @book, @at)";

                    using (SQLiteConnection con = new SQLiteConnection(databaseFilePath()))
                    {
                        using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                        {
                            con.Open();

                            cmd.Parameters.AddWithValue("@user", Global.global_username);
                            cmd.Parameters.AddWithValue("@book", BookID.ID);
                            cmd.Parameters.AddWithValue("@at", current_time);

                            cmd.ExecuteNonQuery();

                        }
                    }

                    string query2 = "UPDATE Books SET isreserved=1 WHERE ID=@id";

                    using (SQLiteConnection con = new SQLiteConnection(databaseFilePath()))
                    {
                        using (SQLiteCommand cmd = new SQLiteCommand(query2, con))
                        {
                            con.Open();

                            cmd.Parameters.AddWithValue("@id", BookID.ID);

                            cmd.ExecuteNonQuery();

                        }
                    }

                    string query3 = "INSERT INTO Reservations (user_username, book_ID) VALUES (@user, @book)";

                    using (SQLiteConnection con = new SQLiteConnection(databaseFilePath()))
                    {
                        using (SQLiteCommand cmd = new SQLiteCommand(query3, con))
                        {
                            con.Open();

                            cmd.Parameters.AddWithValue("@user", Global.global_username);
                            cmd.Parameters.AddWithValue("@book", BookID.ID);

                            cmd.ExecuteNonQuery();

                        }
                    }

                    MessageBox.Show("Grāmata izsniegta :)");

                    LoadAllLists();

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Atzīmējat, ka piekrītat rezervācijas noteikumiem.");
                }
            }
            catch
            {
                MessageBox.Show("Atgadījusies kļūda!");
            }
        }
    }
}

//##############################################################################################################################
//code for API

public class BookService
{
    private static readonly HttpClient httpClient = new HttpClient();

    public async Task<string> GetBookDescriptionAsync(string title)
    {
        if (string.IsNullOrWhiteSpace(title))
            throw new ArgumentException("Title must not be empty.", nameof(title));

        try
        {
            string query = Uri.EscapeDataString(title);
            string requestUri = $"https://openlibrary.org/search.json?title={query}";

            HttpResponseMessage response = await httpClient.GetAsync(requestUri);
            response.EnsureSuccessStatusCode();

            string jsonResponse = await response.Content.ReadAsStringAsync();
            JObject data = JObject.Parse(jsonResponse);

            var firstDoc = data["docs"]?.FirstOrDefault();
            if (firstDoc == null)
                return "Nav pieejama informācija šai grāmatai.";

            string key = firstDoc["key"]?.ToString();
            if (string.IsNullOrEmpty(key))
                return "Nav pieejama informācija šai grāmatai.";

            string bookDetailsUri = $"https://openlibrary.org{key}.json";
            HttpResponseMessage bookDetailsResponse = await httpClient.GetAsync(bookDetailsUri);
            bookDetailsResponse.EnsureSuccessStatusCode();

            string bookDetailsJson = await bookDetailsResponse.Content.ReadAsStringAsync();
            JObject bookDetails = JObject.Parse(bookDetailsJson);

            var descriptionToken = bookDetails["description"];

            string descriptionText = "";

            if (descriptionToken == null)
            {
                descriptionText = "Nav pieejama informācija šai grāmatai.";
            }
            else if (descriptionToken.Type == JTokenType.Object && descriptionToken["value"] != null)
            {
                descriptionText = descriptionToken["value"].ToString();
            }
            else
            {
                descriptionText = descriptionToken.ToString();
            }

            return $"Apraksts: {descriptionText}";
        }
        catch (HttpRequestException httpEx)
        {
            return $"Apraksts nav pieejams. (Tīkla kļūda: {httpEx.Message})";
        }
        catch (Exception ex)
        {
            return $"Apraksts nav pieejams. (Kļūda: {ex.Message})";
        }
    }
}

