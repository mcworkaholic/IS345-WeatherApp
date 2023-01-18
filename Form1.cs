using System.Data;
using System.Data.SQLite;
using TextBox = System.Windows.Forms.TextBox;

namespace Project_2
{
    public partial class WeatherForm : Form

    {
        Control[] controls;
        public WeatherForm()
        {
            InitializeComponent();
            // Array of all controls whose visibility is toggled in the form on data load and form reset
            controls = new Control[] { addButton, searchTextBox, clearButton, refreshBox2, highButton, lowButton,
            refreshBox1, bulkInsertButton, resetButton, editButton, removeButton};
        }
        // GLOBALS, to be altered by the application
        string dbFile;
        SQLiteConnection con;
        DialogResult dialogFileConfirm;
        SQLiteCommand cmd;
        string Query;
        string newDbFile;
        string currentFile;
        DataTable datatable;
        SQLiteDataAdapter adapter;
        private bool newButtonPressed = false;

        // Queries for the avg textboxes
        string[] queries = { "SELECT AVG(temp) FROM weather WHERE state = 'WI';", 
            "SELECT AVG(temp) FROM weather WHERE state = 'IA';", 
            "SELECT AVG(temp) FROM weather WHERE state = 'SD';", 
            "SELECT AVG(temp) FROM weather WHERE state = 'ND';", 
            "SELECT AVG(temp) FROM weather WHERE state = 'MN';", 
            "SELECT AVG(temp) FROM weather;" };

        // Array of all state abbreviations for the state combobox
        string[] states = {"AK", "AL", "AR", "AZ", "CA", "CO", "CT", "DC", "DE", "FL", "GA",
         "HI", "IA", "ID", "IL", "IN", "KS", "KY", "LA", "MA", "MD", "ME",
         "MI", "MN", "MO", "MS", "MT", "NC", "ND", "NE", "NH", "NJ", "NM",
         "NV", "NY", "OH", "OK", "OR", "PA", "RI", "SC", "SD", "TN", "TX",
         "UT", "VA", "VT", "WA", "WI", "WV", "WY"};

        private string selectedFile;
        private void cityTextBox_TextChanged(object sender, EventArgs e)
        {   // regex for characters, spaces, and backspaces
            string pattern = @"^[A-Za-z.\s+\b]+$";
            if (cityTextBox.Text.Length != 0)
            {
                // Auto complete functionality for city textbox, MAY IMPLEMENT  *low priority*
                if (cityTextBox.Text.Length >= 3)
                {
                    //SuggestStrings will have the logic to return array of strings either from cache/db
                    //string[] arr = SuggestStrings(cityTextBox.Text);

                    AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
                    // collection.AddRange(arr);

                    this.cityTextBox.AutoCompleteCustomSource = collection;
                }
                if (!System.Text.RegularExpressions.Regex.IsMatch(cityTextBox.Text, pattern))
                {
                    MessageBox.Show("This textbox accepts only alphabetical characters");
                    cityTextBox.Text = cityTextBox.Text.Remove(cityTextBox.Text.Length - 1);
                }
            }
        }
        // Empties the textboxes where the user adds information in the upper left hand corner of the form
        private void EmptyTextBoxes()
        {
            cityTextBox.Text = string.Empty;
            stateBox.Text = string.Empty;
            tempTextBox.Text = string.Empty;
        }
        private void ReloadAVGTextBoxes()
        {
            TextBox[] textboxes = { wiTextBox, iaTextBox, sdTextBox, ndTextBox, mnTextBox, regionTextBox };
            AVGTextboxes(textboxes, queries);
        }
        private void EnableAll()
        {
            startGroupBox.Visible = false;
            blankBox.Visible = false;
            noDataLabel.Visible = false;

            // Make all buttons visible and set to enabled
            foreach (Control c in controls)
            {
                c.Visible = true;
                c.Enabled = true;
            }

            // FOR LOOP to add each state to the Combobox
            for (int i = 0; i < states.Length; i++)
            {
                stateBox.Items.Add(states[i]);
            }
        }

