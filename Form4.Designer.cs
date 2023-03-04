namespace Project_2
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.previousButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.removeAllButton = new System.Windows.Forms.Button();
            this.bulkInsertButton = new System.Windows.Forms.Button();
            this.advancedFilter = new System.Windows.Forms.Button();
            this.plotButton = new System.Windows.Forms.Button();
            this.removeSelectedButton = new System.Windows.Forms.Button();
            this.refreshBox2 = new System.Windows.Forms.PictureBox();
            this.pagesBox = new System.Windows.Forms.TextBox();
            this.distributionButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1080, 406);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // previousButton
            // 
            this.previousButton.Location = new System.Drawing.Point(12, 455);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(75, 23);
            this.previousButton.TabIndex = 1;
            this.previousButton.Text = "<<";
            this.previousButton.UseVisualStyleBackColor = true;
            this.previousButton.Click += new System.EventHandler(this.previousButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(93, 455);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(75, 23);
            this.nextButton.TabIndex = 2;
            this.nextButton.Text = ">>";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // removeAllButton
            // 
            this.removeAllButton.Location = new System.Drawing.Point(1019, 455);
            this.removeAllButton.Name = "removeAllButton";
            this.removeAllButton.Size = new System.Drawing.Size(75, 23);
            this.removeAllButton.TabIndex = 22;
            this.removeAllButton.TabStop = false;
            this.removeAllButton.Text = "Remove All";
            this.removeAllButton.UseVisualStyleBackColor = true;
            this.removeAllButton.Click += new System.EventHandler(this.removeAllButton_Click);
            // 
            // bulkInsertButton
            // 
            this.bulkInsertButton.Location = new System.Drawing.Point(857, 455);
            this.bulkInsertButton.Name = "bulkInsertButton";
            this.bulkInsertButton.Size = new System.Drawing.Size(75, 23);
            this.bulkInsertButton.TabIndex = 23;
            this.bulkInsertButton.TabStop = false;
            this.bulkInsertButton.Text = "Bulk Insert";
            this.bulkInsertButton.UseVisualStyleBackColor = true;
            this.bulkInsertButton.Click += new System.EventHandler(this.bulkInsertButton_Click);
            // 
            // advancedFilter
            // 
            this.advancedFilter.Location = new System.Drawing.Point(12, 14);
            this.advancedFilter.Name = "advancedFilter";
            this.advancedFilter.Size = new System.Drawing.Size(75, 23);
            this.advancedFilter.TabIndex = 24;
            this.advancedFilter.Text = "Filter 🔎";
            this.advancedFilter.UseVisualStyleBackColor = true;
            this.advancedFilter.Click += new System.EventHandler(this.advancedFilter_Click);
            // 
            // plotButton
            // 
            this.plotButton.Location = new System.Drawing.Point(938, 455);
            this.plotButton.Name = "plotButton";
            this.plotButton.Size = new System.Drawing.Size(75, 23);
            this.plotButton.TabIndex = 25;
            this.plotButton.TabStop = false;
            this.plotButton.Text = "Plot 📈";
            this.plotButton.UseVisualStyleBackColor = true;
            this.plotButton.Click += new System.EventHandler(this.plotButton_Click);
            // 
            // removeSelectedButton
            // 
            this.removeSelectedButton.ForeColor = System.Drawing.Color.Red;
            this.removeSelectedButton.Location = new System.Drawing.Point(119, 14);
            this.removeSelectedButton.Name = "removeSelectedButton";
            this.removeSelectedButton.Size = new System.Drawing.Size(24, 25);
            this.removeSelectedButton.TabIndex = 26;
            this.removeSelectedButton.TabStop = false;
            this.removeSelectedButton.Text = "❌";
            this.removeSelectedButton.UseVisualStyleBackColor = true;
            this.removeSelectedButton.Visible = false;
            this.removeSelectedButton.Click += new System.EventHandler(this.removeSelectedButton_Click);
            // 
            // refreshBox2
            // 
            this.refreshBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.refreshBox2.Image = ((System.Drawing.Image)(resources.GetObject("refreshBox2.Image")));
            this.refreshBox2.Location = new System.Drawing.Point(93, 14);
            this.refreshBox2.MaximumSize = new System.Drawing.Size(23, 23);
            this.refreshBox2.Name = "refreshBox2";
            this.refreshBox2.Size = new System.Drawing.Size(20, 23);
            this.refreshBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.refreshBox2.TabIndex = 27;
            this.refreshBox2.TabStop = false;
            this.refreshBox2.Click += new System.EventHandler(this.refreshBox2_Click);
            // 
            // pagesBox
            // 
            this.pagesBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pagesBox.Enabled = false;
            this.pagesBox.Location = new System.Drawing.Point(174, 455);
            this.pagesBox.Name = "pagesBox";
            this.pagesBox.Size = new System.Drawing.Size(55, 23);
            this.pagesBox.TabIndex = 28;
            this.pagesBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // distributionButton
            // 
            this.distributionButton.Location = new System.Drawing.Point(721, 455);
            this.distributionButton.Name = "distributionButton";
            this.distributionButton.Size = new System.Drawing.Size(130, 23);
            this.distributionButton.TabIndex = 29;
            this.distributionButton.Text = "Record Distribution";
            this.distributionButton.UseVisualStyleBackColor = true;
            this.distributionButton.Click += new System.EventHandler(this.distributionButton_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 486);
            this.Controls.Add(this.distributionButton);
            this.Controls.Add(this.pagesBox);
            this.Controls.Add(this.refreshBox2);
            this.Controls.Add(this.removeSelectedButton);
            this.Controls.Add(this.plotButton);
            this.Controls.Add(this.advancedFilter);
            this.Controls.Add(this.bulkInsertButton);
            this.Controls.Add(this.removeAllButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.previousButton);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4";
            this.Text = "Enhanced View";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form4_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Button previousButton;
        private Button nextButton;
        private Button removeAllButton;
        private Button bulkInsertButton;
        private Button advancedFilter;
        private Button plotButton;
        private Button removeSelectedButton;
        private PictureBox refreshBox2;
        private TextBox pageBox;
        private TextBox pagesBox;
        private Button distributionButton;
    }
}