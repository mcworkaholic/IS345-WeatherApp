using System.Data;
using System.Data.SQLite;
using System.Diagnostics;

namespace Project_2
{
    public partial class Form4 : Form
    {
        object result;
        int pageCount;
        DataTable datatable;
        DataTable filteredDataTable;
        int minValue = 0;
        int maxValue = 40;
        SQLiteDataAdapter adapter;
        SQLiteConnection con;
        string Query;
        SQLiteCommand cmd;
        internal static Form2? form2;
        public Form4()
        {
            InitializeComponent();
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            int nextCount = (minValue - maxValue) >= 0 ? (minValue - maxValue) : 0;
            datatable = new DataTable();
            adapter.Fill(nextCount, maxValue, datatable);
            dataGridView1.DataSource = datatable;
            minValue = nextCount;
            if (pageCount != 1)
            {
                pageCount--;
            }
            pagesBox.Text = $"{pageCount} of {Math.Ceiling(Convert.ToDouble(result) / 40)}";
            //Enable disable button
            if (minValue == 0)
            {
                previousButton.Enabled = false;
                nextButton.Enabled = true;
            }
            else
            {
                previousButton.Enabled = true;
                nextButton.Enabled = true;
            }

        }
        private void nextButton_Click(object sender, EventArgs e)
        {
            int nextCount = minValue + datatable.Rows.Count;
            datatable = new DataTable();
            adapter.Fill(nextCount, maxValue, datatable);
            dataGridView1.DataSource = datatable;
            minValue = nextCount;
            pageCount++;
            pagesBox.Text = $"{pageCount} of {Math.Ceiling(Convert.ToDouble(result) / 40)}";
            //Enable disable button
            if (datatable.Rows.Count == maxValue)
            {
                previousButton.Enabled = true;
                nextButton.Enabled = true;
            }
            else
            {
                previousButton.Enabled = true;
                nextButton.Enabled = false;
                minValue = nextCount + datatable.Rows.Count;
            }
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            
            pageCount = 1;
            LoadData(WeatherForm.weatherForm.CheckCurrentFile());
            previousButton.Enabled = false;
            //pageBox.Text = "1 of " + (result / maxValue).ToString();
            using (con = new SQLiteConnection(@"data source =" + WeatherForm.weatherForm.CheckCurrentFile()))
            {
                Query = "SELECT COUNT(*) FROM weather;";
                con.Open();
                cmd = new SQLiteCommand(Query, con);
                result = cmd.ExecuteScalar();
                if (Convert.ToInt32(result) != 0)
                {
                    pagesBox.Text = pageCount.ToString() + " of " + Math.Ceiling(Convert.ToDouble(result) / 40).ToString();
                } else
                {
                    pagesBox.Text = "1 of 1";
                    nextButton.Enabled = false;
                }
            }
        }