        // Loads data from the selected file into the dataGridView.
        private void LoadData(string selectedFile)
        {
            // Create a new connection to the selected file
            con = new SQLiteConnection(@"data source =" + selectedFile);

            // Open a connection to the selected file
            con.Open();

            // Create a command object to retrieve all data from the "weather" table
            Query = "SELECT * FROM weather";
            cmd = new SQLiteCommand(Query, con);

            // Create a new datatable to store the retrieved data
            datatable = new DataTable();

            // Create a new adapter to fill the datatable with data from the command object
            adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(datatable);

            // Display the data in the dataGridView
            dataGridView1.DataSource = datatable;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;

            // Close the connection to the selected file
            con.Close();
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
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
            if (newButtonPressed)
            {
                dbFile = newDbFile;
            }
            else
            {
                dbFile = selectedFile;
            }
            // Creating new connection object
            using (SQLiteConnection con = new SQLiteConnection(@"data source =" + Path.Combine(projectDirectory, dbFile)))
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
         * It defaults to looking in the same directory where the application is running from for .db files.
         * 'weather.db' is provided with the application.
         */
        private void SourceButton_Click(object sender, EventArgs e)
        {
            // Create an OpenFileDialog object to allow the user to select a file
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Set the initial directory to the current project directory
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
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
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if the temperature entered is within the allowed range
                if (double.Parse(tempTextBox.Text) < -70 || double.Parse(tempTextBox.Text) > 140)
                {
                    MessageBox.Show("Temperature out of range (-70 to 140)");
                }
                else
                {
                    // Get the current directory and project directory
                    dataGridView1.DataSource = null;
                    dataGridView1.Update();
                    dataGridView1.Refresh();
                    // connection object
                    string workingDirectory = Environment.CurrentDirectory;
                    string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;

                    // check if a new database was created/new button was pressed and confirmed
                    if (!newButtonPressed)
                    {
                        con = new SQLiteConnection(@"data source =" + projectDirectory + "/" + "weather.db");
                    }
                    else
                    {
                        // Connect to the new weather_[randomNumber].db file
                        con = new SQLiteConnection(@"data source =" + newDbFile);
                    }
                    con.Open();

                    // Create a new SQLiteCommand object with the INSERT INTO statement
                    string theDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                    Query = string.Format("INSERT INTO weather (city, state, date, temp) VALUES ('{0}', '{1}', '{2}', '{3}')", cityTextBox.Text, stateBox.Text, theDate, tempTextBox.Text);
                    cmd = new SQLiteCommand(Query, con);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    // set the selection mode for the data grid view to cell select
                    dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;

                    // check if the new button has been pressed
                    if (newButtonPressed)
                    {
                        // if it has, load the data from the new database file
                        LoadData(newDbFile);
                    }
                    else if (!newButtonPressed)
                    {
                        // if not, load data from the selected file
                        LoadData(selectedFile);
                    }
                    EmptyTextBoxes();
                    ReloadAVGTextBoxes();
                }
            }
            catch (FormatException)
            {
                // Handle the exception
                MessageBox.Show("Fields must not be empty.");
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            EmptyTextBoxes();
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
            FilterDataGridView("temp", "min");
        }

        private void highButton_Click(object sender, EventArgs e)
        {
            FilterDataGridView("temp", "max");
        }

        /* searchTextBox_TextChanged is used to filter the datagrid based on what the user enters.
         * It filters by the columns -> city, state, or year
         */
        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(datatable);
            DV.RowFilter = string.Format("city LIKE '%{0}%' OR state LIKE '%{1}%' OR date LIKE '%{2}%'", searchTextBox.Text, searchTextBox.Text, searchTextBox.Text);
            dataGridView1.DataSource = DV;
        }
        private void tempTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {   //what is allowed       //backspace  //hyphen    //period    //enter    //whitespace
            string st = "0123456789" + (char)8 + (char)45 + (char)46 + (char)13 + (char)32;
            if (!st.Contains(e.KeyChar))
            {
                MessageBox.Show("Please only use numbers, periods, and hyphens");
                e.Handled = true;
            }
        }
        // Homemade refresh button 2, refreshes datagrid to original state
        private void refreshBox2_Click(object sender, EventArgs e)
        {
            if (!newButtonPressed)
            {
                LoadData(selectedFile);
                ReloadAVGTextBoxes();
            }
            else if (newButtonPressed)
            {
                LoadData(newDbFile);
            }

        }
        // Homemade refresh button 2, refreshes datagrid to original state
        private void refreshBox1_Click(object sender, EventArgs e)
        {
            if (!newButtonPressed)
            {
                LoadData(selectedFile);
                ReloadAVGTextBoxes();
            }
            else if (newButtonPressed)
            {
                LoadData(newDbFile);
            }
        }
        private void editButton_Click(object sender, EventArgs e)
        {
            // Enable editing mode on the DataGridView
            dataGridView1.ReadOnly = false;

            // Change the text of the Edit button to "Save"
            editButton.Text = "Save";

            // Add a click event handler to the Save button to handle saving the changes, and remove the editbuttonclick event handler
            editButton.Click -= editButton_Click;
            editButton.Click += saveButton_Click;

            dataGridView1.EditMode = DataGridViewEditMode.EditOnEnter;
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            // Disable editing mode on the DataGridView
            dataGridView1.ReadOnly = true;

            // Create a new command builder
            SQLiteCommandBuilder cmdBuilder = new SQLiteCommandBuilder(adapter);

            // Update the database with the changes made to the DataTable
            adapter.Update(datatable);
            ReloadAVGTextBoxes();

            // Change the text of the Save button back to "Edit"
            editButton.Text = "Edit";

            // Remove the click event handler for the Save button, add the editbutton click event handler
            editButton.Click -= saveButton_Click;
            editButton.Click += editButton_Click;

            // Set the EditMode back to 'EditProgrammatically'
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        // dataGridView1_KeyDown NOT WORKING  *medium priority*
        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (dataGridView1.CurrentCell.IsInEditMode && e.KeyCode == Keys.Enter)
            {
                dataGridView1.EndEdit();
                // Save the changes in the datagrid here
                // Debug
                MessageBox.Show("You pressed enter!");
            }
        }
        // Allows the removal of rows from the datagrid
        private void removeButton_Click(object sender, EventArgs e)
        {
            // Enable editing mode on the DataGridView
            dataGridView1.ReadOnly = false;
            // Change text of the remove button to "Confirm"
            removeButton.Text = "Confirm";
            // Make cancel button visible so user can exit "removal" mode. 
            cancelButton.Visible = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            removeButton.Click -= removeButton_Click;
            removeButton.Click += confirmRemoveButton_Click;
        }

