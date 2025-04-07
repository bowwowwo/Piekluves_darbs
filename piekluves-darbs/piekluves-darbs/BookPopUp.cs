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
        public BookPopUp()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Amber800, Primary.Amber900, Primary.Amber500, Accent.LightBlue200, TextShade.WHITE);


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

        //-----------------------------------------------------------------------------------------------------

        private async void fetchBookInfo()
        {
            string txtBookTitle = "";

            using (SQLiteConnection con = new SQLiteConnection(databaseFilePath()))
            {
                con.Open();
                string query = "SELECT description FROM Books WHERE id=@id";
                string query2 = "INSERT INTO Books (description) VALUES (@description)";

                using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                {

                    cmd.Parameters.AddWithValue("@id", BookID.ID);


                    var thing = cmd.ExecuteScalar();
                    if (thing != null)
                    {
                        txtBookTitle = thing.ToString();
                        MessageBox.Show(txtBookTitle);

                        string bookTitle = txtBookTitle.Trim();

                        BookService bookService = new BookService();
                        string description = await bookService.GetBookDescriptionAsync(bookTitle);

                            using (SQLiteCommand cmd2 = new SQLiteCommand(query, con))
                            {
                                cmd2.Parameters.AddWithValue("@description", description);
                                cmd2.ExecuteNonQuery();
                            }
                            }
                    else
                    {
                        description_box.Text = "Nav pieejams apraksts.";
                    }

                }
            }
        }
    }
}

//##############################################################################################################################

public class BookService
{
    private static readonly HttpClient httpClient = new HttpClient();

    public async Task<string> GetBookDescriptionAsync(string title)
    {
        if (string.IsNullOrWhiteSpace(title))
        {
            throw new ArgumentException("Title must not be empty.", nameof(title));
        }

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
            {
                return "No results found.";
            }

            string key = firstDoc["key"]?.ToString();
            if (string.IsNullOrEmpty(key))
            {
                return "Description not available.";
            }

            string bookDetailsUri = $"https://openlibrary.org{key}.json";
            HttpResponseMessage bookDetailsResponse = await httpClient.GetAsync(bookDetailsUri);
            bookDetailsResponse.EnsureSuccessStatusCode();

            string bookDetailsJson = await bookDetailsResponse.Content.ReadAsStringAsync();
            JObject bookDetails = JObject.Parse(bookDetailsJson);

            string description = bookDetails["description"]?.ToString();
            return description ?? "Description not available.";
        }
        catch (HttpRequestException httpEx)
        {
            return $"Request error: {httpEx.Message}";
        }
        catch (Exception ex)
        {
            return $"An error occurred: {ex.Message}";
        }
    }
}