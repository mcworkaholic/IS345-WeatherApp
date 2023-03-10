namespace Project_2
{
    partial class WeatherForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WeatherForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.removeButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.highButton = new System.Windows.Forms.Button();
            this.lowButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.weatherBox = new System.Windows.Forms.GroupBox();
            this.newButton = new System.Windows.Forms.Button();
            this.getButton = new System.Windows.Forms.Button();
            this.sourceButton = new System.Windows.Forms.Button();
            this.errorIcon = new System.Windows.Forms.PictureBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.tempLabel = new System.Windows.Forms.Label();
            this.stateLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.stateBox = new System.Windows.Forms.ComboBox();
            this.tempTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.tempBox = new System.Windows.Forms.GroupBox();
            this.panel = new System.Windows.Forms.Panel();
            this.tempLabel2 = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.iconBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.regionTextBox = new System.Windows.Forms.TextBox();
            this.regionLabel = new System.Windows.Forms.Label();
            this.mnTextBox = new System.Windows.Forms.TextBox();
            this.ndTextBox = new System.Windows.Forms.TextBox();
            this.sdTextBox = new System.Windows.Forms.TextBox();
            this.iaTextBox = new System.Windows.Forms.TextBox();
            this.wiTextBox = new System.Windows.Forms.TextBox();
            this.wiLabel = new System.Windows.Forms.Label();
            this.iaLabel = new System.Windows.Forms.Label();
            this.sdLabel = new System.Windows.Forms.Label();
            this.ndLabel = new System.Windows.Forms.Label();
            this.mnLabel = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.refreshBox2 = new System.Windows.Forms.PictureBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.blankBox = new System.Windows.Forms.PictureBox();
            this.noDataLabel = new System.Windows.Forms.Label();
            this.confirmButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.removeSelectedButton = new System.Windows.Forms.Button();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.saveButton = new System.Windows.Forms.Button();
            this.copyrightLabel = new System.Windows.Forms.Label();
            this.filterBox = new System.Windows.Forms.PictureBox();
            this.moreButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.weatherBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcon)).BeginInit();
            this.tempBox.SuspendLayout();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blankBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filterBox)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 255);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(556, 174);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView_EditingControlShowing);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.searchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchTextBox.Location = new System.Drawing.Point(12, 232);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.PlaceholderText = "Search...";
            this.searchTextBox.Size = new System.Drawing.Size(90, 23);
            this.searchTextBox.TabIndex = 1;
            this.searchTextBox.TabStop = false;
            this.toolTip1.SetToolTip(this.searchTextBox, "Filter by city");
            this.searchTextBox.Visible = false;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(229, 232);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(92, 23);
            this.removeButton.TabIndex = 3;
            this.removeButton.Text = "Remove 🧹";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Visible = false;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // editButton
            // 
            this.editButton.CausesValidation = false;
            this.editButton.FlatAppearance.BorderSize = 0;
            this.editButton.Location = new System.Drawing.Point(133, 232);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(91, 23);
            this.editButton.TabIndex = 4;
            this.editButton.Text = "Edit ✏️";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Visible = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // highButton
            // 
            this.highButton.Location = new System.Drawing.Point(12, 447);
            this.highButton.Name = "highButton";
            this.highButton.Size = new System.Drawing.Size(115, 23);
            this.highButton.TabIndex = 5;
            this.highButton.TabStop = false;
            this.highButton.Text = "Highest Temp 🔥";
            this.highButton.UseVisualStyleBackColor = true;
            this.highButton.Visible = false;
            this.highButton.Click += new System.EventHandler(this.highButton_Click);
            // 
            // lowButton
            // 
            this.lowButton.Location = new System.Drawing.Point(12, 485);
            this.lowButton.Name = "lowButton";
            this.lowButton.Size = new System.Drawing.Size(115, 23);
            this.lowButton.TabIndex = 6;
            this.lowButton.TabStop = false;
            this.lowButton.Text = "Lowest Temp  ❄";
            this.lowButton.UseVisualStyleBackColor = true;
            this.lowButton.Visible = false;
            this.lowButton.Click += new System.EventHandler(this.lowButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.SystemColors.Control;
            this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Location = new System.Drawing.Point(486, 485);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(82, 23);
            this.closeButton.TabIndex = 8;
            this.closeButton.TabStop = false;
            this.closeButton.Text = "Close   ❌";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // weatherBox
            // 
            this.weatherBox.Controls.Add(this.newButton);
            this.weatherBox.Controls.Add(this.getButton);
            this.weatherBox.Controls.Add(this.sourceButton);
            this.weatherBox.Controls.Add(this.errorIcon);
            this.weatherBox.Controls.Add(this.dateLabel);
            this.weatherBox.Controls.Add(this.tempLabel);
            this.weatherBox.Controls.Add(this.stateLabel);
            this.weatherBox.Controls.Add(this.cityLabel);
            this.weatherBox.Controls.Add(this.clearButton);
            this.weatherBox.Controls.Add(this.addButton);
            this.weatherBox.Controls.Add(this.dateTimePicker1);
            this.weatherBox.Controls.Add(this.stateBox);
            this.weatherBox.Controls.Add(this.tempTextBox);
            this.weatherBox.Controls.Add(this.cityTextBox);
            this.weatherBox.Location = new System.Drawing.Point(12, 12);
            this.weatherBox.Name = "weatherBox";
            this.weatherBox.Size = new System.Drawing.Size(309, 214);
            this.weatherBox.TabIndex = 9;
            this.weatherBox.TabStop = false;
            this.weatherBox.Text = "Temperature Information";
            // 
            // newButton
            // 
            this.newButton.Location = new System.Drawing.Point(147, 179);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(75, 23);
            this.newButton.TabIndex = 19;
            this.newButton.TabStop = false;
            this.newButton.Text = "New";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // getButton
            // 
            this.getButton.Location = new System.Drawing.Point(16, 92);
            this.getButton.Name = "getButton";
            this.getButton.Size = new System.Drawing.Size(74, 23);
            this.getButton.TabIndex = 20;
            this.getButton.Text = "Get";
            this.getButton.UseVisualStyleBackColor = true;
            this.getButton.Visible = false;
            this.getButton.Click += new System.EventHandler(this.getButton_Click);
            // 
            // sourceButton
            // 
            this.sourceButton.Location = new System.Drawing.Point(27, 179);
            this.sourceButton.Name = "sourceButton";
            this.sourceButton.Size = new System.Drawing.Size(114, 23);
            this.sourceButton.TabIndex = 18;
            this.sourceButton.Text = "Select Source";
            this.sourceButton.UseVisualStyleBackColor = true;
            this.sourceButton.Click += new System.EventHandler(this.SourceButton_Click);
            // 
            // errorIcon
            // 
            this.errorIcon.Image = ((System.Drawing.Image)(resources.GetObject("errorIcon.Image")));
            this.errorIcon.Location = new System.Drawing.Point(96, 50);
            this.errorIcon.Name = "errorIcon";
            this.errorIcon.Size = new System.Drawing.Size(16, 16);
            this.errorIcon.TabIndex = 21;
            this.errorIcon.TabStop = false;
            this.toolTip2.SetToolTip(this.errorIcon, "City could not be verified");
            this.errorIcon.Visible = false;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(134, 153);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(31, 15);
            this.dateLabel.TabIndex = 17;
            this.dateLabel.Text = "Date";
            // 
            // tempLabel
            // 
            this.tempLabel.AutoSize = true;
            this.tempLabel.Location = new System.Drawing.Point(123, 110);
            this.tempLabel.Name = "tempLabel";
            this.tempLabel.Size = new System.Drawing.Size(71, 15);
            this.tempLabel.TabIndex = 16;
            this.tempLabel.Text = "Temp (in °F)";
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Location = new System.Drawing.Point(132, 70);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(33, 15);
            this.stateLabel.TabIndex = 15;
            this.stateLabel.Text = "State";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(134, 29);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(28, 15);
            this.cityLabel.TabIndex = 14;
            this.cityLabel.Text = "City";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(15, 133);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 13;
            this.clearButton.TabStop = false;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Visible = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(15, 47);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 12;
            this.addButton.Text = "➕";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Visible = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(171, 147);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(100, 23);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // stateBox
            // 
            this.stateBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.stateBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.stateBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stateBox.FormattingEnabled = true;
            this.stateBox.Location = new System.Drawing.Point(171, 67);
            this.stateBox.Name = "stateBox";
            this.stateBox.Size = new System.Drawing.Size(100, 23);
            this.stateBox.TabIndex = 2;
            // 
            // tempTextBox
            // 
            this.tempTextBox.BackColor = System.Drawing.Color.White;
            this.tempTextBox.Location = new System.Drawing.Point(200, 107);
            this.tempTextBox.Name = "tempTextBox";
            this.tempTextBox.ReadOnly = true;
            this.tempTextBox.Size = new System.Drawing.Size(71, 23);
            this.tempTextBox.TabIndex = 2;
            this.tempTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tempTextBox_KeyPress);
            // 
            // cityTextBox
            // 
            this.cityTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cityTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cityTextBox.BackColor = System.Drawing.Color.White;
            this.cityTextBox.Location = new System.Drawing.Point(171, 29);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.ReadOnly = true;
            this.cityTextBox.Size = new System.Drawing.Size(100, 23);
            this.cityTextBox.TabIndex = 1;
            this.cityTextBox.TextChanged += new System.EventHandler(this.cityTextBox_TextChanged);
            // 
            // tempBox
            // 
            this.tempBox.Controls.Add(this.panel);
            this.tempBox.Controls.Add(this.panel1);
            this.tempBox.Controls.Add(this.regionTextBox);
            this.tempBox.Controls.Add(this.regionLabel);
            this.tempBox.Controls.Add(this.mnTextBox);
            this.tempBox.Controls.Add(this.ndTextBox);
            this.tempBox.Controls.Add(this.sdTextBox);
            this.tempBox.Controls.Add(this.iaTextBox);
            this.tempBox.Controls.Add(this.wiTextBox);
            this.tempBox.Controls.Add(this.wiLabel);
            this.tempBox.Controls.Add(this.iaLabel);
            this.tempBox.Controls.Add(this.sdLabel);
            this.tempBox.Controls.Add(this.ndLabel);
            this.tempBox.Controls.Add(this.mnLabel);
            this.tempBox.Location = new System.Drawing.Point(327, 12);
            this.tempBox.Name = "tempBox";
            this.tempBox.Size = new System.Drawing.Size(293, 214);
            this.tempBox.TabIndex = 10;
            this.tempBox.TabStop = false;
            this.tempBox.Text = "Average Temperature";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.tempLabel2);
            this.panel.Controls.Add(this.descriptionLabel);
            this.panel.Controls.Add(this.iconBox);
            this.panel.Location = new System.Drawing.Point(143, 47);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(144, 162);
            this.panel.TabIndex = 25;
            // 
            // tempLabel2
            // 
            this.tempLabel2.AutoSize = true;
            this.tempLabel2.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tempLabel2.Location = new System.Drawing.Point(54, 117);
            this.tempLabel2.Name = "tempLabel2";
            this.tempLabel2.Size = new System.Drawing.Size(36, 16);
            this.tempLabel2.TabIndex = 24;
            this.tempLabel2.Text = "temp";
            this.tempLabel2.Visible = false;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.descriptionLabel.Location = new System.Drawing.Point(54, 141);
            this.descriptionLabel.Margin = new System.Windows.Forms.Padding(85, 0, 45, 0);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(66, 17);
            this.descriptionLabel.TabIndex = 23;
            this.descriptionLabel.Text = "description";
            this.descriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.descriptionLabel.UseCompatibleTextRendering = true;
            this.descriptionLabel.Visible = false;
            // 
            // iconBox
            // 
            this.iconBox.Image = ((System.Drawing.Image)(resources.GetObject("iconBox.Image")));
            this.iconBox.Location = new System.Drawing.Point(34, 23);
            this.iconBox.Name = "iconBox";
            this.iconBox.Size = new System.Drawing.Size(80, 76);
            this.iconBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconBox.TabIndex = 22;
            this.iconBox.TabStop = false;
            this.iconBox.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(118, 214);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 23);
            this.panel1.TabIndex = 24;
            // 
            // regionTextBox
            // 
            this.regionTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.regionTextBox.Location = new System.Drawing.Point(98, 22);
            this.regionTextBox.Name = "regionTextBox";
            this.regionTextBox.ReadOnly = true;
            this.regionTextBox.Size = new System.Drawing.Size(90, 23);
            this.regionTextBox.TabIndex = 11;
            this.regionTextBox.TabStop = false;
            this.regionTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // regionLabel
            // 
            this.regionLabel.AutoSize = true;
            this.regionLabel.Location = new System.Drawing.Point(48, 25);
            this.regionLabel.Name = "regionLabel";
            this.regionLabel.Size = new System.Drawing.Size(44, 15);
            this.regionLabel.TabIndex = 10;
            this.regionLabel.Text = "Region";
            // 
            // mnTextBox
            // 
            this.mnTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.mnTextBox.Location = new System.Drawing.Point(37, 186);
            this.mnTextBox.Name = "mnTextBox";
            this.mnTextBox.ReadOnly = true;
            this.mnTextBox.Size = new System.Drawing.Size(100, 23);
            this.mnTextBox.TabIndex = 9;
            this.mnTextBox.TabStop = false;
            this.mnTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ndTextBox
            // 
            this.ndTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.ndTextBox.Location = new System.Drawing.Point(37, 155);
            this.ndTextBox.Name = "ndTextBox";
            this.ndTextBox.ReadOnly = true;
            this.ndTextBox.Size = new System.Drawing.Size(100, 23);
            this.ndTextBox.TabIndex = 8;
            this.ndTextBox.TabStop = false;
            this.ndTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // sdTextBox
            // 
            this.sdTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.sdTextBox.Location = new System.Drawing.Point(37, 123);
            this.sdTextBox.Name = "sdTextBox";
            this.sdTextBox.ReadOnly = true;
            this.sdTextBox.Size = new System.Drawing.Size(100, 23);
            this.sdTextBox.TabIndex = 7;
            this.sdTextBox.TabStop = false;
            this.sdTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // iaTextBox
            // 
            this.iaTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.iaTextBox.Location = new System.Drawing.Point(37, 92);
            this.iaTextBox.Name = "iaTextBox";
            this.iaTextBox.ReadOnly = true;
            this.iaTextBox.Size = new System.Drawing.Size(100, 23);
            this.iaTextBox.TabIndex = 6;
            this.iaTextBox.TabStop = false;
            this.iaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // wiTextBox
            // 
            this.wiTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.wiTextBox.Location = new System.Drawing.Point(37, 60);
            this.wiTextBox.Name = "wiTextBox";
            this.wiTextBox.ReadOnly = true;
            this.wiTextBox.Size = new System.Drawing.Size(100, 23);
            this.wiTextBox.TabIndex = 5;
            this.wiTextBox.TabStop = false;
            this.wiTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // wiLabel
            // 
            this.wiLabel.AutoSize = true;
            this.wiLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.wiLabel.Location = new System.Drawing.Point(3, 51);
            this.wiLabel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.wiLabel.Name = "wiLabel";
            this.wiLabel.Padding = new System.Windows.Forms.Padding(7, 12, 0, 5);
            this.wiLabel.Size = new System.Drawing.Size(28, 32);
            this.wiLabel.TabIndex = 4;
            this.wiLabel.Text = "WI";
            // 
            // iaLabel
            // 
            this.iaLabel.AutoSize = true;
            this.iaLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.iaLabel.Location = new System.Drawing.Point(3, 83);
            this.iaLabel.Name = "iaLabel";
            this.iaLabel.Padding = new System.Windows.Forms.Padding(7, 12, 0, 5);
            this.iaLabel.Size = new System.Drawing.Size(25, 32);
            this.iaLabel.TabIndex = 3;
            this.iaLabel.Text = "IA";
            // 
            // sdLabel
            // 
            this.sdLabel.AutoSize = true;
            this.sdLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sdLabel.Location = new System.Drawing.Point(3, 115);
            this.sdLabel.Name = "sdLabel";
            this.sdLabel.Padding = new System.Windows.Forms.Padding(7, 12, 0, 5);
            this.sdLabel.Size = new System.Drawing.Size(28, 32);
            this.sdLabel.TabIndex = 2;
            this.sdLabel.Text = "SD";
            // 
            // ndLabel
            // 
            this.ndLabel.AutoSize = true;
            this.ndLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ndLabel.Location = new System.Drawing.Point(3, 147);
            this.ndLabel.Name = "ndLabel";
            this.ndLabel.Padding = new System.Windows.Forms.Padding(7, 12, 0, 5);
            this.ndLabel.Size = new System.Drawing.Size(31, 32);
            this.ndLabel.TabIndex = 1;
            this.ndLabel.Text = "ND";
            // 
            // mnLabel
            // 
            this.mnLabel.AutoSize = true;
            this.mnLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mnLabel.Location = new System.Drawing.Point(3, 179);
            this.mnLabel.Name = "mnLabel";
            this.mnLabel.Padding = new System.Windows.Forms.Padding(7, 12, 0, 5);
            this.mnLabel.Size = new System.Drawing.Size(34, 32);
            this.mnLabel.TabIndex = 0;
            this.mnLabel.Text = "MN";
            // 
            // refreshBox2
            // 
            this.refreshBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.refreshBox2.Enabled = false;
            this.refreshBox2.Image = ((System.Drawing.Image)(resources.GetObject("refreshBox2.Image")));
            this.refreshBox2.Location = new System.Drawing.Point(133, 469);
            this.refreshBox2.MaximumSize = new System.Drawing.Size(23, 23);
            this.refreshBox2.Name = "refreshBox2";
            this.refreshBox2.Size = new System.Drawing.Size(20, 20);
            this.refreshBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.refreshBox2.TabIndex = 11;
            this.refreshBox2.TabStop = false;
            this.refreshBox2.Visible = false;
            this.refreshBox2.Click += new System.EventHandler(this.refreshBox2_Click);
            // 
            // resetButton
            // 
            this.resetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetButton.Location = new System.Drawing.Point(405, 485);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 12;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Visible = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(327, 232);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 13;
            this.cancelButton.TabStop = false;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Visible = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // blankBox
            // 
            this.blankBox.BackColor = System.Drawing.SystemColors.Window;
            this.blankBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.blankBox.Location = new System.Drawing.Point(13, 256);
            this.blankBox.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.blankBox.Name = "blankBox";
            this.blankBox.Size = new System.Drawing.Size(554, 172);
            this.blankBox.TabIndex = 15;
            this.blankBox.TabStop = false;
            // 
            // noDataLabel
            // 
            this.noDataLabel.AutoSize = true;
            this.noDataLabel.BackColor = System.Drawing.SystemColors.Window;
            this.noDataLabel.Location = new System.Drawing.Point(271, 335);
            this.noDataLabel.Name = "noDataLabel";
            this.noDataLabel.Size = new System.Drawing.Size(50, 15);
            this.noDataLabel.TabIndex = 16;
            this.noDataLabel.Text = "No Data";
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(230, 232);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(92, 23);
            this.confirmButton.TabIndex = 12;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Visible = false;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 4000;
            // 
            // removeSelectedButton
            // 
            this.removeSelectedButton.ForeColor = System.Drawing.Color.Red;
            this.removeSelectedButton.Location = new System.Drawing.Point(103, 232);
            this.removeSelectedButton.Name = "removeSelectedButton";
            this.removeSelectedButton.Size = new System.Drawing.Size(24, 23);
            this.removeSelectedButton.TabIndex = 18;
            this.removeSelectedButton.TabStop = false;
            this.removeSelectedButton.Text = "❌";
            this.removeSelectedButton.UseVisualStyleBackColor = true;
            this.removeSelectedButton.Visible = false;
            this.removeSelectedButton.Click += new System.EventHandler(this.removeSelectedButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(133, 232);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(91, 23);
            this.saveButton.TabIndex = 19;
            this.saveButton.Text = "Save  💾";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Visible = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click_1);
            // 
            // copyrightLabel
            // 
            this.copyrightLabel.AutoSize = true;
            this.copyrightLabel.Location = new System.Drawing.Point(216, 435);
            this.copyrightLabel.Name = "copyrightLabel";
            this.copyrightLabel.Size = new System.Drawing.Size(158, 15);
            this.copyrightLabel.TabIndex = 20;
            this.copyrightLabel.Text = "©️ Weston Evans Spring 2023";
            // 
            // filterBox
            // 
            this.filterBox.BackColor = System.Drawing.Color.White;
            this.filterBox.Image = ((System.Drawing.Image)(resources.GetObject("filterBox.Image")));
            this.filterBox.Location = new System.Drawing.Point(91, 231);
            this.filterBox.Name = "filterBox";
            this.filterBox.Size = new System.Drawing.Size(10, 10);
            this.filterBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.filterBox.TabIndex = 22;
            this.filterBox.TabStop = false;
            this.filterBox.Visible = false;
            this.filterBox.Click += new System.EventHandler(this.filterBox_Click);
            // 
            // moreButton
            // 
            this.moreButton.Location = new System.Drawing.Point(492, 431);
            this.moreButton.Name = "moreButton";
            this.moreButton.Size = new System.Drawing.Size(75, 23);
            this.moreButton.TabIndex = 23;
            this.moreButton.Text = "More...";
            this.moreButton.UseVisualStyleBackColor = true;
            this.moreButton.Visible = false;
            this.moreButton.Click += new System.EventHandler(this.moreButton_Click);
            // 
            // WeatherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(630, 521);
            this.Controls.Add(this.moreButton);
            this.Controls.Add(this.filterBox);
            this.Controls.Add(this.copyrightLabel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.removeSelectedButton);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.noDataLabel);
            this.Controls.Add(this.blankBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.refreshBox2);
            this.Controls.Add(this.tempBox);
            this.Controls.Add(this.weatherBox);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.lowButton);
            this.Controls.Add(this.highButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "WeatherForm";
            this.Text = "Temperature Analysis V2.0 ";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.WeatherForm_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.weatherBox.ResumeLayout(false);
            this.weatherBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcon)).EndInit();
            this.tempBox.ResumeLayout(false);
            this.tempBox.PerformLayout();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blankBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filterBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox searchTextBox;
        private Button removeButton;
        private Button editButton;
        private Button highButton;
        private Button lowButton;
        private Button closeButton;
        private GroupBox weatherBox;
        private DateTimePicker dateTimePicker1;
        private TextBox tempTextBox;
        private GroupBox tempBox;
        private Label dateLabel;
        private Label tempLabel;
        private Label stateLabel;
        private Label cityLabel;
        private Button clearButton;
        private Button addButton;
        private TextBox cityTextBox;
        private ToolTip toolTip1;
        private ComboBox stateBox;
        private PictureBox refreshBox2;
        private Label wiLabel;
        private Label iaLabel;
        private Label sdLabel;
        private Label ndLabel;
        private Label mnLabel;
        private TextBox mnTextBox;
        private TextBox ndTextBox;
        private TextBox sdTextBox;
        private TextBox iaTextBox;
        private TextBox wiTextBox;
        private TextBox regionTextBox;
        private Label regionLabel;
        private Button resetButton;
        private Button cancelButton;
        private PictureBox blankBox;
        private Label noDataLabel;
        private Button confirmButton;
        private System.Windows.Forms.Timer timer1;
        private Button removeSelectedButton;
        private PictureBox errorIcon;
        private ToolTip toolTip2;
        private Button saveButton;
        private Label copyrightLabel;
        private Button getButton;
        private Button newButton;
        private Button sourceButton;
        private PictureBox iconBox;
        private Label descriptionLabel;
        private Panel panel;
        private Panel panel1;
        private Label tempLabel2;
        private PictureBox filterBox;
        private Button moreButton;
    }
}