        private void removeAllButton_Click(object sender, EventArgs e)
        {
            using (con = new SQLiteConnection(@"data source =" + WeatherForm.weatherForm.CheckCurrentFile()))
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
            //ReloadAVGTextBoxes();
            LoadData(WeatherForm.weatherForm.CheckCurrentFile());
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
                using (SQLiteConnection con = new SQLiteConnection(@"data source =" + WeatherForm.weatherForm.CheckCurrentFile()))
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
                            Query = string.Format("INSERT INTO weather (city, state, region, date_utc, time_utc, year, month, day, temp, weather_condition, humidity_percent, visibility_Feet, wind_speed_MPH, pressure_hPa) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}' )", values[0], values[1], values[2], values[3], values[4], values[5], values[6], values[7], values[8], values[9], values[10], values[11], values[12], values[13]);
                            cmd = new SQLiteCommand(Query, con);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    con.Close();
                    LoadData(WeatherForm.weatherForm.CheckCurrentFile());
                }
            }
        }
        private void bulkInsertButton_Click(object sender, EventArgs e)
        {
            csvImport();
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
            using (form2 = new Form2())
            {
                if (form2.ShowDialog() == DialogResult.OK)
                {
                    selectedYearRange = (form2.YearRange().Item1, form2.YearRange().Item2);

                    // plotting script location
                    string scriptPath = Path.Combine(projectDirectory, "Scripts", "tempPlotter.exe");

                    var process = new Process
                    {
                        StartInfo = new ProcessStartInfo
                        {
                            FileName = scriptPath,
                            Arguments = $"{WeatherForm.weatherForm.CheckCurrentFile()} {selectedYearRange.Item1} {selectedYearRange.Item2}",
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
                            string figurePath = Path.Combine(projectDirectory, "img\\plotting", "plot.png");
                            figureBox.Image = Image.FromFile(figurePath);
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
            }
        }

        private void removeSelectedButton_Click(object sender, EventArgs e)
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
                        con = new SQLiteConnection(@"data source =" + WeatherForm.weatherForm.CheckCurrentFile());
                        cmd = new SQLiteCommand(statement, con);
                        adapter.DeleteCommand = cmd;
                        datatable.Rows[index].Delete();
                        adapter.Update(datatable);
                        dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    }
                    else
                    {
                        // Show a message box if no rows are selected
                        MessageBox.Show("No rows selected.");
                        dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    }
                }
                removeSelectedButton.Visible = false;
            }
            else
            {
                // Show a message box if no rows are selected
                MessageBox.Show("No rows selected.");
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            removeSelectedButton.Visible = true;
        }
        private void LightReset()
        {
            this.ActiveControl = null;
            removeSelectedButton.Visible = false;
        }

        private void Form4_MouseClick(object sender, MouseEventArgs e)
        {
            LightReset();
        }

        private void advancedFilter_Click(object sender, EventArgs e)
        {
            using (Form3 form3 = new Form3())
            {
                if (form3.ShowDialog() == DialogResult.OK)
                {
                    filteredDataTable = form3.AdvancedFilter();
                    DataView DV = new DataView(filteredDataTable);
                    dataGridView1.DataSource = DV;
                    dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dataGridView1.SelectAll();
                    nextButton.Enabled = false;
                    previousButton.Enabled = false;
                    form3.Close();
                }
            }
            pagesBox.Text = "1 of 1";

        }
        private void LoadData(string selectedFile)  // DO NOT CHANGE ///////////
        {

            // Create a new connection to the selected file
            con = new SQLiteConnection(@"data source =" + selectedFile);

            // Open a connection to the selected file
            con.Open();

            // Create a command object to retrieve all data from the "weather" table
            Query = "SELECT weather_id AS ID, city AS City, state AS State, latitude as Latitude, longitude as Longitude, region as Region, date_utc AS Date_UTC, time_utc AS Time_UTC, temp AS Temperature, weather_condition AS Weather_Condition, humidity_percent AS Humidity_Percent, visibility_Feet AS Visibility_Feet, wind_speed_MPH AS Wind_Speed_MPH, pressure_hPa AS Pressure_hPa FROM weather";
            cmd = new SQLiteCommand(Query, con);

            // Create a new datatable to store the retrieved data
            datatable = new DataTable();

            // Create a new adapter to fill the datatable with data from the command object
            adapter = new SQLiteDataAdapter(cmd);
            int nextCount = 0;
            adapter.Fill(nextCount, maxValue, datatable);

            // Close the connection to the selected file
            con.Close();

            // Display the data in the dataGridView
            datatable.Columns[0].ReadOnly = true; // weather_id
            datatable.Columns[0].ColumnName = "ID";
            datatable.Columns[1].ColumnName = "City";
            datatable.Columns[5].ReadOnly = true; // region
            datatable.Columns[2].ColumnName = "State";
            datatable.Columns[3].ColumnName = "Latitude";
            datatable.Columns[4].ColumnName = "Longitude";
            datatable.Columns[5].ColumnName = "Region";
            datatable.Columns[6].ColumnName = "Date_UTC";
            datatable.Columns[7].ColumnName = "Time_UTC";
            dataGridView1.DataSource = datatable;
            dataGridView1.Columns[0].Width = 75;
            dataGridView1.Columns[2].Width = 40;
            dataGridView1.Columns[3].Width = 80;
            dataGridView1.Columns[4].Width = 80;
            dataGridView1.Columns[3].DefaultCellStyle.Format = "YYYY-MM-DD";
            dataGridView1.Columns[3].ValueType = typeof(DateTime);
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void refreshBox2_Click(object sender, EventArgs e)
        {
            minValue = 0;
            pageCount = 1;
            if (Convert.ToInt32(result) != 0)
            {
                pagesBox.Text = pageCount.ToString() + " of " + Math.Ceiling(Convert.ToDouble(result) / 40).ToString();
                nextButton.Enabled = true;
                previousButton.Enabled = false;
            }
            else
            {
                pagesBox.Text = pageCount.ToString() + " of 1";
                previousButton.Enabled = false;
                nextButton.Enabled = false;
            }
            LoadData(WeatherForm.weatherForm.CheckCurrentFile());
            removeSelectedButton.Visible = false;
        }

        private void distributionButton_Click(object sender, EventArgs e)
        {
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
                    // plotting script location
                    string scriptPath = Path.Combine(projectDirectory, "Scripts", "recordDistribution.exe");

                    var process = new Process
                    {
                        StartInfo = new ProcessStartInfo
                        {
                            FileName = scriptPath,
                            Arguments = $"{WeatherForm.weatherForm.CheckCurrentFile()}",
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
            }
        }