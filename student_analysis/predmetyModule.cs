using System;
using System.Drawing;
using System.Windows.Forms;

namespace student_analysis
{
    public partial class predmetyModule : Form
    {
        public predmetyModule()
        {
            InitializeComponent();
        }

        private void predmetyModule_Load(object sender, EventArgs e)
        {
            this.predmetyTableAdapter.Fill(this.mainDataSet1.predmety);
            predmetyModule_Resize(this, e);
            MinimumSize = new Size(info.minSize[0], info.minSize[1] + dataGridView1.Rows[0].Height * 4);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.predmetyTableAdapter.Update(this.mainDataSet1.predmety);
        }

        private void predmetyModule_Resize(object sender, EventArgs e)
        {
            dataGridView1.Columns[0].Width = 75;
            dataGridView1.Columns[1].Width = ClientSize.Width - 118;
        }

        private void predmetyModule_FormClosed(object sender, FormClosedEventArgs e)
        {
            toolStripButton1_Click(this, e);
        }
    }
}
