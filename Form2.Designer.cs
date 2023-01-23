namespace Project_2
{
    partial class Form2
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
            this.okButton = new System.Windows.Forms.Button();
            this.endBox = new System.Windows.Forms.ComboBox();
            this.beginBox = new System.Windows.Forms.ComboBox();
            this.beginLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.toLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(201, 110);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // endBox
            // 
            this.endBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.endBox.FormattingEnabled = true;
            this.endBox.Location = new System.Drawing.Point(209, 43);
            this.endBox.Name = "endBox";
            this.endBox.Size = new System.Drawing.Size(74, 23);
            this.endBox.TabIndex = 1;
            // 
            // beginBox
            // 
            this.beginBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.beginBox.FormattingEnabled = true;
            this.beginBox.Location = new System.Drawing.Point(70, 43);
            this.beginBox.Name = "beginBox";
            this.beginBox.Size = new System.Drawing.Size(74, 23);
            this.beginBox.TabIndex = 2;
            // 
            // beginLabel
            // 
            this.beginLabel.AutoSize = true;
            this.beginLabel.Location = new System.Drawing.Point(26, 46);
            this.beginLabel.Name = "beginLabel";
            this.beginLabel.Size = new System.Drawing.Size(37, 15);
            this.beginLabel.TabIndex = 4;
            this.beginLabel.Text = "Begin";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(282, 110);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Location = new System.Drawing.Point(166, 46);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(22, 15);
            this.toLabel.TabIndex = 6;
            this.toLabel.Text = "To:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 145);
            this.ControlBox = false;
            this.Controls.Add(this.toLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.beginLabel);
            this.Controls.Add(this.beginBox);
            this.Controls.Add(this.endBox);
            this.Controls.Add(this.okButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Please Select a Range";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button okButton;
        private ComboBox endBox;
        private ComboBox beginBox;
        private Label beginLabel;
        private Button cancelButton;
        private Label toLabel;
    }
}