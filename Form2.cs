namespace Project_2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            var yearList1 = Enumerable.Range(1920, 2023 - 1920 + 1).ToList();
            var yearList2 = Enumerable.Range(1920, 2023 - 1920 + 1).ToList();
            beginBox.DataSource = yearList1;
            endBox.DataSource = yearList2;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public (string, string) YearRange()
        {
            string beginYear = beginBox.Text;
            string endYear = endBox.Text;
            return (beginYear, endYear);
        }
        private void okButton_Click(object sender, EventArgs e)
        {
            // Range checking
            if (Int32.Parse(beginBox.Text) > Int32.Parse(endBox.Text))
            {
                MessageBox.Show("Beginning year must be less than ending year");
            }
            else
            {   // Continue
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
