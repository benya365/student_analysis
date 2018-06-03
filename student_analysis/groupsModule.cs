using System;
using System.Drawing;
using System.Windows.Forms;

namespace student_analysis
{
    public partial class groupsModule : Form
    {
        public groupsModule()
        {
            InitializeComponent();
        }

        private void groupsModule_Load(object sender, EventArgs e)
        {
            this.groupsTableAdapter.Fill(this.mainDataSet1.groups);
            MinimumSize = new Size(info.minSize[0], info.minSize[1]);
            groupsModule_Resize(this, e);
        }

        private void groupsModule_Resize(object sender, EventArgs e)
        {
            dataGridView1.Size = new Size(ClientSize.Width + 17, ClientSize.Height - 25);
            dataGridView1.Columns[0].Width = 75;
            dataGridView1.Columns[1].Width = ClientSize.Width - 118;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            groupsTableAdapter.Update(mainDataSet1.groups);
        }
    }
}
