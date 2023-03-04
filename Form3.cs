using System.Data;
using System.Data.SQLite;
using System.Globalization;
using static Project_2.WeatherForm;

namespace Project_2
{
    public partial class Form3 : Form
    {
        CheckBox[] checkBoxes;
        SQLiteDataAdapter adapter;
        public DataTable filteredDatatable;
        public Form3()
        {
            InitializeComponent();
            checkBoxes = new CheckBox[11] { cityCheckBox, stateCheckBox, regionCheckBox, tempCheckBox, earlyCheckBox, lateCheckBox, conditionBox, humidityBox, visibilityBox, windBox, pressureBox };
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void cityCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (cityCheckBox.Checked)
            {
                cityTextBox.Visible = true;
                cityTextBox.Focus();
            }
            else
            {
                cityTextBox.Visible = false;
            }
        }
        private void stateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (stateCheckBox.Checked)
            {
                stateBox.Visible = true;
                stateBox.Focus();
                if (stateBox.Items.Count < 1)
                {
                    foreach (US_State state in StateArray.states)
                    {
                        stateBox.Items.Add(state.Abbreviations);
                    }
                }
            }
            else
            {
                stateBox.Visible = false;
            }
        }
        private void tempCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (tempCheckBox.Checked)
            {
                tempTrackBar1.Visible = true;
                tempMaxButton.Visible = true;
                tempMinButton.Visible = true;
                tempMinLabel.Visible = true;
                tempMaxLabel.Visible = true;
            }
            else
            {
                tempTrackBar1.Visible = false;
                tempRangeLabel.Visible = false;
                tempMaxButton.Visible = false;
                tempMinButton.Visible = false;
                tempMinLabel.Visible = false;
                tempMaxLabel.Visible = false;
            }
        }
        private void regionCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            string[] regions = { "Southeast", "Northeast", "Northwest", "Southwest", "West", "Alaska", "Hawaii", "Ohio Valley", "Upper Midwest", "South", "Northern Rockies and Plains" };
            if (regionCheckBox.Checked)
            {
                regionBox.Visible = true;
                foreach (string region in regions)
                {
                    regionBox.Items.Add(region);
                }
                regionBox.Focus();
            }
            else
            {
                regionBox.Visible = false;
                regionBox.Items.Clear();
            }
        }
        private void earlyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (earlyCheckBox.Checked)
            {
                earlyDateTimePicker.Visible = true;
                earlyDateTimePicker.Focus();
            }
            else
            {
                earlyDateTimePicker.Visible = false;
            }
        }

        private void lateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (lateCheckBox.Checked)
            {
                lateDateTimePicker.Visible = true;
                lateDateTimePicker.Focus();
            }
            else
            {
                lateDateTimePicker.Visible = false;
            }
        }

        private void cityTextBox_TextChanged(object sender, EventArgs e)
        {
            // Removes error icon if user retypes in citytextbox after unverifiable city
            //errorIcon.Visible = false;

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
        public DataTable AdvancedFilter()
        {
            string cityAddition = "city = @City";
            string stateAddition = "state = @State";
            string regionAddition = "region = @Region";
            string minTempAddition = "temp >= @lowTemp";
            string maxTempAddition = "temp <= @highTemp";
            string tempAddition = "";
            string minDateAddition = "date_utc >= date(@earlyDate)";
            string maxDateAddition = "date_utc <= date(@lateDate)";
            string conditionAddition = "weather_condition = @weather_condition";
            string minHumidityAddition = "humidity_percent >= @lowHumidity";
            string maxHumidityAddition = "humidity_percent <= @highHumidity";
            string humidityAddition = "";
            string minVisibility = "visibility_Feet >= @lowVisibility";
            string maxVisibility = "visibility_Feet <= @highVisibility";
            string visibilityAddition = "";
            string minWindSpeed = "wind_speed_MPH >= @lowWindSpeed";
            string maxWindSpeed = "wind_speed_MPH <= @highWindSpeed";
            string windAddition = "";
            string minPressure = "pressure_hPa >= @lowPressure";
            string maxPressure = "pressure_hPa <= @highPressure";
            string pressureAddition = "";
            string where = "";
            string and = " AND ";
            string baseQuery = "SELECT weather_id AS ID, city AS City, state AS State, latitude AS Latitude, longitude AS Longitude, region AS Region, date_utc AS Date_UTC, time_utc AS Time_UTC, temp AS Temperature, weather_condition AS Weather_Condition, humidity_percent AS Humidity_Percent, visibility_Feet AS Visibility_Feet, wind_speed_MPH AS Wind_Speed_MPH, pressure_hPa AS Pressure_hPa FROM weather";
            string[] Additions = { cityAddition, stateAddition, regionAddition, tempAddition, minDateAddition, maxDateAddition, conditionAddition, humidityAddition, visibilityAddition, windAddition, pressureAddition };
            List<string> checkedAdditions = new List<string>();

            if (tempCheckBox.Checked)
            {
                if (tempMinButton.Checked)
                {
                    Additions[3] = minTempAddition;
                }
                else if (tempMaxButton.Checked)
                {
                    Additions[3] = maxTempAddition;
                }
            }
            if (humidityBox.Checked)
            {
                if (humidityMinButton.Checked)
                {
                    Additions[7] = minHumidityAddition;
                }
                else if (humidityMaxButton.Checked)
                {
                    Additions[7] = maxHumidityAddition;
                }
            }
            if (visibilityBox.Checked)
            {
                if (visibilityMinButton.Checked)
                {
                    Additions[8] = minVisibility;
                }
                else if (visibilityMaxButton.Checked)
                {
                    Additions[8] = maxVisibility;
                }
            }
            if (windBox.Checked)
            {
                if (windMinButton.Checked)
                {
                    Additions[9] = minWindSpeed;
                }
                else if (windMaxButton.Checked)
                {
                    Additions[9] = maxWindSpeed;
                }
            }
            if (pressureBox.Checked)
            {
                if (pressureMinButton.Checked)
                {
                    Additions[10] = minPressure;
                }
                else if (pressureMaxButton.Checked)
                {
                    Additions[10] = maxPressure;
                }
            }

            int counter = 0;
            foreach (CheckBox checkBox in checkBoxes)
            {
                if (checkBox.Checked)
                {
                    checkedAdditions.Add(Additions[counter]);
                }
                counter++;
            }

            string finalQuery;
            if (checkedAdditions.Count > 0)
            {
                where = " WHERE ";
                finalQuery = baseQuery + where + checkedAdditions[0];
                for (int i = 1; i < checkedAdditions.Count; i++)
                {
                    finalQuery += and + checkedAdditions[i];
                }
            }
            else
            {
                finalQuery = baseQuery;
            }
            MessageBox.Show(finalQuery.ToString());
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName + "\\Data";

            using (SQLiteConnection con = new SQLiteConnection(@"data source =" + Path.Combine(projectDirectory, WeatherForm.weatherForm.CheckCurrentFile())))
            {
                try
                {
                    con.Open();
                    SQLiteCommand cmd = new(finalQuery, con);
                    // Add parameters based on the values of the check boxes and their corresponding additions
                    if (cityCheckBox.Checked)
                    {
                        string city;
                        city = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(cityTextBox.Text);
                        cmd.Parameters.AddWithValue("@City", city);
                    }
                    if (stateCheckBox.Checked)
                    {
                        cmd.Parameters.AddWithValue("@State", stateBox.GetItemText(stateBox.SelectedItem).ToString());
                    }
                    if (regionCheckBox.Checked)
                    {
                        cmd.Parameters.AddWithValue("@Region", regionBox.GetItemText(regionBox.SelectedItem).ToString());
                    }
                    if (tempCheckBox.Checked)
                    {
                        if (tempMinButton.Checked)
                        {
                            cmd.Parameters.AddWithValue("@lowTemp", tempTrackBar1.Value);
                        }
                        else if (tempMaxButton.Checked)
                        {
                            cmd.Parameters.AddWithValue("@highTemp", tempTrackBar1.Value);
                        }
                    }
                    if (earlyCheckBox.Checked)
                    {
                        cmd.Parameters.AddWithValue("@earlyDate", earlyDateTimePicker.Value);
                    }
                    if (lateCheckBox.Checked)
                    {
                        cmd.Parameters.AddWithValue("@lateDate", lateDateTimePicker.Value);
                    }
                    if (conditionBox.Checked)
                    {
                        cmd.Parameters.AddWithValue("@weather_condition", conditionComboBox.GetItemText(conditionComboBox.SelectedItem).ToString());
                    }
                    if (humidityBox.Checked)
                    {
                        if (humidityMinButton.Checked)
                        {
                            cmd.Parameters.AddWithValue("@lowHumidity", humidityTrackBar1.Value);
                        }
                        else if (humidityMaxButton.Checked)
                        {
                            cmd.Parameters.AddWithValue("@highHumidity", humidityTrackBar1.Value);
                        }
                    }
                    if (visibilityBox.Checked)
                    {
                        if (visibilityMinButton.Checked)
                        {
                            cmd.Parameters.AddWithValue("@lowVisibility", visibilitytrackBar1.Value * 5280);
                        }
                        else if (visibilityMaxButton.Checked)
                        {
                            cmd.Parameters.AddWithValue("@highVisibility", visibilitytrackBar1.Value * 5280);
                        }
                    }
                    if (windBox.Checked)
                    {
                        if (windMinButton.Checked)
                        {
                            cmd.Parameters.AddWithValue("@lowWindSpeed", windTrackBar1.Value);
                        }
                        else if (windMaxButton.Checked)
                        {
                            cmd.Parameters.AddWithValue("@highWindSpeed", windTrackBar1.Value);
                        }
                    }
                    if (pressureBox.Checked)
                    {
                        if (pressureMinButton.Checked)
                        {
                            cmd.Parameters.AddWithValue("@lowPressure", pressureTrackBar1.Value);
                        }
                        else if (pressureMaxButton.Checked)
                        {
                            cmd.Parameters.AddWithValue("@highPressure", pressureTrackBar1.Value);
                        }
                    }

                    var result = cmd.ExecuteScalar();
                    filteredDatatable = new DataTable();
                    adapter = new SQLiteDataAdapter(cmd);
                    adapter.Fill(filteredDatatable); // adds found record currently
                    filteredDatatable.Columns[0].ReadOnly = true; // weather_id
                    filteredDatatable.Columns[0].ColumnName = "ID";
                    filteredDatatable.Columns[1].ColumnName = "City";
                    filteredDatatable.Columns[3].ReadOnly = true; // region
                    filteredDatatable.Columns[2].ColumnName = "State";
                    filteredDatatable.Columns[3].ColumnName = "Region";
                    filteredDatatable.Columns[4].ColumnName = "Date_UTC";
                    filteredDatatable.Columns[5].ColumnName = "Time_UTC";
                    return filteredDatatable;
                }
                // Exception handling
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return filteredDatatable;
                }
            }
        }
        private void okButton_Click(object sender, EventArgs e)
        {
            if (cityCheckBox.Checked)
            {
                if (cityTextBox.Text == "")
                {
                    cityCheckBox.Checked = false;
                }
            }
            if (stateCheckBox.Checked)
            {
                if (stateBox.SelectedIndex == -1)
                {
                    stateCheckBox.Checked = false;
                }
            }
            if (regionCheckBox.Checked)
            {
                if (regionBox.SelectedIndex == -1)
                {
                    regionCheckBox.Checked = false;
                }
            }
            if (lateCheckBox.Checked && earlyCheckBox.Checked)
            {
                if (lateDateTimePicker.Value < earlyDateTimePicker.Value)
                {
                    lateCheckBox.Checked = false;
                    earlyCheckBox.Checked = false;
                }
            }
            if (conditionBox.Checked)
            {
                if (conditionComboBox.SelectedIndex == -1)
                {
                    conditionBox.Checked = false;
                }
            }
            if (tempCheckBox.Checked)
            {
                if (!tempMaxButton.Checked && !tempMinButton.Checked)
                {
                    tempCheckBox.Checked = false;
                }
            }
            if (humidityBox.Checked)
            {
                if (!humidityMaxButton.Checked && !humidityMinButton.Checked)
                {
                    humidityBox.Checked = false;
                }
            }
            if (visibilityBox.Checked)
            {
                if (!visibilityMaxButton.Checked && !visibilityMinButton.Checked)
                {
                    visibilityBox.Checked = false;
                }
            }
            if (windBox.Checked)
            {
                if (!windMaxButton.Checked && !windMinButton.Checked)
                {
                    windBox.Checked = false;
                }
            }
            if (pressureBox.Checked)
            {
                if (!pressureMaxButton.Checked && !pressureMinButton.Checked)
                {
                    pressureBox.Checked = false;
                }
            }
            DialogResult = DialogResult.OK;
        }
        private void humidityTrackBar2_ValueChanged(object sender, EventArgs e)
        {
            // Update any other controls or values that depend on the selected range
            humidityRangeLabel.Visible = true;
            if (humidityMinButton.Checked)
            {
                humidityRangeLabel.Text = $"Selected Range: Values >= {humidityTrackBar1.Value}";
            }
            else if (humidityMaxButton.Checked)
            {
                humidityRangeLabel.Text = $"Selected Range: Values <= {humidityTrackBar1.Value}";
            }
        }
        private void tempTrackBar1_ValueChanged(object sender, EventArgs e)
        {
            // Update any other controls or values that depend on the selected range
            tempRangeLabel.Visible = true;
            if (tempMinButton.Checked)
            {
                tempRangeLabel.Text = $"Selected Range: Values >= {tempTrackBar1.Value}";
            }
            else if (tempMaxButton.Checked)
            {
                tempRangeLabel.Text = $"Selected Range: Values <= {tempTrackBar1.Value}";
            }
        }

        private void pressureTrackBar1_ValueChanged(object sender, EventArgs e)
        {
            pressureRangeLabel.Visible = true;
            if (pressureMinButton.Checked)
            {
                pressureRangeLabel.Text = $"Selected Range: Values >= {pressureTrackBar1.Value}";
            }
            else if (pressureMaxButton.Checked)
            {
                pressureRangeLabel.Text = $"Selected Range: Values <= {pressureTrackBar1.Value}";
            }
        }

        private void windTrackBar1_ValueChanged(object sender, EventArgs e)
        {
            windRangeLabel.Visible = true;
            if (windMinButton.Checked)
            {
                windRangeLabel.Text = $"Selected Range: Values >= {windTrackBar1.Value}";
            }
            else if (windMaxButton.Checked)
            {
                windRangeLabel.Text = $"Selected Range: Values <= {windTrackBar1.Value}";
            }
        }
        private void visibilitytrackBar1_ValueChanged(object sender, EventArgs e)
        {
            visibilityRangeLabel.Visible = true;
            if (visibilityMinButton.Checked)
            {
                visibilityRangeLabel.Text = $"Selected Range: Values >= {visibilitytrackBar1.Value}";
            }
            else if (visibilityMaxButton.Checked)
            {
                visibilityRangeLabel.Text = $"Selected Range: Values <= {visibilitytrackBar1.Value}";
            }
        }
        private void humidityBox_CheckedChanged(object sender, EventArgs e)
        {
            if (humidityBox.Checked)
            {
                humidityTrackBar1.Visible = true;
                humidityMinButton.Visible = true;
                humidityMaxButton.Visible = true;
                humidityMinLabel.Visible = true;
                humidityMaxLabel.Visible = true;
                humidityRangeLabel.BringToFront();
            }
            else
            {
                humidityTrackBar1.Visible = false;
                humidityRangeLabel.Visible = false;
                humidityMinButton.Visible = false;
                humidityMaxButton.Visible = false;
                humidityMinLabel.Visible = false;
                humidityMaxLabel.Visible = false;
            }
        }

        private void Visibility_CheckedChanged(object sender, EventArgs e)
        {
            if (visibilityBox.Checked)
            {
                visibilitytrackBar1.Visible = true;
                visibilityMinButton.Visible = true;
                visibilityMaxButton.Visible = true;
                visibilityMinLabel.Visible = true;
                visibilityMaxLabel.Visible = true;
                visibilityRangeLabel.BringToFront();
            }
            else
            {
                visibilitytrackBar1.Visible = false;
                visibilityRangeLabel.Visible = false;
                visibilityMinButton.Visible = false;
                visibilityMaxButton.Visible = false;
                visibilityMinLabel.Visible = false;
                visibilityMaxLabel.Visible = false;
            }
        }

        private void windBox_CheckedChanged(object sender, EventArgs e)
        {
            if (windBox.Checked)
            {
                windTrackBar1.Visible = true;
                windMinButton.Visible = true;
                windMaxButton.Visible = true;
                windMinLabel.Visible = true;
                windMaxLabel.Visible = true;
                windRangeLabel.BringToFront();
            }
            else
            {
                windTrackBar1.Visible = false;
                windRangeLabel.Visible = false;
                windMinButton.Visible = false;
                windMaxButton.Visible = false;
                windMinLabel.Visible = false;
                windMaxLabel.Visible = false;
            }
        }

        private void pressureBox_CheckedChanged(object sender, EventArgs e)
        {
            if (pressureBox.Checked)
            {
                pressureMinButton.Visible = true;
                pressureMaxButton.Visible = true;
                pressureTrackBar1.Visible = true;
                pressureMinLabel.Visible = true;
                pressureMaxLabel.Visible = true;
                pressureRangeLabel.BringToFront();
            }
            else
            {
                pressureTrackBar1.Visible = false;
                pressureRangeLabel.Visible = false;
                pressureMinButton.Visible = false;
                pressureMaxButton.Visible = false;
                pressureMinLabel.Visible = false;
                pressureMaxLabel.Visible = false;
            }
        }

        private void conditionBox_CheckedChanged(object sender, EventArgs e)
        {

            string[] weatherConditions = {
                "Thunderstorm With Light Rain",
                "Thunderstorm With Rain",
                "Thunderstorm With Heavy Rain",
                "Light Thunderstorm",
                "Thunderstorm",
                "Heavy Thunderstorm",
                "Ragged Thunderstorm",
                "Thunderstorm With Light Drizzle",
                "Thunderstorm With Drizzle",
                "Thunderstorm With Heavy Drizzle",
                "Light Intensity Drizzle",
                "Drizzle",
                "Heavy Intensity Drizzle",
                "Light Intensity Drizzle Rain",
                "Drizzle Rain",
                "Heavy Intensity Drizzle Rain",
                "Shower Rain and Drizzle",
                "Heavy Shower Rain and Drizzle",
                "Shower Drizzle",
                "Light Rain",
                "Moderate Rain",
                "Heavy Intensity Rain",
                "Very Heavy Rain",
                "Extreme Rain",
                "Freezing Rain",
                "Light Intensity Shower Rain",
                "Shower Rain",
                "Heavy Intensity Shower Rain",
                "Ragged Shower Rain",
                "Light Snow",
                "Snow",
                "Heavy Snow",
                "Sleet",
                "Light Shower Sleet",
                "Shower Sleet",
                "Light Rain and Snow",
                "Rain and Snow",
                "Light Shower Snow",
                "Shower Snow",
                "Heavy Shower Snow",
                "Mist",
                "Smoke",
                "Haze",
                "Sand/Dust Whirls",
                "Fog",
                "Sand",
                "Dust",
                "Volcanic Ash",
                "Squalls",
                "Tornado",
                "Clear Sky",
                "Few Clouds: 11-25%",
                "Scattered Clouds: 25-50%",
                "Broken Clouds: 51-84%",
                "Overcast Clouds: 85-100%"
            };
            if (conditionBox.Checked)
            {
                conditionComboBox.Visible = true;
                foreach (string condition in weatherConditions)
                {
                    conditionComboBox.Items.Add(condition);
                }
            }
            else
            {
                conditionComboBox.Visible = false;
                conditionComboBox.Items.Clear();
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            foreach (CheckBox checkBox in checkBoxes)
            {
                checkBox.Checked = false;
            }
            tempMaxButton.Checked = false;
            tempMinButton.Checked = false;
            windMaxButton.Checked = false;
            windMinButton.Checked = false;
            pressureMaxButton.Checked = false;
            pressureMinButton.Checked = false;
            humidityMaxButton.Checked = false;
            humidityMinButton.Checked = false;
            visibilityMaxButton.Checked = false;
            visibilityMinButton.Checked = false;
        }

        private void expandButton_Click(object sender, EventArgs e)
        {
            foreach (CheckBox checkBox in checkBoxes)
            {
                checkBox.Checked = true;
            }
        }
    }
}

