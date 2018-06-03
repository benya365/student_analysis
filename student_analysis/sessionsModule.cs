using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace student_analysis
{
    public partial class sessionsModule : Form
    {
        public sessionsModule()
        {
            InitializeComponent();
        }

        private void sessionsModule_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mainDataSet.session". При необходимости она может быть перемещена или удалена.
            this.sessionTableAdapter.Fill(this.mainDataSet.session);
            sessionsModule_Resize(this, e);
            MinimumSize = new Size(info.minSize[0], info.minSize[1]);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            sessionTableAdapter.Update(mainDataSet.session);
        }

        private void sessionsModule_FormClosed(object sender, FormClosedEventArgs e)
        {
            toolStripButton1_Click(this, e);
        }

        private void sessionsModule_Resize(object sender, EventArgs e)
        {
            dataGridView1.Size = new Size(ClientSize.Width + 17, ClientSize.Height - 25);
            dataGridView1.Columns[0].Width = ClientSize.Width - 283;
            for (int i = 1; i < dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns[i].Width = 80;
            }
        }
    }
}
