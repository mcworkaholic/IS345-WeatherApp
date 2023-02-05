/**
 * Author:    Weston Evans
 * Created:   Week 1
 * Last Changed: 1.29.2023
 * Class: IS345 Sec. 54
 * Purpose: Temperature Analysis Application  
 * 
 * USAGE:
 * 
 * START: 
 * 
 * The user can either start by pressing "select source" to pick one of the provided databases 
 * or "new" to create an empty one to start adding in data. It is recommended to click "select source" and start with "weathersmall.db" for testing.
 * The user must then confirm whether or not they wish to open the selected database.
 * 
 * INSERTION: 
 * 
 * To add in a single record they just have to enter a city(valid), state, temperature(within range), 
 * and then pick a date. At this point the user can either click clear to reset all textBox values or the "➕" button to add the record.
 * For BULK insertion, click on the "Bulk ➕" button and pick from the given .csv files that are already formatted for insertion. 
 * It is recommended to start from new when doing a bulk insert so you can see exactly what values were inserted. 
 * 
 * -----------------------------OPTIONS-----------------------------
 * 
 * HIGH/LOW: To find the highest/lowest record simply click on the highest/lowest button in the lower left hand corner.
 * To refresh the view to all records click on the refresh symbol to the right of the previosly mentioned buttons. There is another refresh button near the middle. 
 * 
 * RESET: 
 * 
 * To reset the form and/or load a different database you can click on reset.
 * 
 * EDITING: 
 * 
 * To edit or remove a record the user needs to either click on EDIT or REMOVE. 
 * Once the edit button is clicked, changes can be made after double clicking in the datagridview 
 * but they must also click on the SAVE button to commit their changes. Note that some columns are read only.
 * 
 * To REMOVE a record that button must also be clicked and the datagridview selection mode changes to full row select.
 * Clicking on CANCEL exits removal mode and changes selection mode to cell select. 
 * To remove multiple records the ctrl button must be held while clicking, 
 * and when the user is satisfied they must click on the CONFIRM button to commit their changes.
 * Clicking on REMOVE ALL removes all records in the current database but does not delete the database. 
 * DO NOT click on the red ❌ as you search, the functionality is broken for now.
 * 
 * SEARCH:
 * 
 * To filter just start typing in the search text box. It filters by city, state, or region.
 * 
 * PLOT:
 * 
 * Please see the comments by the plotButtonClick event handler for specifics on getting it running, 
 * your luck may vary.
 * Once working, the user just has to select a range of values for visualization.
 * 
 * **/

using Newtonsoft.Json;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.SQLite;
using System.Diagnostics;
using System.Globalization;
using TextBox = System.Windows.Forms.TextBox;

namespace Project_2
{
    public partial class WeatherForm : Form
    {
        public class US_State
        {
            public string Name { get; set; }
            public string Abbreviations { get; set; }

            public string Region { get; set; }

            public US_State(string abbreviations, string name, string region)
            {
                Abbreviations = abbreviations;
                Name = name;
                Region = region;
            }
        }
        static class StateArray
        {
            public static List<US_State> states;

            static StateArray()
            {
                states = new List<US_State>(50)
                {  // US Climate Regions provided by NOAA.gov
                    new US_State("AL", "Alabama", "Southeast"),
                    new US_State("AK", "Alaska", "Alaska"),
                    new US_State("AZ", "Arizona", "Southwest"),
                    new US_State("AR", "Arkansas", "Southeast"),
                    new US_State("CA", "California", "West"),
                    new US_State("CO", "Colorado", "Southwest"),
                    new US_State("CT", "Connecticut", "Northeast"),
                    new US_State("DE", "Delaware", "Northeast"),
                    new US_State("DC", "District Of Columbia", "Northeast"),
                    new US_State("FL", "Florida", "Southeast"),
                    new US_State("GA", "Georgia", "Southeast"),
                    new US_State("HI", "Hawaii", "Hawaii"),
                    new US_State("ID", "Idaho", "Northwest"),
                    new US_State("IL", "Illinois", "Ohio Valley"),
                    new US_State("IN", "Indiana", "Ohio Valley"),
                    new US_State("IA", "Iowa", "Upper Midwest"),
                    new US_State("KS", "Kansas", "South"),
                    new US_State("KY", "Kentucky", "Ohio Valley"),
                    new US_State("LA", "Louisiana", "South"),
                    new US_State("ME", "Maine", "Northeast"),
                    new US_State("MD", "Maryland", "Northeast"),
                    new US_State("MA", "Massachusetts", "Northeast"),
                    new US_State("MI", "Michigan", "Upper Midwest"),
                    new US_State("MN", "Minnesota", "Upper Midwest"),
                    new US_State("MS", "Mississippi", "South"),
                    new US_State("MO", "Missouri", "Ohio Valley"),
                    new US_State("MT", "Montana", "Northern Rockies and Plains"),
                    new US_State("NE", "Nebraska", "Northern Rockies and Plains"),
                    new US_State("NV", "Nevada", "West"),
                    new US_State("NH", "New Hampshire", "Northeast"),
                    new US_State("NJ", "New Jersey", "Northeast"),
                    new US_State("NM", "New Mexico", "Southwest"),
                    new US_State("NY", "New York", "Northeast"),
                    new US_State("NC", "North Carolina", "Southeast"),
                    new US_State("ND", "North Dakota", "Northern Rockies and Plains"),
                    new US_State("OH", "Ohio", "Ohio Valley"),
                    new US_State("OK", "Oklahoma", "South"),
                    new US_State("OR", "Oregon", "Northwest"),
                    new US_State("PA", "Pennsylvania", "Northeast"),
                    new US_State("RI", "Rhode Island", "Northeast"),
                    new US_State("SC", "South Carolina", "Southeast"),
                    new US_State("SD", "South Dakota", "Northern Rockies and Plains"),
                    new US_State("TN", "Tennessee", "Ohio Valley"),
                    new US_State("TX", "Texas", "South"),
                    new US_State("UT", "Utah", "Southwest"),
                    new US_State("VT", "Vermont", "Northeast"),
                    new US_State("VA", "Virginia", "Southeast"),
                    new US_State("WA", "Washington", "Northwest"),
                    new US_State("WV", "West Virginia", "Ohio Valley"),
                    new US_State("WI", "Wisconsin", "Upper Midwest"),
                    new US_State("WY", "Wyoming", "Northern Rockies and Plains")
                };
            }
        }

