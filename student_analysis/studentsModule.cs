using System;
using System.Drawing;
using System.Windows.Forms;

namespace student_analysis
{
    public partial class studentsModule : Form
    {
        public studentsModule()
        {
            InitializeComponent();
        }

        private void studentsModule_Load(object sender, EventArgs e)
        {
            this.studentsTableAdapter.Fill(this.mainDataSet1.students);
            studentsModule_Resize(this, e);
            MinimumSize = new Size(info.minSize[0], info.minSize[1]);
        }

        private void studentsModule_Resize(object sender, EventArgs e)
        {
            dataGridView1.Columns[2].Width = dataGridView1.Columns[0].Width = 75;
            dataGridView1.Columns[1].Width = ClientSize.Width - 193;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.studentsTableAdapter.Update(this.mainDataSet1.students);
        }

        private void studentsModule_FormClosed(object sender, FormClosedEventArgs e)
        {
            toolStripButton1_Click(this, e);
        }
    }
}
