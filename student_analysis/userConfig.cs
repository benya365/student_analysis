using System;
using System.Windows.Forms;

namespace student_analysis
{
    public partial class userConfig : Form
    {
        public userConfig(string form_text)
        {
            InitializeComponent();
            Text = form_text;
        }

        private void userConfig_Load(object sender, EventArgs e)
        {
            this.usersTableAdapter.Fill(this.mainDataSet1.users);
            userConfig_Resize(this, e);
            MinimumSize = Size;
        }

        private void userConfig_Resize(object sender, EventArgs e)
        {
            dataGridView1.Columns[0].Width = 75;
            dataGridView1.Columns[1].Width = ClientSize.Width - 268;
            dataGridView1.Columns[2].Width = 150;            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void userConfig_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                button2_Click(this, e);
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            usersTableAdapter.Update(mainDataSet1.users);
        }

        private void userConfig_FormClosed(object sender, FormClosedEventArgs e)
        {
            saveBtn_Click(this, e);
        }
    }
}