        // Confirms data removal from the datagrid
        private void confirmRemoveButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("                  Are you sure?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
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
                        if (dataGridView1.Rows[index].Cells["weather_id"].Value != null)
                        {
                            string id = dataGridView1.Rows[index].Cells["weather_id"].Value.ToString();
                            string query = "DELETE FROM weather WHERE weather_id = " + id;
                            cmd = new SQLiteCommand(query, con);
                            adapter.DeleteCommand = cmd;
                            datatable.Rows[index].Delete();
                            adapter.Update(datatable);
                            ReloadAVGTextBoxes();
                        }
                        else
                        {
                            // Show a message box if no rows are selected
                            MessageBox.Show("No rows selected.");
                        }
                    }
                    // Change the text of the remove button as well as make the datagrid/db read only
                    removeButton.Text = "Remove";
                    dataGridView1.ReadOnly = true;
                    removeButton.Click += removeButton_Click;
                    removeButton.Click -= confirmRemoveButton_Click;
                }
                else
                {
                    // Show a message box if no rows are selected
                    MessageBox.Show("No rows selected.");
                }
            }
            else if (result == DialogResult.No)
            {
                // Do not perform delete action
            }
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
                string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;

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

                // Create a table with the same column names as the existing one
                string createTableQuery = "CREATE TABLE weather (weather_id INTEGER PRIMARY KEY AUTOINCREMENT, city TEXT, state TEXT, date TEXT, temp REAL)";

                // Perform CREATE DDL and close connection
                SQLiteCommand cmdCreate = new SQLiteCommand(createTableQuery, con);
                cmdCreate.ExecuteNonQuery();
                con.Close();

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
        // csvImport takes the current db file being displayed in the datagrid as an argument
        private void csvImport(string currentFile)
        {
            // Import from CSV in Project folder and insert into current db/datagrid
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                // Read the CSV file and insert the data into the SQLite database
                using (SQLiteConnection con = new SQLiteConnection(@"data source =" + currentFile))
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
                            Query = string.Format("INSERT INTO weather (city, state, date, temp) VALUES ('{0}', '{1}', '{2}', '{3}')", values[0], values[1], values[2], values[3]);
                            cmd = new SQLiteCommand(Query, con);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    con.Close();
                    LoadData(currentFile);
                }
            }
        }
        private void bulkInsertButton_Click(object sender, EventArgs e)
        {
            if (newButtonPressed == true)
            {
                csvImport(newDbFile);
            }
            else {
                csvImport(selectedFile);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            // exit out of "Remove" mode 
            removeButton.Text = "Remove";
            dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
            cancelButton.Visible = false;
            dataGridView1.ReadOnly = true;
            // Resets the remove button's behavior back to the way it was before the "removal mode" was activated
            removeButton.Click += removeButton_Click;
            removeButton.Click -= confirmRemoveButton_Click;
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

            // display over datagrid, add start groupbox
            startGroupBox.Visible = true;
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
        }
    }
}