        Control[] controls;
        public WeatherForm()
        {
            InitializeComponent();
            // Array of all controls whose visibility is toggled in the form on data load and form reset
            controls = new Control[] { addButton, searchTextBox, clearButton, refreshBox2, highButton, lowButton, getButton,
             bulkInsertButton, resetButton, editButton, plotButton, removeButton, removeAllButton};
        }
        // GLOBALS, to be altered by the application

        SQLiteConnection con;
        DialogResult dialogFileConfirm;
        SQLiteCommand cmd;
        string Query;
        string newDbFile;
        DataTable datatable;
        SQLiteDataAdapter adapter;
        private bool newButtonPressed = false;
        private string selectedFile;
        DataView DV;

        // Queries for the avg textboxes
        string[] queries = { "SELECT AVG(temp) FROM weather WHERE state = 'WI';",
            "SELECT AVG(temp) FROM weather WHERE state = 'IA';",
            "SELECT AVG(temp) FROM weather WHERE state = 'SD';",
            "SELECT AVG(temp) FROM weather WHERE state = 'ND';",
            "SELECT AVG(temp) FROM weather WHERE state = 'MN';",
            "SELECT AVG(temp) FROM weather WHERE state in ('WI', 'IA', 'SD', 'ND', 'MN');" };

        private void cityTextBox_TextChanged(object sender, EventArgs e)
        {
            // Removes error icon if user retypes in citytextbox after unverifiable city
            errorIcon.Visible = false;

            // regex for characters, spaces, and backspaces
            string pattern = @"^[A-Za-z.\s+\b]+$";
            if (cityTextBox.Text.Length != 0)
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(cityTextBox.Text, pattern))
                {
                    MessageBox.Show("This textbox accepts only alphabetical characters");
                    cityTextBox.Text = cityTextBox.Text.Remove(cityTextBox.Text.Length - 1);
                    cityTextBox.Select(cityTextBox.Text.Length, 0);
                }
            }
        }
        private void tempTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {   //what is allowed       //backspace  //hyphen    //period    //enter    //whitespace
            string st = "0123456789" + (char)8 + (char)45 + (char)46 + (char)13 + (char)32;
            if (!st.Contains(e.KeyChar) && tempTextBox.ReadOnly == false)
            {
                MessageBox.Show("Please only use numbers, periods, and hyphens");
                e.Handled = true;
            }
        }
        private bool VerifyLocation(string city, string state)
        {
            bool valid;
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName + "/Data";
            using (SQLiteConnection con = new SQLiteConnection(@"data source =" + Path.Combine(projectDirectory, "cities.db")))
            {
                try
                {
                    con.Open();
                    Query = "SELECT US_CITIES.CITY, US_STATES.STATE_CODE FROM US_CITIES" +
                        " INNER JOIN US_STATES " +
                        "ON US_CITIES.ID_STATE = US_STATES.ID " +
                        "WHERE US_CITIES.CITY = @CITY AND US_STATES.STATE_CODE = @STATE;";
                    SQLiteCommand cmd = new SQLiteCommand(Query, con);
                    cmd.Parameters.AddWithValue("@CITY", city);
                    cmd.Parameters.AddWithValue("@STATE", state);
                    var result = cmd.ExecuteScalar();
                    if (result == null)
                    {
                        valid = false;
                    }
                    else
                    {
                        valid = true;
                    }
                    return valid;
                }
                // Exception handling
                catch (Exception ex)
                {
                    valid = false;
                    MessageBox.Show("Error: " + ex.Message);
                    return valid;
                }
            }
        }
        private void getButton_Click(object sender, EventArgs e)
        {
            cityTextBox.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(cityTextBox.Text);

            string[] abbreviation = { "St.", "st." };
            if (abbreviation.Any(cityTextBox.Text.Contains))
            {
                string text = cityTextBox.Text;
                text = text.Replace(abbreviation[0], "Saint");
                cityTextBox.Text = text;
            }
            
            if (VerifyLocation(cityTextBox.Text, stateBox.GetItemText(stateBox.SelectedItem).ToString()) == true)
            {
                string workingDirectory = Environment.CurrentDirectory;
                string dataDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName + "/Data";
                string iconDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName + "/img/icons-weather";

                using (SQLiteConnection con = new SQLiteConnection(@"data source =" + Path.Combine(dataDirectory, "cities.db")))
                {
                    try
                    {
                        con.Open();
                        Query = "SELECT US_CITIES.LATITUDE, US_CITIES.LONGITUDE from US_CITIES INNER JOIN US_STATES ON US_CITIES.ID_STATE = US_STATES.ID WHERE US_CITIES.CITY = @CITY AND US_STATES.STATE_CODE = @STATE;";
                        SQLiteCommand cmd = new SQLiteCommand(Query, con);
                        cmd.Parameters.AddWithValue("@CITY", cityTextBox.Text);
                        cmd.Parameters.AddWithValue("@STATE", stateBox.GetItemText(stateBox.SelectedItem).ToString());
                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string latitude = (String.Format("{0}", reader["LATITUDE"]));
                                string longitude = (String.Format("{0}", reader["LONGITUDE"]));
                                // MessageBox.Show("Latitude: " + latitude + " Longitude: " + longitude);
                                // Calls openweathermap.org's API to get weather conditions
                                // example api call: https://api.openweathermap.org/data/2.5/weather?lat={lat}&lon={lon}&appid={API key}

                                using (var client = new HttpClient())
                                {
                                    bool valid;
                                    var apiKey = "bdd9cf8717a09ffd505acc42dac63d73";
                                    var response = client.GetAsync($@"https://api.openweathermap.org/data/2.5/weather?lat={latitude}&lon={longitude}&appid={apiKey}").Result;
                                    response.EnsureSuccessStatusCode();
                                    var content = response.Content.ReadAsStringAsync().Result;
                                    if (content.Length == 0 || content == "[]")
                                    {
                                        valid = false;
                                    }
                                    else
                                    {
                                        dynamic details = JsonConvert.DeserializeObject(content);
                                        string description = details["weather"][0]["description"].ToString();
                                        string kelvin = details["main"]["temp"].ToString();
                                        // Fahrenheit = 1.8*(K-273) + 32
                                        // Celsius = K – 273.15
                                        double v = double.Parse(kelvin) - 273;
                                        double celsius = Math.Round(v - .15);
                                        double fahrenheit = Math.Round(((1.8 * v) + 32), 2);
                                        string cstring = celsius.ToString();
                                        string fstring = fahrenheit.ToString();
                                        string icon = details["weather"][0]["icon"].ToString();
                                        string id = details["weather"][0]["id"].ToString();
                                        string[] drizzle = { "300", "301", "302", "310", "311", "312", "313", "314", "321" };
                                        string[] thunderstormsRain = { "200", "201", "202", "230", "231", "232" };
                                        string[] snow = { "600", "601", "602", "620", "621", "622" };
                                        string[] sleet = { "611", "612", "613", "615", "616" };
                                        string[] rain = { "511", "520", "521", "522", "531" };
                                        string[] thunderstorms = {"210", "211", "212", "221"};
                                        string[] partCldDyRain = { "501", "502", "503", "504" };
                                        string[] overcastNight = { "03n", "04n" };

                                        if (drizzle.Any(id.Contains))
                                        {
                                            iconBox.ImageLocation = iconDirectory + "/drizzle.gif";
                                        }
                                        else if (thunderstormsRain.Any(id.Contains))
                                        {
                                            iconBox.ImageLocation = iconDirectory + "/thunderstorms-rain.gif";
                                        }
                                        else if (snow.Any(id.Contains))
                                        {
                                            iconBox.ImageLocation = iconDirectory + "/snow.gif";
                                        }
                                        else if (sleet.Any(id.Contains))
                                        {
                                            iconBox.ImageLocation = iconDirectory + "/sleet.gif";
                                        }
                                        else if (rain.Any(id.Contains))
                                        {
                                            iconBox.ImageLocation = iconDirectory + "/rain.gif";
                                        }
                                        else if (thunderstorms.Any(id.Contains))
                                        {
                                            iconBox.ImageLocation = iconDirectory + "/thunderstorms.gif";
                                        }
                                        else if (partCldDyRain.Any(id.Contains))
                                        {
                                            iconBox.ImageLocation = iconDirectory + "/partly-cloudy-day-rain.gif";
                                        }
                                        else if (icon == "01d")
                                        {
                                            iconBox.ImageLocation = iconDirectory + "/clear-day.gif";
                                        }
                                        else if (icon == "01n")
                                        {
                                            iconBox.ImageLocation = iconDirectory + "/clear-night.gif";
                                        }
                                        else if (icon == "02d")
                                        {
                                            iconBox.ImageLocation = iconDirectory + "/partly-cloudy-day.gif";
                                        }
                                        else if (icon == "02n")
                                        {
                                            iconBox.ImageLocation = iconDirectory + "/partly-cloudy-night.gif";
                                        }
                                        else if (icon == "03d")
                                        {
                                            iconBox.ImageLocation = iconDirectory + "/overcast-day.gif";
                                        }
                                        else if (overcastNight.Any(id.Contains))
                                        {
                                            iconBox.ImageLocation = iconDirectory + "/overcast-night.gif";
                                        }
                                        else
                                        {
                                            switch (id)
                                            {

                                                case "500":
                                                    iconBox.ImageLocation = iconDirectory + "/partly-cloudy-day-drizzle.gif";
                                                    break;

                                                case "701":
                                                    iconBox.ImageLocation = iconDirectory + "/mist.gif";
                                                    break;
                                                case "711":
                                                    iconBox.ImageLocation = iconDirectory + "/smoke.gif";
                                                    break;

                                                case "721":
                                                    iconBox.ImageLocation = iconDirectory + "/haze-day.gif";
                                                    break;
                                                case "731":
                                                    iconBox.ImageLocation = iconDirectory + "/dust-day.gif";
                                                    break;

                                                case "761":
                                                    iconBox.ImageLocation = iconDirectory + "/dust-day.gif";
                                                    break;
                                                case "771":
                                                    iconBox.ImageLocation = iconDirectory + "/wind.gif";
                                                    break;

                                                case "781":
                                                    iconBox.ImageLocation = iconDirectory + "/tornado.gif";
                                                    break;

                                                default:
                                                    iconBox.ImageLocation = iconDirectory + "/partly-cloudy-day.gif";
                                                    break;
                                            }
                                        }
                                        iconBox.Visible = true;
                                        descriptionLabel.Visible = true;
                                        tempLabel2.Visible = true;
                                        tempTextBox.Text = fstring;
                                        descriptionLabel.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(description); 
                                        tempLabel2.Text = fstring + "°F";
                                        tempLabel2.Location = new Point(((panel.Width - tempLabel2.Width)/ 2), 117);
                                        descriptionLabel.Location= new Point(((panel.Width-descriptionLabel.Width) / 2) + 4, 141);
                                        iconBox.BringToFront();
                                    }
                                }
                            }
                        }
                    }
                    // Exception handling
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
            else
            {
                errorIcon.Visible = true;
                cityTextBox.Focus();
            }
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;

            // Changes whatever the user enters into title case (princeton -> Princeton) or (san francisco -> San Francisco)
            cityTextBox.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(cityTextBox.Text);
            string[] abbreviation = { "St.", "st." };
            if (abbreviation.Any(cityTextBox.Text.Contains))
            {
                string text = cityTextBox.Text;
                text = text.Replace(abbreviation[0], "Saint");
                cityTextBox.Text = text;
            }
            else
            {
                // Do nothing
            }
            try
            {
                // Check if the temperature entered is within the allowed range
                if (double.Parse(tempTextBox.Text) < -70 || double.Parse(tempTextBox.Text) > 140)
                {
                    MessageBox.Show("Temperature out of range (-70 to 140)");
                    tempTextBox.Clear();
                    tempTextBox.Focus();
                }
                else if (stateBox.SelectedIndex < 0)
                {
                    MessageBox.Show("Please select a state");
                    stateBox.DroppedDown = true;
                }
                else if (VerifyLocation(cityTextBox.Text, stateBox.GetItemText(stateBox.SelectedItem).ToString()) == false)
                {
                    errorIcon.Visible = true;
                    cityTextBox.Focus();
                }

                else
                {
                    stateBox.DroppedDown = false;
                    // string selected = this.ComboBox.GetItemText(this.ComboBox.SelectedItem);
                    // messageBox.Show(selected)
                    dataGridView1.DataSource = null;
                    dataGridView1.Update();
                    dataGridView1.Refresh();

                    // check if a new database was created/new button was pressed and confirmed
                    con = new SQLiteConnection(@"data source =" + CheckCurrentFile());

                    // sets date format
                    string theDate = dateTimePicker1.Value.ToString("M/dd/yyyy");
                    string year = theDate.Substring(5, 4);
                    string month = theDate.Substring(0, 1);
                    string day = theDate.Substring(2, 2);

                    if (day.StartsWith("0"))
                    {
                        day = day.Remove(day.IndexOf("0"), 1);
                    }

                    //MessageBox.Show("theDate: " + theDate + " " + "year : " + year + " " + " month: " + month + " day: " + day);  -> debugging

                    // Create a new SQLiteCommand object with the INSERT INTO statement
                    Query = string.Format("INSERT INTO weather (city, state, region, date, year, month, day, temp) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}')", cityTextBox.Text, stateBox.Text, ReturnRegion(stateBox.GetItemText(stateBox.SelectedItem)), theDate, year, month, day, tempTextBox.Text);
                    con.Open();
                    cmd = new SQLiteCommand(Query, con);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    LoadData(CheckCurrentFile());

                    dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                    // Selects last added record and highlights the ID of the cell
                    dataGridView1.CurrentCell = dataGridView1[0, datatable.Rows.Count - 1];
                    dataGridView1.Rows[datatable.Rows.Count - 1].Selected = true;
                    iconBox.Visible = false;
                    ReloadAVGTextBoxes();
                }
            }
            catch (FormatException)
            {
                // Handle the exception
                MessageBox.Show("Fields must not be blank");
            }
        }

        // Empties the textboxes where the user adds information in the upper left hand corner of the form
        private void EmptyTextBoxes()
        {
            cityTextBox.Text = string.Empty;
            stateBox.Text = string.Empty;
            stateBox.SelectedIndex = -1;
            tempTextBox.Text = string.Empty;
            iconBox.Visible = false;
            tempLabel2.Visible = false;
            descriptionLabel.Visible = false;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            EmptyTextBoxes();
        }
        // reloads selected textboxes and their averages
        private void ReloadAVGTextBoxes()
        {
            TextBox[] textboxes = { wiTextBox, iaTextBox, sdTextBox, ndTextBox, mnTextBox, regionTextBox };
            AVGTextboxes(textboxes, queries);
        }
        // Enables all buttons that should be shown once data is loaded/ new db is created
        private void EnableAll()
        {
            dataGridView1.ReadOnly = true;

            // Autocomplete source from values already in database
            using (con = new SQLiteConnection(@"data source =" + CheckCurrentFile()))
            {
                Query = "SELECT DISTINCT city FROM weather;";
                con.Open();
                cmd = new SQLiteCommand(Query, con);
                SQLiteDataReader reader = cmd.ExecuteReader();
                AutoCompleteStringCollection MyCollection = new AutoCompleteStringCollection();
                while (reader.Read())
                {
                    MyCollection.Add(reader.GetString(0));
                }
                cityTextBox.AutoCompleteCustomSource = MyCollection;
                con.Close();
            }
            cityTextBox.ReadOnly = false;
            tempTextBox.ReadOnly = false;
            sourceButton.Visible = false;
            newButton.Location = new System.Drawing.Point(108, 179); 
            blankBox.Visible = false;
            noDataLabel.Visible = false;
            

            // Make all buttons visible and set to enabled
            foreach (Control c in controls)
            {
                c.Visible = true;
                c.Enabled = true;
            }

            // FOR LOOP to add each state to the Combobox
            foreach (US_State state in StateArray.states)
            {
                stateBox.Items.Add(state.Abbreviations);
            }
        }

        // Loads data from the selected file into the dataGridView.
        private void LoadData(string selectedFile)  // DO NOT CHANGE ///////////
        {
            // Create a new connection to the selected file
            con = new SQLiteConnection(@"data source =" + selectedFile);

            // Open a connection to the selected file
            con.Open();

            // Create a command object to retrieve all data from the "weather" table
            Query = "SELECT weather_id AS ID, city AS City, state AS State, region as Region, date AS Date, temp AS Temperature FROM weather";
            cmd = new SQLiteCommand(Query, con);

            // Create a new datatable to store the retrieved data
            datatable = new DataTable();

            // Create a new adapter to fill the datatable with data from the command object
            adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(datatable);

            // Close the connection to the selected file
            con.Close();

            // Display the data in the dataGridView
            datatable.Columns[0].ReadOnly = true; // weather_id
            datatable.Columns[0].ColumnName = "ID";
            datatable.Columns[1].ColumnName = "City";
            datatable.Columns[3].ReadOnly = true; // region
            datatable.Columns[2].ColumnName = "State";
            datatable.Columns[3].ColumnName = "Region";
            datatable.Columns[4].ColumnName = "Date";
            datatable.Columns[5].ColumnName = "Temperature";
            dataGridView1.DataSource = datatable;
            dataGridView1.Columns[0].Width = 25;
            dataGridView1.Columns[2].Width = 40;
            dataGridView1.Columns[3].Width = 150;
            dataGridView1.Columns[4].Width = 80;
            dataGridView1.Columns[3].DefaultCellStyle.Format = "MM/dd/yyyy";
            dataGridView1.Columns[3].ValueType = typeof(DateTime);
            dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
            descriptionLabel.Visible = false;
            tempLabel2.Visible = false;
            iconBox.Visible = false;
        }
        /* The function AVGTextboxes takes in two parameters, an array of TextBox objects and an array of strings (queries). 
         * The purpose of this function is to update the text of the TextBox objects 
         * with the result of the corresponding queries (AVGs).
         */
        private void AVGTextboxes(TextBox[] textboxes, string[] queries)
        {
            /* Determining the file path of the database to be used, 
             * either the default "weather.db" provided with the application or a newly created file if the newButtonPressed flag is set.
             */
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName + "/Data";

            // Creating new connection object
            using (SQLiteConnection con = new SQLiteConnection(@"data source =" + Path.Combine(projectDirectory, CheckCurrentFile())))
            {
                try
                {
                    con.Open();

                    /*  for loop to iterate through the textboxes and queries arrays, 
                     * creating a new SQLiteCommand object for each iteration and executing the corresponding query.
                     */
                    for (int i = 0; i < textboxes.Length; i++)
                    {
                        SQLiteCommand cmd = new SQLiteCommand(queries[i], con);
                        var result = cmd.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            textboxes[i].Text = Math.Round((double)result, 1).ToString();
                        }
                        else
                        {
                            textboxes[i].Text = string.Empty;
                        }
                    }
                }
                // Exception handling
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        /* SourceButton_Click allows the user to choose the file the data is loaded from.
         * It defaults to looking in the "Data" directory for .db files.
         * 'smallweather.db' and 'bulkweather.db' is provided with the application.
         */
        private void SourceButton_Click(object sender, EventArgs e)
        {
            // Create an OpenFileDialog object to allow the user to select a file
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Set the initial directory to the current project directory
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName + "/Data";
            openFileDialog.InitialDirectory = projectDirectory;

            // Set the filter to look for .db files
            openFileDialog.Filter = "DB files (*.db)|*.db";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;

            // Check if the refreshBox has not been enabled yet
            if (refreshBox2.Enabled != true)
            {
                // Show the OpenFileDialog and check if the user clicks the OK button
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Assign the selected file's path to the selectedFile variable
                    selectedFile = openFileDialog.FileName;

                    // Show the file path in a message box for debugging purposes
                    dialogFileConfirm = MessageBox.Show("Opening: " + selectedFile.ToString(), "Open File", MessageBoxButtons.OKCancel);
                    if (dialogFileConfirm == DialogResult.OK)
                    {
                        EnableAll();

                        // Call the LoadData function and pass in the selectedFile variable as an argument
                        LoadData(selectedFile);
                        ReloadAVGTextBoxes();
                    }
                    else if (dialogFileConfirm != DialogResult.Cancel)
                    {
                        // Do Nothing
                    }
                }
            }
        }
        private void closeButton_Click(object sender, EventArgs e)
        {
            // Close form
            this.Close();
            this.Dispose();
        }
        private string ReturnRegion(string abbreviation)
        {
            string region = "N/A";
            foreach (US_State state in StateArray.states)
            {
                if (state.Abbreviations == abbreviation)
                {
                    region = state.Region;
                    return region;
                }
            }
            return region;
        }
       

        /* FilterDataGridView is used to get the highest temperature and the lowest temperature.
         Parameters include column name and what operation to perform, in this case SELECT MAX(temp) or
         and SELECT MIN(temp) from the database
        */
        private void FilterDataGridView(string columnName, string operation)
        {
            try
            {
                double result = Convert.ToDouble(datatable.Compute(operation + "(" + columnName + ")", string.Empty));
                DataView DV = new DataView(datatable);
                DV.RowFilter = columnName + " = " + result.ToString();
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.DataSource = DV;
            }
            catch (InvalidCastException)
            {
                MessageBox.Show("There is no data to select from, please enter something in the grid first.");
            }
        }
        private void lowButton_Click(object sender, EventArgs e)
        {
            FilterDataGridView("Temperature", "min");
        }

        private void highButton_Click(object sender, EventArgs e)
        {
            FilterDataGridView("Temperature", "max");
        }

        /* searchTextBox_TextChanged is used to filter the datagrid based on what the user enters.
         * It filters by the columns -> city, state, or year
         */
        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (searchTextBox.Text.Length > 0)
            {
                removeSelectedButton.Visible = true;
                DV = new DataView(datatable);
                // searchtextbox db filtering
                DV.RowFilter = string.Format("city LIKE '%{0}%' OR state LIKE '%{1}%' OR region LIKE '%{2}%'", searchTextBox.Text, searchTextBox.Text, searchTextBox.Text);
                dataGridView1.DataSource = DV.ToTable();
                dataGridView1.SelectAll();
            }
            else
            {
                removeSelectedButton.Visible = false;
                dataGridView1.DataSource = datatable;
            }
        }
        // Homemade refresh button, refreshes datagrid to original state
        private void refreshBox2_Click(object sender, EventArgs e)
        {
            LoadData(CheckCurrentFile());
            ReloadAVGTextBoxes();
        }
        // Enter edit mode
        private void editButton_Click(object sender, EventArgs e)
        {

            // Enable editing mode on the DataGridView
            dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
            saveButton.Visible = true;
            dataGridView1.ReadOnly = false;
            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[3].ReadOnly = true;
            dataGridView1.EditMode = DataGridViewEditMode.EditOnEnter;
        }
        // Allows the removal of rows from the datagrid
        private void removeButton_Click(object sender, EventArgs e)
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            // Enable editing mode on the DataGridView
            dataGridView1.ReadOnly = false;
            // Change text of the remove button to "Confirm"
            confirmButton.Visible = true;
            // Make cancel button visible so user can exit "removal" mode. 
            cancelButton.Visible = true;
        }

        // newButton_Click creates a new database in the project directory and switches to it
        private void newButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to create a new database?", "Create Database", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                newButtonPressed = true;
                // Generate a random number to be appended to the file name
                Random random = new Random();
                int randomNumber = random.Next();
                string newFileName = "weather_" + randomNumber + ".db";

                // Get the current directory
                string workingDirectory = Environment.CurrentDirectory;
                string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName + "/Data";

                // Create a new .db file in the current directory with a unique name
                newDbFile = Path.Combine(projectDirectory, newFileName);
                string newDbPath = Path.Combine(projectDirectory, newFileName);
                if (!File.Exists(newDbPath))
                {
                    SQLiteConnection.CreateFile(newDbPath);
                }

                // Connect to the new .db file
                SQLiteConnection con = new SQLiteConnection(@"data source =" + newDbFile);
                con.Open();

                // Create a table with the same column names, properties as the existing one
                string createTableQuery = "CREATE TABLE weather (weather_id INTEGER PRIMARY KEY AUTOINCREMENT, city TEXT NOT NULL, state TEXT NOT NULL, region TEXT NOT NULL, date TEXT NOT NULL, year TEXT NOT NULL, month TEXT NOT NULL, day TEXT NOT NULL, temp REAL NOT NULL)";

                // Perform CREATE DDL and close connection
                SQLiteCommand cmdCreate = new SQLiteCommand(createTableQuery, con);
                cmdCreate.ExecuteNonQuery();
                con.Close();

                // Buttons
                EnableAll();

                // Reload the data grid with the new .db file
                LoadData(newDbFile);
                ReloadAVGTextBoxes();
            }
            else if (result == DialogResult.No)
            {
                // Do not perform delete action
            }
        }
        private void csvImport()
        {
            // Import from CSV in Project folder and insert into current db/datagrid
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV files (*.csv)|*.csv";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                // Read the CSV file and insert the data into the SQLite database
                using (SQLiteConnection con = new SQLiteConnection(@"data source =" + CheckCurrentFile()))
                {
                    con.Open();

                    using (var reader = new StreamReader(filePath))
                    {
                        // hacky way of skipping the first line
                        reader.ReadLine();

                        while (!reader.EndOfStream)
                        {
                            var line = reader.ReadLine();
                            var values = line.Split(',');

                            // Insert the data into the SQLite database
                            Query = string.Format("INSERT INTO weather (city, state, region, date, year, month, day, temp) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}')", values[0], values[1], values[2], values[3], values[4], values[5], values[6], values[7]);
                            cmd = new SQLiteCommand(Query, con);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    con.Close();
                    LoadData(CheckCurrentFile());
                }
            }
        }
        private void bulkInsertButton_Click(object sender, EventArgs e)
        {
            csvImport();
            ReloadAVGTextBoxes();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            // exit out of "removal" mode
            dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView1.ReadOnly = true;
            cancelButton.Visible = false;
            confirmButton.Visible = false;
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            // Reset everything in the form
            dataGridView1.DataSource = null;
            dateTimePicker1.Value = DateTime.Now;
            newButtonPressed = false;

            // Upper left-hand textboxes
            EmptyTextBoxes();

            // Empty the average temp textboxes for state and region
            wiTextBox.Text = String.Empty;
            iaTextBox.Text = String.Empty;
            sdTextBox.Text = String.Empty;
            ndTextBox.Text = String.Empty;
            mnTextBox.Text = String.Empty;
            regionTextBox.Text = String.Empty;

            newButton.Location = new System.Drawing.Point(147, 179);
            sourceButton.Visible = true;
            blankBox.Visible = true;
            noDataLabel.Visible = true;

            // Disable all buttons in the array and remove visibility
            foreach (Control c in controls)
            {
                c.Visible = false;
                c.Enabled = false;
            }
            // Clear statebox combobox
            stateBox.Items.Clear();
            cancelButton.Visible = false;
            removeSelectedButton.Visible = false;
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            // Check if there are any selected rows
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the selected rows
                DataGridViewSelectedRowCollection selectedRows = dataGridView1.SelectedRows;

                // Iterate through the selected rows and remove them from the DataTable
                foreach (DataGridViewRow row in selectedRows)
                {
                    int index = row.Index;
                    if (dataGridView1.Rows[index].Cells["ID"].Value != null)
                    {
                        string id = dataGridView1.Rows[index].Cells["ID"].Value.ToString();
                        string statement = "DELETE FROM weather WHERE weather_id = " + id;
                        cmd = new SQLiteCommand(statement, con);
                        adapter.DeleteCommand = cmd;
                        datatable.Rows[index].Delete();
                        adapter.Update(datatable);
                        ReloadAVGTextBoxes();
                        dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
                    }
                    else
                    {
                        // Show a message box if no rows are selected
                        MessageBox.Show("No rows selected.");
                        dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
                    }
                }
                // Change the text of the remove button as well as make the datagrid/db read only
                dataGridView1.ReadOnly = true;
                confirmButton.Visible = false;
                cancelButton.Visible = false;
            }
            else
            {
                // Show a message box if no rows are selected
                MessageBox.Show("No rows selected.");
            }
        }

        // returns the filename of the db in use
        private string CheckCurrentFile()
        {
            string filename = "";
            if (!newButtonPressed)
            {
                filename = selectedFile;
                return filename;
            }
            else if (newButtonPressed)
            {
                filename = newDbFile;
                return filename;
            }
            return filename;
        }

        /*
        plotButton_Click is a method that calls a python script "tempPlotter.py" located in the "Scripts" directory, which generates a plot/image of the data in the currently selected database and saves it in the "img" directory.

        The script requires a working installation of python 3.10 and the libraries specified in the "requirements.txt" file in the "Scripts" directory to be installed.

        The method takes in the user's selected year range from a separate form, and passes it along with the current database file name as parameters to the script.

        Once the script completes execution, the method displays the saved plot/image in a new form/window.

        Note that the method assumes that the correct version of python, interpreter and libraries are available and that the permissions for the "img" directory are set to read + write for the script to overwrite the plot image.
        */
        private void plotButton_Click(object sender, EventArgs e)
        {
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;

            var selectedYearRange = ("", "");
            using (Form2 form2 = new Form2())
            {
                if (form2.ShowDialog() == DialogResult.OK)
                {
                    selectedYearRange = (form2.YearRange().Item1, form2.YearRange().Item2);
                    // May need to change python path to something like "C:\Python311\python.exe" or just "python" depending on your installation
                    string pythonPath = "python3";

                    // plotting script location
                    string scriptPath = Path.Combine(projectDirectory, "Scripts", "tempPlotter.py");

                    var process = new Process
                    {
                        StartInfo = new ProcessStartInfo
                        {
                            FileName = pythonPath,
                            Arguments = $"{scriptPath} {CheckCurrentFile()} {selectedYearRange.Item1} {selectedYearRange.Item2}",
                            RedirectStandardOutput = true,
                            UseShellExecute = false,
                            CreateNoWindow = true,
                        }
                    };
                    process.StartInfo.RedirectStandardError = true;
                    process.Start();
                    string output = process.StandardOutput.ReadToEnd();
                    string error = process.StandardError.ReadToEnd();
                    process.WaitForExit();

                    if (process.HasExited)
                    {
                        if (process.ExitCode == 0)
                        {
                            process.Kill();

                            // process completed successfully
                            // check the output and error variables for any messages
                            // Create a new form to display the figure
                            Form figureForm = new Form();
                            PictureBox figureBox = new PictureBox();
                            string figurePath = Path.Combine(projectDirectory, "img", "plot.png");
                            figureBox.Image = System.Drawing.Image.FromFile(figurePath);
                            figureBox.Size = figureBox.Image.Size;
                            figureForm.Controls.Add(figureBox);
                            figureForm.FormClosed += new FormClosedEventHandler((s, e) => figureForm_FormClosed(s, e, figureBox));
                            figureForm.WindowState = FormWindowState.Maximized;
                            figureForm.Show();
                        }
                        else
                        {
                            // process completed with an error
                            // check the output and error variables for any error messages
                            MessageBox.Show(error);
                        }
                    }
                    else
                    {
                        // process did not complete
                        // check the output and error variables for any messages
                        MessageBox.Show(error);
                    }
                }
                else
                {
                    //Do nothing
                }
            }
        }
        private void figureForm_FormClosed(object sender, FormClosedEventArgs e, PictureBox figureBox)
        {
            // releases plot.png from the process/memory so that another dataset can be plotted
            if (figureBox != null)
            {
                figureBox.Image.Dispose();
                figureBox.Image = null;
            }
            GC.Collect();
        }
        // Timer to stop the showing of each gif, set for 4 seconds each for each one in the designer
        private void dataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)

        {
            // For some reason the event is getting registered twice, so need to remove then add
            e.Control.KeyPress -= new KeyPressEventHandler(Control_KeyPress);
            e.Control.KeyPress += new KeyPressEventHandler(Control_KeyPress);
        }
        // Key Press input validation for the datagrid view 
        private void Control_KeyPress(object sender, KeyPressEventArgs e)
        {
            int columnIndex = dataGridView1.CurrentCell.ColumnIndex;
            string currentCellValue = dataGridView1.CurrentCell.Value?.ToString() ?? "";

            switch (columnIndex)
            {
                case 1:
                    //KeyPress event for city column 
                    string city = "" + (char)8 + (char)13 + (char)32 + (char)46;
                    if (!char.IsLetter(e.KeyChar) && !city.Contains(e.KeyChar))
                    {
                        MessageBox.Show("Only letters are allowed in the city column.");
                        e.Handled = true;
                    }
                    break;
                case 2:
                    //KeyPress event for state column 
                    string state = "" + (char)8 + (char)13 + (char)32;
                    if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)8)
                    {
                        MessageBox.Show("Only letters are allowed in the state column.");
                        e.Handled = true;
                    }
                    break;
                case 4:
                    //KeyPress event for date column 
                    string date = "0123456789/" + (char)8 + (char)13 + (char)32;
                    if (!date.Contains(e.KeyChar))
                    {
                        MessageBox.Show("Only numbers and slashes allowed");
                        e.Handled = true;
                    }
                    break;
                case 5:
                    //KeyPress event for temp column 
                    string temp = "0123456789" + (char)8 + (char)45 + (char)46 + (char)13 + (char)32;
                    if (!temp.Contains(e.KeyChar))
                    {
                        MessageBox.Show("Only numbers, decimals, and hyphens allowed");
                        e.Handled = true;
                    }
                    break;
            }
        }
        // *Work Needed* to integrate with the selected/highlighted rows after filtering in the search textbox
        private void removeSelectedButton_Click(object sender, EventArgs e)
        {
            con = new SQLiteConnection(@"data source =" + CheckCurrentFile());
            // Iterate through the selected rows and remove them from the DataTable
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                // Get the DataRow object for the row
                DataRow dataRow = ((DataRowView)row.DataBoundItem).Row;

                // Define the DELETE statement
                string deleteSql = "DELETE FROM weather WHERE city LIKE @City AND state LIKE @State AND region LIKE @Region";
                con.Open();
                // Create a new SqlCommand object with the DELETE statement and the connection
                using (SQLiteCommand deleteCommand = new SQLiteCommand(deleteSql, con))
                {
                    // Add the ID parameter and set its value to the ID of the current row
                    deleteCommand.Parameters.AddWithValue("@City", dataRow["City"]);
                    deleteCommand.Parameters.AddWithValue("@State", dataRow["State"]);
                    deleteCommand.Parameters.AddWithValue("@Region", dataRow["Region"]);

                    // Execute the DELETE statement
                    deleteCommand.ExecuteNonQuery();
                }
                con.Close();
                // mark the row as deleted
                // accept changes to remove the deleted rows
                datatable.AcceptChanges();
                adapter.Update(datatable);
                ReloadAVGTextBoxes();
                LoadData(CheckCurrentFile());

            }
        }
        // Commits and formats changes after entry
        private void saveButton_Click_1(object sender, EventArgs e)
        {
            ////Get all row changes from embedded DataTable of DataGridView's DataSource
            //DataRowCollection modifiedRows = ((DataTable)dataGridView1.DataSource).GetChanges(DataRowState.Modified).Rows;

            //foreach (DataRowCollection row in modifiedRows)
            //{
            // Get the last row edited
            int lastRowEdited = dataGridView1.CurrentCell.RowIndex;
            double temp;

            // Check the last row edited for errors

            // Change city to titlecase for SQL query and formatting
            string city = dataGridView1.Rows[lastRowEdited].Cells["City"].Value.ToString();
            city = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(city);
            dataGridView1.Rows[lastRowEdited].Cells[1].Value = city;

            string state = dataGridView1.Rows[lastRowEdited].Cells["State"].Value.ToString().ToUpper();
            dataGridView1.Rows[lastRowEdited].Cells[2].Value = state;

            string tempString = dataGridView1.Rows[lastRowEdited].Cells["Temperature"].Value.ToString();
            string date = dataGridView1.Rows[lastRowEdited].Cells["Date"].Value.ToString();

            // Regex for mm/dd//yyyy
            string pattern = @"^((((0[13578])|([13578])|(1[02]))[\/](([1-9])|([0-2][0-9])|(3[01])))|(((0[469])|([469])|(11))[\/](([1-9])|([0-2][0-9])|(30)))|((2|02)[\/](([1-9])|([0-2][0-9]))))[\/]\d{4}$|^\d{4}$";

            string abbreviation = "St.";
            if (city != null && city.Contains(abbreviation))
            {
                city = city.Replace(abbreviation, "Saint");
            }
            if (city != null && state != null && VerifyLocation(city, state) == false)
            {
                dataGridView1.Rows[lastRowEdited].ErrorText = "Location could not be verified";
                MessageBox.Show("Location could not be verified. Please correct the errors in the DataGridView before saving.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if (date == null || !System.Text.RegularExpressions.Regex.IsMatch(date, pattern))
            {
                dataGridView1.Rows[lastRowEdited].ErrorText = "Date must be in mm/dd/yyyy format";
                MessageBox.Show("Date must be in mm/dd/yyyy format. Please correct the errors in the DataGridView before saving.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!double.TryParse(tempString, out temp) || (temp < -70 || temp > 140))
            {
                dataGridView1.Rows[lastRowEdited].ErrorText = "Temperature must be between -70 & 140";
                MessageBox.Show(" Temperature must be between -70 & 140°F. Please correct the errors in the DataGridView before saving.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                dataGridView1.Rows[lastRowEdited].ErrorText = "";
                saveButton.Visible = false;
                // Disable editing mode on the DataGridView
                dataGridView1.ReadOnly = true;
                // Create a new command builder
                SQLiteCommandBuilder cmdBuilder = new SQLiteCommandBuilder(adapter);
                // Update the database with the changes made to the DataTable
                adapter.Update(datatable);
                ReloadAVGTextBoxes();
                // Set the EditMode back to 'EditProgrammatically'
                dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
            }
            //}
        }

        private void removeAllButton_Click(object sender, EventArgs e)
        {
            using (con = new SQLiteConnection(@"data source =" + CheckCurrentFile()))
            {
                string deleteSql = "DELETE FROM weather;";
                con.Open();
                // Create a new SqlCommand object with the DELETE statement and the connection
                using (SQLiteCommand deleteCommand = new SQLiteCommand(deleteSql, con))
                {
                    deleteCommand.ExecuteNonQuery();
                }
            }
            // mark the row as deleted
            // accept changes to remove the deleted rows
            datatable.AcceptChanges();
            adapter.Update(datatable);
            ReloadAVGTextBoxes();
            LoadData(CheckCurrentFile());
        }
    }
}
