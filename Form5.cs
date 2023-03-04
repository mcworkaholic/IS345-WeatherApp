using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_2
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        public string getDBName()
        {
            DialogResult = DialogResult.OK;
            return dbNameBox.Text;
        }
        private void okButton_Click(object sender, EventArgs e)
        {
            getDBName();
        }

        private void dbNameBox_TextChanged(object sender, EventArgs e)
        {
            string pattern = @"^[\w\-. ]+$"; 
            if (dbNameBox.Text.Length != 0)
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(dbNameBox.Text, pattern))
                {
                    MessageBox.Show("This textbox accepts valid Windows filename characters");
                    dbNameBox.Text = dbNameBox.Text.Remove(dbNameBox.Text.Length - 1);
                    dbNameBox.Select(dbNameBox.Text.Length, 0);
                }
            }
        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
