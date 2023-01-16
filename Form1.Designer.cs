﻿namespace Project_2
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sourceButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.stateBox = new System.Windows.Forms.ComboBox();
            this.tempTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.tempBox = new System.Windows.Forms.GroupBox();
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
            this.refreshBox = new System.Windows.Forms.PictureBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.bulkInsertButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.weatherBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tempBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refreshBox)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 255);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(556, 180);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.searchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchTextBox.Location = new System.Drawing.Point(12, 232);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.PlaceholderText = "Search...";
            this.searchTextBox.Size = new System.Drawing.Size(100, 23);
            this.searchTextBox.TabIndex = 1;
            this.toolTip1.SetToolTip(this.searchTextBox, "Filter by city, state, or year");
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(394, 232);
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
            this.editButton.FlatAppearance.BorderSize = 0;
            this.editButton.Location = new System.Drawing.Point(297, 232);
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
            this.closeButton.Text = "Close   ❌";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // weatherBox
            // 
            this.weatherBox.Controls.Add(this.newButton);
            this.weatherBox.Controls.Add(this.pictureBox1);
            this.weatherBox.Controls.Add(this.sourceButton);
            this.weatherBox.Controls.Add(this.label4);
            this.weatherBox.Controls.Add(this.label3);
            this.weatherBox.Controls.Add(this.label2);
            this.weatherBox.Controls.Add(this.label1);
            this.weatherBox.Controls.Add(this.clearButton);
            this.weatherBox.Controls.Add(this.addButton);
            this.weatherBox.Controls.Add(this.dateTimePicker1);
            this.weatherBox.Controls.Add(this.stateBox);
            this.weatherBox.Controls.Add(this.tempTextBox);
            this.weatherBox.Controls.Add(this.cityTextBox);
            this.weatherBox.Location = new System.Drawing.Point(12, 12);
            this.weatherBox.Name = "weatherBox";
            this.weatherBox.Size = new System.Drawing.Size(293, 214);
            this.weatherBox.TabIndex = 9;
            this.weatherBox.TabStop = false;
            this.weatherBox.Text = "Weather Information";
            // 
            // newButton
            // 
            this.newButton.Location = new System.Drawing.Point(162, 185);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(75, 23);
            this.newButton.TabIndex = 19;
            this.newButton.Text = "New";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(267, 188);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(23, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // sourceButton
            // 
            this.sourceButton.Location = new System.Drawing.Point(42, 185);
            this.sourceButton.Name = "sourceButton";
            this.sourceButton.Size = new System.Drawing.Size(114, 23);
            this.sourceButton.TabIndex = 18;
            this.sourceButton.Text = "Select Source";
            this.sourceButton.UseVisualStyleBackColor = true;
            this.sourceButton.Click += new System.EventHandler(this.SourceButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(125, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Temp (in °F)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "State";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "City";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(6, 120);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 13;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Visible = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(6, 43);
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
            this.dateTimePicker1.Location = new System.Drawing.Point(162, 143);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(100, 23);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // stateBox
            // 
            this.stateBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.stateBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.stateBox.FormattingEnabled = true;
            this.stateBox.Location = new System.Drawing.Point(162, 63);
            this.stateBox.Name = "stateBox";
            this.stateBox.Size = new System.Drawing.Size(100, 23);
            this.stateBox.TabIndex = 11;
            // 
            // tempTextBox
            // 
            this.tempTextBox.Location = new System.Drawing.Point(191, 103);
            this.tempTextBox.Name = "tempTextBox";
            this.tempTextBox.Size = new System.Drawing.Size(71, 23);
            this.tempTextBox.TabIndex = 2;
            this.tempTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tempTextBox_KeyPress);
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(162, 22);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(100, 23);
            this.cityTextBox.TabIndex = 0;
            this.cityTextBox.TextChanged += new System.EventHandler(this.cityTextBox_TextChanged);
            // 
            // tempBox
            // 
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
            // regionTextBox
            // 
            this.regionTextBox.Enabled = false;
            this.regionTextBox.Location = new System.Drawing.Point(181, 121);
            this.regionTextBox.Name = "regionTextBox";
            this.regionTextBox.ReadOnly = true;
            this.regionTextBox.Size = new System.Drawing.Size(90, 23);
            this.regionTextBox.TabIndex = 11;
            this.regionTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // regionLabel
            // 
            this.regionLabel.AutoSize = true;
            this.regionLabel.Location = new System.Drawing.Point(203, 95);
            this.regionLabel.Name = "regionLabel";
            this.regionLabel.Size = new System.Drawing.Size(44, 15);
            this.regionLabel.TabIndex = 10;
            this.regionLabel.Text = "Region";
            // 
            // mnTextBox
            // 
            this.mnTextBox.Enabled = false;
            this.mnTextBox.Location = new System.Drawing.Point(37, 186);
            this.mnTextBox.Name = "mnTextBox";
            this.mnTextBox.ReadOnly = true;
            this.mnTextBox.Size = new System.Drawing.Size(100, 23);
            this.mnTextBox.TabIndex = 9;
            this.mnTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ndTextBox
            // 
            this.ndTextBox.Enabled = false;
            this.ndTextBox.Location = new System.Drawing.Point(37, 155);
            this.ndTextBox.Name = "ndTextBox";
            this.ndTextBox.ReadOnly = true;
            this.ndTextBox.Size = new System.Drawing.Size(100, 23);
            this.ndTextBox.TabIndex = 8;
            this.ndTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // sdTextBox
            // 
            this.sdTextBox.Enabled = false;
            this.sdTextBox.Location = new System.Drawing.Point(37, 123);
            this.sdTextBox.Name = "sdTextBox";
            this.sdTextBox.ReadOnly = true;
            this.sdTextBox.Size = new System.Drawing.Size(100, 23);
            this.sdTextBox.TabIndex = 7;
            this.sdTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // iaTextBox
            // 
            this.iaTextBox.Enabled = false;
            this.iaTextBox.Location = new System.Drawing.Point(37, 92);
            this.iaTextBox.Name = "iaTextBox";
            this.iaTextBox.ReadOnly = true;
            this.iaTextBox.Size = new System.Drawing.Size(100, 23);
            this.iaTextBox.TabIndex = 6;
            this.iaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // wiTextBox
            // 
            this.wiTextBox.Enabled = false;
            this.wiTextBox.Location = new System.Drawing.Point(37, 60);
            this.wiTextBox.Name = "wiTextBox";
            this.wiTextBox.ReadOnly = true;
            this.wiTextBox.Size = new System.Drawing.Size(100, 23);
            this.wiTextBox.TabIndex = 5;
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
            // refreshBox
            // 
            this.refreshBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.refreshBox.Enabled = false;
            this.refreshBox.Image = ((System.Drawing.Image)(resources.GetObject("refreshBox.Image")));
            this.refreshBox.Location = new System.Drawing.Point(133, 469);
            this.refreshBox.MaximumSize = new System.Drawing.Size(23, 23);
            this.refreshBox.Name = "refreshBox";
            this.refreshBox.Size = new System.Drawing.Size(20, 20);
            this.refreshBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.refreshBox.TabIndex = 11;
            this.refreshBox.TabStop = false;
            this.refreshBox.Visible = false;
            this.refreshBox.Click += new System.EventHandler(this.pictureBox1_Click);
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
            this.cancelButton.Location = new System.Drawing.Point(492, 232);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 13;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Visible = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // bulkInsertButton
            // 
            this.bulkInsertButton.Location = new System.Drawing.Point(216, 232);
            this.bulkInsertButton.Name = "bulkInsertButton";
            this.bulkInsertButton.Size = new System.Drawing.Size(75, 23);
            this.bulkInsertButton.TabIndex = 14;
            this.bulkInsertButton.Text = "Bulk ➕";
            this.bulkInsertButton.UseVisualStyleBackColor = true;
            this.bulkInsertButton.Visible = false;
            this.bulkInsertButton.Click += new System.EventHandler(this.bulkInsertButton_Click);
            // 
            // WeatherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 521);
            this.Controls.Add(this.bulkInsertButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.refreshBox);
            this.Controls.Add(this.tempBox);
            this.Controls.Add(this.weatherBox);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.lowButton);
            this.Controls.Add(this.highButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.dataGridView1);
            this.Name = "WeatherForm";
            this.Text = "Weather App";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.weatherBox.ResumeLayout(false);
            this.weatherBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tempBox.ResumeLayout(false);
            this.tempBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refreshBox)).EndInit();
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
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button clearButton;
        private Button addButton;
        private Button sourceButton;
        private TextBox cityTextBox;
        private ToolTip toolTip1;
        private ComboBox stateBox;
        private PictureBox refreshBox;
        private PictureBox pictureBox1;
        private Button newButton;
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
        private Button bulkInsertButton;
    }
}