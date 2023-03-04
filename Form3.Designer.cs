namespace Project_2
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cityCheckBox = new System.Windows.Forms.CheckBox();
            this.stateCheckBox = new System.Windows.Forms.CheckBox();
            this.regionCheckBox = new System.Windows.Forms.CheckBox();
            this.tempCheckBox = new System.Windows.Forms.CheckBox();
            this.earlyCheckBox = new System.Windows.Forms.CheckBox();
            this.lateCheckBox = new System.Windows.Forms.CheckBox();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.expandButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.pressureBox = new System.Windows.Forms.CheckBox();
            this.windBox = new System.Windows.Forms.CheckBox();
            this.visibilityBox = new System.Windows.Forms.CheckBox();
            this.humidityBox = new System.Windows.Forms.CheckBox();
            this.conditionBox = new System.Windows.Forms.CheckBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.earlyDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.stateBox = new System.Windows.Forms.ComboBox();
            this.regionBox = new System.Windows.Forms.ComboBox();
            this.conditionComboBox = new System.Windows.Forms.ComboBox();
            this.humidityTrackBar1 = new System.Windows.Forms.TrackBar();
            this.tempTrackBar1 = new System.Windows.Forms.TrackBar();
            this.humidityRangeLabel = new System.Windows.Forms.Label();
            this.tempRangeLabel = new System.Windows.Forms.Label();
            this.visibilitytrackBar1 = new System.Windows.Forms.TrackBar();
            this.visibilityRangeLabel = new System.Windows.Forms.Label();
            this.windTrackBar1 = new System.Windows.Forms.TrackBar();
            this.windRangeLabel = new System.Windows.Forms.Label();
            this.pressureTrackBar1 = new System.Windows.Forms.TrackBar();
            this.pressureRangeLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tempMinButton = new System.Windows.Forms.RadioButton();
            this.tempMaxButton = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.humidityMinButton = new System.Windows.Forms.RadioButton();
            this.humidityMaxButton = new System.Windows.Forms.RadioButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.visibilityMinButton = new System.Windows.Forms.RadioButton();
            this.visibilityMaxButton = new System.Windows.Forms.RadioButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.windMinButton = new System.Windows.Forms.RadioButton();
            this.windMaxButton = new System.Windows.Forms.RadioButton();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pressureMinButton = new System.Windows.Forms.RadioButton();
            this.pressureMaxButton = new System.Windows.Forms.RadioButton();
            this.humidityMinLabel = new System.Windows.Forms.Label();
            this.humidityMaxLabel = new System.Windows.Forms.Label();
            this.visibilityMinLabel = new System.Windows.Forms.Label();
            this.windMinLabel = new System.Windows.Forms.Label();
            this.tempMinLabel = new System.Windows.Forms.Label();
            this.tempMaxLabel = new System.Windows.Forms.Label();
            this.visibilityMaxLabel = new System.Windows.Forms.Label();
            this.windMaxLabel = new System.Windows.Forms.Label();
            this.pressureMinLabel = new System.Windows.Forms.Label();
            this.pressureMaxLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.humidityTrackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempTrackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visibilitytrackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.windTrackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pressureTrackBar1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // cityCheckBox
            // 
            this.cityCheckBox.AutoSize = true;
            this.cityCheckBox.BackColor = System.Drawing.SystemColors.Control;
            this.cityCheckBox.Location = new System.Drawing.Point(12, 58);
            this.cityCheckBox.Name = "cityCheckBox";
            this.cityCheckBox.Size = new System.Drawing.Size(47, 19);
            this.cityCheckBox.TabIndex = 0;
            this.cityCheckBox.Text = "City";
            this.cityCheckBox.UseVisualStyleBackColor = false;
            this.cityCheckBox.CheckedChanged += new System.EventHandler(this.cityCheckBox_CheckedChanged);
            // 
            // stateCheckBox
            // 
            this.stateCheckBox.AutoSize = true;
            this.stateCheckBox.Location = new System.Drawing.Point(12, 83);
            this.stateCheckBox.Name = "stateCheckBox";
            this.stateCheckBox.Size = new System.Drawing.Size(52, 19);
            this.stateCheckBox.TabIndex = 1;
            this.stateCheckBox.Text = "State";
            this.stateCheckBox.UseVisualStyleBackColor = true;
            this.stateCheckBox.CheckedChanged += new System.EventHandler(this.stateCheckBox_CheckedChanged);
            // 
            // regionCheckBox
            // 
            this.regionCheckBox.AutoSize = true;
            this.regionCheckBox.Location = new System.Drawing.Point(12, 108);
            this.regionCheckBox.Name = "regionCheckBox";
            this.regionCheckBox.Size = new System.Drawing.Size(63, 19);
            this.regionCheckBox.TabIndex = 2;
            this.regionCheckBox.Text = "Region";
            this.regionCheckBox.UseVisualStyleBackColor = true;
            this.regionCheckBox.CheckedChanged += new System.EventHandler(this.regionCheckBox_CheckedChanged);
            // 
            // tempCheckBox
            // 
            this.tempCheckBox.AutoSize = true;
            this.tempCheckBox.Location = new System.Drawing.Point(12, 133);
            this.tempCheckBox.Name = "tempCheckBox";
            this.tempCheckBox.Size = new System.Drawing.Size(94, 19);
            this.tempCheckBox.TabIndex = 3;
            this.tempCheckBox.Text = "Temp Range ";
            this.tempCheckBox.UseVisualStyleBackColor = true;
            this.tempCheckBox.CheckedChanged += new System.EventHandler(this.tempCheckBox_CheckedChanged);
            // 
            // earlyCheckBox
            // 
            this.earlyCheckBox.AutoSize = true;
            this.earlyCheckBox.Location = new System.Drawing.Point(12, 187);
            this.earlyCheckBox.Name = "earlyCheckBox";
            this.earlyCheckBox.Size = new System.Drawing.Size(90, 19);
            this.earlyCheckBox.TabIndex = 4;
            this.earlyCheckBox.Text = "Earliest Date";
            this.earlyCheckBox.UseVisualStyleBackColor = true;
            this.earlyCheckBox.CheckedChanged += new System.EventHandler(this.earlyCheckBox_CheckedChanged);
            // 
            // lateCheckBox
            // 
            this.lateCheckBox.AutoSize = true;
            this.lateCheckBox.Location = new System.Drawing.Point(12, 212);
            this.lateCheckBox.Name = "lateCheckBox";
            this.lateCheckBox.Size = new System.Drawing.Size(84, 19);
            this.lateCheckBox.TabIndex = 6;
            this.lateCheckBox.Text = "Latest Date";
            this.lateCheckBox.UseVisualStyleBackColor = true;
            this.lateCheckBox.CheckedChanged += new System.EventHandler(this.lateCheckBox_CheckedChanged);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(626, 10);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 7;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(707, 10);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(346, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Select Criteria";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.expandButton);
            this.panel1.Controls.Add(this.clearButton);
            this.panel1.Controls.Add(this.cancelButton);
            this.panel1.Controls.Add(this.okButton);
            this.panel1.Location = new System.Drawing.Point(1, 477);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(796, 43);
            this.panel1.TabIndex = 23;
            // 
            // expandButton
            // 
            this.expandButton.Location = new System.Drawing.Point(464, 10);
            this.expandButton.Name = "expandButton";
            this.expandButton.Size = new System.Drawing.Size(75, 23);
            this.expandButton.TabIndex = 10;
            this.expandButton.Text = "Expand All";
            this.expandButton.UseVisualStyleBackColor = true;
            this.expandButton.Click += new System.EventHandler(this.expandButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(545, 10);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 9;
            this.clearButton.Text = "Clear All";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // pressureBox
            // 
            this.pressureBox.AutoSize = true;
            this.pressureBox.Location = new System.Drawing.Point(12, 415);
            this.pressureBox.Name = "pressureBox";
            this.pressureBox.Size = new System.Drawing.Size(93, 19);
            this.pressureBox.TabIndex = 29;
            this.pressureBox.Text = "Pressure hPa";
            this.pressureBox.UseVisualStyleBackColor = true;
            this.pressureBox.CheckedChanged += new System.EventHandler(this.pressureBox_CheckedChanged);
            // 
            // windBox
            // 
            this.windBox.AutoSize = true;
            this.windBox.Location = new System.Drawing.Point(12, 365);
            this.windBox.Name = "windBox";
            this.windBox.Size = new System.Drawing.Size(89, 19);
            this.windBox.TabIndex = 27;
            this.windBox.Text = "Wind Speed";
            this.windBox.UseVisualStyleBackColor = true;
            this.windBox.CheckedChanged += new System.EventHandler(this.windBox_CheckedChanged);
            // 
            // visibilityBox
            // 
            this.visibilityBox.AutoSize = true;
            this.visibilityBox.Location = new System.Drawing.Point(12, 309);
            this.visibilityBox.Name = "visibilityBox";
            this.visibilityBox.Size = new System.Drawing.Size(101, 19);
            this.visibilityBox.TabIndex = 26;
            this.visibilityBox.Text = "Visibility Miles";
            this.visibilityBox.UseVisualStyleBackColor = true;
            this.visibilityBox.CheckedChanged += new System.EventHandler(this.Visibility_CheckedChanged);
            // 
            // humidityBox
            // 
            this.humidityBox.AutoSize = true;
            this.humidityBox.Location = new System.Drawing.Point(12, 262);
            this.humidityBox.Name = "humidityBox";
            this.humidityBox.Size = new System.Drawing.Size(89, 19);
            this.humidityBox.TabIndex = 25;
            this.humidityBox.Text = "Humidity %";
            this.humidityBox.UseVisualStyleBackColor = true;
            this.humidityBox.CheckedChanged += new System.EventHandler(this.humidityBox_CheckedChanged);
            // 
            // conditionBox
            // 
            this.conditionBox.AutoSize = true;
            this.conditionBox.BackColor = System.Drawing.SystemColors.Control;
            this.conditionBox.Location = new System.Drawing.Point(12, 237);
            this.conditionBox.Name = "conditionBox";
            this.conditionBox.Size = new System.Drawing.Size(79, 19);
            this.conditionBox.TabIndex = 24;
            this.conditionBox.Text = "Condition";
            this.conditionBox.UseVisualStyleBackColor = false;
            this.conditionBox.CheckedChanged += new System.EventHandler(this.conditionBox_CheckedChanged);
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(274, 54);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(175, 23);
            this.cityTextBox.TabIndex = 10;
            this.cityTextBox.Visible = false;
            this.cityTextBox.TextChanged += new System.EventHandler(this.cityTextBox_TextChanged);
            // 
            // earlyDateTimePicker
            // 
            this.earlyDateTimePicker.Location = new System.Drawing.Point(274, 182);
            this.earlyDateTimePicker.Name = "earlyDateTimePicker";
            this.earlyDateTimePicker.Size = new System.Drawing.Size(199, 23);
            this.earlyDateTimePicker.TabIndex = 19;
            this.earlyDateTimePicker.Visible = false;
            // 
            // lateDateTimePicker
            // 
            this.lateDateTimePicker.Location = new System.Drawing.Point(274, 207);
            this.lateDateTimePicker.Name = "lateDateTimePicker";
            this.lateDateTimePicker.Size = new System.Drawing.Size(199, 23);
            this.lateDateTimePicker.TabIndex = 20;
            this.lateDateTimePicker.Visible = false;
            // 
            // stateBox
            // 
            this.stateBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.stateBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.stateBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stateBox.FormattingEnabled = true;
            this.stateBox.Location = new System.Drawing.Point(274, 79);
            this.stateBox.Name = "stateBox";
            this.stateBox.Size = new System.Drawing.Size(175, 23);
            this.stateBox.TabIndex = 21;
            this.stateBox.Visible = false;
            // 
            // regionBox
            // 
            this.regionBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.regionBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.regionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.regionBox.FormattingEnabled = true;
            this.regionBox.Location = new System.Drawing.Point(274, 106);
            this.regionBox.Name = "regionBox";
            this.regionBox.Size = new System.Drawing.Size(175, 23);
            this.regionBox.TabIndex = 22;
            this.regionBox.Visible = false;
            // 
            // conditionComboBox
            // 
            this.conditionComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.conditionComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.conditionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.conditionComboBox.FormattingEnabled = true;
            this.conditionComboBox.Location = new System.Drawing.Point(274, 234);
            this.conditionComboBox.Name = "conditionComboBox";
            this.conditionComboBox.Size = new System.Drawing.Size(175, 23);
            this.conditionComboBox.TabIndex = 31;
            this.conditionComboBox.Visible = false;
            // 
            // humidityTrackBar1
            // 
            this.humidityTrackBar1.Location = new System.Drawing.Point(274, 261);
            this.humidityTrackBar1.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.humidityTrackBar1.Maximum = 100;
            this.humidityTrackBar1.Name = "humidityTrackBar1";
            this.humidityTrackBar1.Size = new System.Drawing.Size(509, 45);
            this.humidityTrackBar1.TabIndex = 32;
            this.humidityTrackBar1.Visible = false;
            this.humidityTrackBar1.ValueChanged += new System.EventHandler(this.humidityTrackBar2_ValueChanged);
            // 
            // tempTrackBar1
            // 
            this.tempTrackBar1.Location = new System.Drawing.Point(274, 132);
            this.tempTrackBar1.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.tempTrackBar1.Maximum = 150;
            this.tempTrackBar1.Minimum = -130;
            this.tempTrackBar1.Name = "tempTrackBar1";
            this.tempTrackBar1.Size = new System.Drawing.Size(509, 45);
            this.tempTrackBar1.TabIndex = 34;
            this.tempTrackBar1.Value = -130;
            this.tempTrackBar1.Visible = false;
            this.tempTrackBar1.ValueChanged += new System.EventHandler(this.tempTrackBar1_ValueChanged);
            // 
            // humidityRangeLabel
            // 
            this.humidityRangeLabel.AutoSize = true;
            this.humidityRangeLabel.Location = new System.Drawing.Point(431, 291);
            this.humidityRangeLabel.Name = "humidityRangeLabel";
            this.humidityRangeLabel.Size = new System.Drawing.Size(90, 15);
            this.humidityRangeLabel.TabIndex = 36;
            this.humidityRangeLabel.Text = "Selected Range:";
            this.humidityRangeLabel.Visible = false;
            // 
            // tempRangeLabel
            // 
            this.tempRangeLabel.AutoSize = true;
            this.tempRangeLabel.Location = new System.Drawing.Point(478, 114);
            this.tempRangeLabel.Name = "tempRangeLabel";
            this.tempRangeLabel.Size = new System.Drawing.Size(90, 15);
            this.tempRangeLabel.TabIndex = 37;
            this.tempRangeLabel.Text = "Selected Range:";
            this.tempRangeLabel.Visible = false;
            // 
            // visibilitytrackBar1
            // 
            this.visibilitytrackBar1.Location = new System.Drawing.Point(274, 309);
            this.visibilitytrackBar1.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.visibilitytrackBar1.Maximum = 7;
            this.visibilitytrackBar1.Name = "visibilitytrackBar1";
            this.visibilitytrackBar1.Size = new System.Drawing.Size(509, 45);
            this.visibilitytrackBar1.TabIndex = 38;
            this.visibilitytrackBar1.Visible = false;
            this.visibilitytrackBar1.ValueChanged += new System.EventHandler(this.visibilitytrackBar1_ValueChanged);
            // 
            // visibilityRangeLabel
            // 
            this.visibilityRangeLabel.AutoSize = true;
            this.visibilityRangeLabel.Location = new System.Drawing.Point(431, 342);
            this.visibilityRangeLabel.Name = "visibilityRangeLabel";
            this.visibilityRangeLabel.Size = new System.Drawing.Size(90, 15);
            this.visibilityRangeLabel.TabIndex = 40;
            this.visibilityRangeLabel.Text = "Selected Range:";
            this.visibilityRangeLabel.Visible = false;
            // 
            // windTrackBar1
            // 
            this.windTrackBar1.Location = new System.Drawing.Point(274, 360);
            this.windTrackBar1.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.windTrackBar1.Maximum = 100;
            this.windTrackBar1.Name = "windTrackBar1";
            this.windTrackBar1.Size = new System.Drawing.Size(509, 45);
            this.windTrackBar1.TabIndex = 41;
            this.windTrackBar1.Visible = false;
            this.windTrackBar1.ValueChanged += new System.EventHandler(this.windTrackBar1_ValueChanged);
            // 
            // windRangeLabel
            // 
            this.windRangeLabel.AutoSize = true;
            this.windRangeLabel.Location = new System.Drawing.Point(431, 390);
            this.windRangeLabel.Name = "windRangeLabel";
            this.windRangeLabel.Size = new System.Drawing.Size(90, 15);
            this.windRangeLabel.TabIndex = 43;
            this.windRangeLabel.Text = "Selected Range:";
            this.windRangeLabel.Visible = false;
            // 
            // pressureTrackBar1
            // 
            this.pressureTrackBar1.Location = new System.Drawing.Point(274, 411);
            this.pressureTrackBar1.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.pressureTrackBar1.Maximum = 1050;
            this.pressureTrackBar1.Minimum = 950;
            this.pressureTrackBar1.Name = "pressureTrackBar1";
            this.pressureTrackBar1.Size = new System.Drawing.Size(509, 45);
            this.pressureTrackBar1.TabIndex = 44;
            this.pressureTrackBar1.Value = 950;
            this.pressureTrackBar1.Visible = false;
            this.pressureTrackBar1.ValueChanged += new System.EventHandler(this.pressureTrackBar1_ValueChanged);
            // 
            // pressureRangeLabel
            // 
            this.pressureRangeLabel.AutoSize = true;
            this.pressureRangeLabel.Location = new System.Drawing.Point(431, 441);
            this.pressureRangeLabel.Name = "pressureRangeLabel";
            this.pressureRangeLabel.Size = new System.Drawing.Size(90, 15);
            this.pressureRangeLabel.TabIndex = 46;
            this.pressureRangeLabel.Text = "Selected Range:";
            this.pressureRangeLabel.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tempMinButton);
            this.panel2.Controls.Add(this.tempMaxButton);
            this.panel2.Location = new System.Drawing.Point(112, 130);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(135, 34);
            this.panel2.TabIndex = 57;
            // 
            // tempMinButton
            // 
            this.tempMinButton.AutoSize = true;
            this.tempMinButton.Location = new System.Drawing.Point(3, 3);
            this.tempMinButton.Name = "tempMinButton";
            this.tempMinButton.Size = new System.Drawing.Size(46, 19);
            this.tempMinButton.TabIndex = 55;
            this.tempMinButton.TabStop = true;
            this.tempMinButton.Text = "Min";
            this.tempMinButton.UseVisualStyleBackColor = true;
            this.tempMinButton.Visible = false;
            // 
            // tempMaxButton
            // 
            this.tempMaxButton.AutoSize = true;
            this.tempMaxButton.Location = new System.Drawing.Point(80, 3);
            this.tempMaxButton.Name = "tempMaxButton";
            this.tempMaxButton.Size = new System.Drawing.Size(48, 19);
            this.tempMaxButton.TabIndex = 56;
            this.tempMaxButton.TabStop = true;
            this.tempMaxButton.Text = "Max";
            this.tempMaxButton.UseVisualStyleBackColor = true;
            this.tempMaxButton.Visible = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.humidityMinButton);
            this.panel3.Controls.Add(this.humidityMaxButton);
            this.panel3.Location = new System.Drawing.Point(112, 258);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(135, 34);
            this.panel3.TabIndex = 58;
            // 
            // humidityMinButton
            // 
            this.humidityMinButton.AutoSize = true;
            this.humidityMinButton.Location = new System.Drawing.Point(3, 3);
            this.humidityMinButton.Name = "humidityMinButton";
            this.humidityMinButton.Size = new System.Drawing.Size(46, 19);
            this.humidityMinButton.TabIndex = 55;
            this.humidityMinButton.TabStop = true;
            this.humidityMinButton.Text = "Min";
            this.humidityMinButton.UseVisualStyleBackColor = true;
            this.humidityMinButton.Visible = false;
            // 
            // humidityMaxButton
            // 
            this.humidityMaxButton.AutoSize = true;
            this.humidityMaxButton.Location = new System.Drawing.Point(80, 3);
            this.humidityMaxButton.Name = "humidityMaxButton";
            this.humidityMaxButton.Size = new System.Drawing.Size(48, 19);
            this.humidityMaxButton.TabIndex = 56;
            this.humidityMaxButton.TabStop = true;
            this.humidityMaxButton.Text = "Max";
            this.humidityMaxButton.UseVisualStyleBackColor = true;
            this.humidityMaxButton.Visible = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.visibilityMinButton);
            this.panel4.Controls.Add(this.visibilityMaxButton);
            this.panel4.Location = new System.Drawing.Point(112, 306);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(135, 34);
            this.panel4.TabIndex = 58;
            // 
            // visibilityMinButton
            // 
            this.visibilityMinButton.AutoSize = true;
            this.visibilityMinButton.Location = new System.Drawing.Point(3, 3);
            this.visibilityMinButton.Name = "visibilityMinButton";
            this.visibilityMinButton.Size = new System.Drawing.Size(46, 19);
            this.visibilityMinButton.TabIndex = 55;
            this.visibilityMinButton.TabStop = true;
            this.visibilityMinButton.Text = "Min";
            this.visibilityMinButton.UseVisualStyleBackColor = true;
            this.visibilityMinButton.Visible = false;
            // 
            // visibilityMaxButton
            // 
            this.visibilityMaxButton.AutoSize = true;
            this.visibilityMaxButton.Location = new System.Drawing.Point(80, 3);
            this.visibilityMaxButton.Name = "visibilityMaxButton";
            this.visibilityMaxButton.Size = new System.Drawing.Size(48, 19);
            this.visibilityMaxButton.TabIndex = 56;
            this.visibilityMaxButton.TabStop = true;
            this.visibilityMaxButton.Text = "Max";
            this.visibilityMaxButton.UseVisualStyleBackColor = true;
            this.visibilityMaxButton.Visible = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.windMinButton);
            this.panel5.Controls.Add(this.windMaxButton);
            this.panel5.Location = new System.Drawing.Point(112, 360);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(135, 34);
            this.panel5.TabIndex = 58;
            // 
            // windMinButton
            // 
            this.windMinButton.AutoSize = true;
            this.windMinButton.Location = new System.Drawing.Point(3, 3);
            this.windMinButton.Name = "windMinButton";
            this.windMinButton.Size = new System.Drawing.Size(46, 19);
            this.windMinButton.TabIndex = 55;
            this.windMinButton.TabStop = true;
            this.windMinButton.Text = "Min";
            this.windMinButton.UseVisualStyleBackColor = true;
            this.windMinButton.Visible = false;
            // 
            // windMaxButton
            // 
            this.windMaxButton.AutoSize = true;
            this.windMaxButton.Location = new System.Drawing.Point(80, 3);
            this.windMaxButton.Name = "windMaxButton";
            this.windMaxButton.Size = new System.Drawing.Size(48, 19);
            this.windMaxButton.TabIndex = 56;
            this.windMaxButton.TabStop = true;
            this.windMaxButton.Text = "Max";
            this.windMaxButton.UseVisualStyleBackColor = true;
            this.windMaxButton.Visible = false;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.pressureMinButton);
            this.panel6.Controls.Add(this.pressureMaxButton);
            this.panel6.Location = new System.Drawing.Point(112, 408);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(135, 34);
            this.panel6.TabIndex = 58;
            // 
            // pressureMinButton
            // 
            this.pressureMinButton.AutoSize = true;
            this.pressureMinButton.Location = new System.Drawing.Point(3, 3);
            this.pressureMinButton.Name = "pressureMinButton";
            this.pressureMinButton.Size = new System.Drawing.Size(46, 19);
            this.pressureMinButton.TabIndex = 55;
            this.pressureMinButton.TabStop = true;
            this.pressureMinButton.Text = "Min";
            this.pressureMinButton.UseVisualStyleBackColor = true;
            this.pressureMinButton.Visible = false;
            // 
            // pressureMaxButton
            // 
            this.pressureMaxButton.AutoSize = true;
            this.pressureMaxButton.Location = new System.Drawing.Point(80, 3);
            this.pressureMaxButton.Name = "pressureMaxButton";
            this.pressureMaxButton.Size = new System.Drawing.Size(48, 19);
            this.pressureMaxButton.TabIndex = 56;
            this.pressureMaxButton.TabStop = true;
            this.pressureMaxButton.Text = "Max";
            this.pressureMaxButton.UseVisualStyleBackColor = true;
            this.pressureMaxButton.Visible = false;
            // 
            // humidityMinLabel
            // 
            this.humidityMinLabel.AutoSize = true;
            this.humidityMinLabel.Location = new System.Drawing.Point(281, 291);
            this.humidityMinLabel.Name = "humidityMinLabel";
            this.humidityMinLabel.Size = new System.Drawing.Size(13, 15);
            this.humidityMinLabel.TabIndex = 59;
            this.humidityMinLabel.Text = "0";
            this.humidityMinLabel.Visible = false;
            // 
            // humidityMaxLabel
            // 
            this.humidityMaxLabel.AutoSize = true;
            this.humidityMaxLabel.Location = new System.Drawing.Point(758, 291);
            this.humidityMaxLabel.Name = "humidityMaxLabel";
            this.humidityMaxLabel.Size = new System.Drawing.Size(25, 15);
            this.humidityMaxLabel.TabIndex = 60;
            this.humidityMaxLabel.Text = "100";
            this.humidityMaxLabel.Visible = false;
            // 
            // visibilityMinLabel
            // 
            this.visibilityMinLabel.AutoSize = true;
            this.visibilityMinLabel.Location = new System.Drawing.Point(281, 339);
            this.visibilityMinLabel.Name = "visibilityMinLabel";
            this.visibilityMinLabel.Size = new System.Drawing.Size(13, 15);
            this.visibilityMinLabel.TabIndex = 61;
            this.visibilityMinLabel.Text = "0";
            this.visibilityMinLabel.Visible = false;
            // 
            // windMinLabel
            // 
            this.windMinLabel.AutoSize = true;
            this.windMinLabel.Location = new System.Drawing.Point(281, 390);
            this.windMinLabel.Name = "windMinLabel";
            this.windMinLabel.Size = new System.Drawing.Size(13, 15);
            this.windMinLabel.TabIndex = 62;
            this.windMinLabel.Text = "0";
            this.windMinLabel.Visible = false;
            // 
            // tempMinLabel
            // 
            this.tempMinLabel.AutoSize = true;
            this.tempMinLabel.Location = new System.Drawing.Point(274, 162);
            this.tempMinLabel.Name = "tempMinLabel";
            this.tempMinLabel.Size = new System.Drawing.Size(30, 15);
            this.tempMinLabel.TabIndex = 63;
            this.tempMinLabel.Text = "-130";
            this.tempMinLabel.Visible = false;
            // 
            // tempMaxLabel
            // 
            this.tempMaxLabel.AutoSize = true;
            this.tempMaxLabel.Location = new System.Drawing.Point(758, 162);
            this.tempMaxLabel.Name = "tempMaxLabel";
            this.tempMaxLabel.Size = new System.Drawing.Size(25, 15);
            this.tempMaxLabel.TabIndex = 64;
            this.tempMaxLabel.Text = "150";
            this.tempMaxLabel.Visible = false;
            // 
            // visibilityMaxLabel
            // 
            this.visibilityMaxLabel.AutoSize = true;
            this.visibilityMaxLabel.Location = new System.Drawing.Point(763, 342);
            this.visibilityMaxLabel.Name = "visibilityMaxLabel";
            this.visibilityMaxLabel.Size = new System.Drawing.Size(13, 15);
            this.visibilityMaxLabel.TabIndex = 65;
            this.visibilityMaxLabel.Text = "7";
            this.visibilityMaxLabel.Visible = false;
            // 
            // windMaxLabel
            // 
            this.windMaxLabel.AutoSize = true;
            this.windMaxLabel.Location = new System.Drawing.Point(758, 393);
            this.windMaxLabel.Name = "windMaxLabel";
            this.windMaxLabel.Size = new System.Drawing.Size(25, 15);
            this.windMaxLabel.TabIndex = 66;
            this.windMaxLabel.Text = "100";
            this.windMaxLabel.Visible = false;
            // 
            // pressureMinLabel
            // 
            this.pressureMinLabel.AutoSize = true;
            this.pressureMinLabel.Location = new System.Drawing.Point(281, 441);
            this.pressureMinLabel.Name = "pressureMinLabel";
            this.pressureMinLabel.Size = new System.Drawing.Size(25, 15);
            this.pressureMinLabel.TabIndex = 67;
            this.pressureMinLabel.Text = "950";
            this.pressureMinLabel.Visible = false;
            // 
            // pressureMaxLabel
            // 
            this.pressureMaxLabel.AutoSize = true;
            this.pressureMaxLabel.Location = new System.Drawing.Point(752, 441);
            this.pressureMaxLabel.Name = "pressureMaxLabel";
            this.pressureMaxLabel.Size = new System.Drawing.Size(31, 15);
            this.pressureMaxLabel.TabIndex = 68;
            this.pressureMaxLabel.Text = "1050";
            this.pressureMaxLabel.Visible = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(791, 520);
            this.Controls.Add(this.pressureMaxLabel);
            this.Controls.Add(this.pressureMinLabel);
            this.Controls.Add(this.windMaxLabel);
            this.Controls.Add(this.visibilityMaxLabel);
            this.Controls.Add(this.tempMaxLabel);
            this.Controls.Add(this.tempMinLabel);
            this.Controls.Add(this.windMinLabel);
            this.Controls.Add(this.visibilityMinLabel);
            this.Controls.Add(this.humidityMaxLabel);
            this.Controls.Add(this.humidityMinLabel);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pressureRangeLabel);
            this.Controls.Add(this.pressureTrackBar1);
            this.Controls.Add(this.windRangeLabel);
            this.Controls.Add(this.windTrackBar1);
            this.Controls.Add(this.visibilityRangeLabel);
            this.Controls.Add(this.visibilitytrackBar1);
            this.Controls.Add(this.tempRangeLabel);
            this.Controls.Add(this.humidityRangeLabel);
            this.Controls.Add(this.tempTrackBar1);
            this.Controls.Add(this.humidityTrackBar1);
            this.Controls.Add(this.conditionComboBox);
            this.Controls.Add(this.pressureBox);
            this.Controls.Add(this.windBox);
            this.Controls.Add(this.visibilityBox);
            this.Controls.Add(this.humidityBox);
            this.Controls.Add(this.conditionBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.regionBox);
            this.Controls.Add(this.stateBox);
            this.Controls.Add(this.lateDateTimePicker);
            this.Controls.Add(this.earlyDateTimePicker);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lateCheckBox);
            this.Controls.Add(this.earlyCheckBox);
            this.Controls.Add(this.tempCheckBox);
            this.Controls.Add(this.regionCheckBox);
            this.Controls.Add(this.stateCheckBox);
            this.Controls.Add(this.cityCheckBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form3";
            this.Text = "Advanced Filter ";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.humidityTrackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempTrackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visibilitytrackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.windTrackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pressureTrackBar1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox cityCheckBox;
        private CheckBox stateCheckBox;
        private CheckBox regionCheckBox;
        private CheckBox tempCheckBox;
        private CheckBox earlyCheckBox;
        private CheckBox lateCheckBox;
        private Button okButton;
        private Button cancelButton;
        private Label label1;
        private Panel panel1;
        private CheckBox pressureBox;
        private CheckBox windBox;
        private CheckBox visibilityBox;
        private CheckBox humidityBox;
        private CheckBox conditionBox;
        private TextBox cityTextBox;
        private DateTimePicker earlyDateTimePicker;
        private DateTimePicker lateDateTimePicker;
        private ComboBox stateBox;
        private ComboBox regionBox;
        private ComboBox conditionComboBox;
        private TrackBar humidityTrackBar1;
        private TrackBar tempTrackBar1;
        private Label humidityRangeLabel;
        private Label tempRangeLabel;
        private TrackBar visibilitytrackBar1;
        private Label visibilityRangeLabel;
        private TrackBar windTrackBar1;
        private Label windRangeLabel;
        private TrackBar pressureTrackBar1;
        private Label pressureRangeLabel;
        private Panel panel2;
        private RadioButton tempMinButton;
        private RadioButton tempMaxButton;
        private Panel panel3;
        private RadioButton humidityMinButton;
        private RadioButton humidityMaxButton;
        private Panel panel4;
        private RadioButton visibilityMinButton;
        private RadioButton visibilityMaxButton;
        private Panel panel5;
        private RadioButton windMinButton;
        private RadioButton windMaxButton;
        private Panel panel6;
        private RadioButton pressureMinButton;
        private RadioButton pressureMaxButton;
        private Label humidityMinLabel;
        private Label humidityMaxLabel;
        private Label visibilityMinLabel;
        private Label windMinLabel;
        private Label tempMinLabel;
        private Label tempMaxLabel;
        private Label visibilityMaxLabel;
        private Label windMaxLabel;
        private Label pressureMinLabel;
        private Label pressureMaxLabel;
        private Button expandButton;
        private Button clearButton;
    }
}